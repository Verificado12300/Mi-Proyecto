using SistemaPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SistemaPOS.Data
{
    public class ContabilidadRepository
    {
        /// <summary>
        /// Crea un asiento contable y retorna el ID generado.
        /// </summary>
        public static long CrearAsiento(Asiento asiento, SQLiteConnection connection, SQLiteTransaction transaction)
        {
            string query = @"
                INSERT INTO Asientos (FechaHora, TipoOperacion, Documento, Usuario, Observacion)
                VALUES (@FechaHora, @TipoOperacion, @Documento, @Usuario, @Observacion)";

            using (var cmd = new SQLiteCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@FechaHora", asiento.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@TipoOperacion", asiento.TipoOperacion);
                cmd.Parameters.AddWithValue("@Documento", (object)asiento.Documento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Usuario", (object)asiento.Usuario ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Observacion", (object)asiento.Observacion ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }

            return connection.LastInsertRowId;
        }

        /// <summary>
        /// Agrega una linea de detalle a un asiento existente.
        /// </summary>
        public static void AgregarDetalle(AsientoDetalle detalle, SQLiteConnection connection, SQLiteTransaction transaction)
        {
            string query = @"
                INSERT INTO AsientosDetalle (IdAsiento, IdCuenta, Debe, Haber)
                VALUES (@IdAsiento, @IdCuenta, @Debe, @Haber)";

            using (var cmd = new SQLiteCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@IdAsiento", detalle.IdAsiento);
                cmd.Parameters.AddWithValue("@IdCuenta", detalle.IdCuenta);
                cmd.Parameters.AddWithValue("@Debe", detalle.Debe);
                cmd.Parameters.AddWithValue("@Haber", detalle.Haber);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Guarda un asiento contable completo (cabecera + detalles) en una transaccion.
        /// Valida que la suma de Debe == suma de Haber antes de guardar.
        /// </summary>
        public static bool GuardarAsientoCompleto(Asiento asiento, List<AsientoDetalle> detalles)
        {
            // Validar partida doble
            decimal totalDebe = 0;
            decimal totalHaber = 0;
            foreach (var d in detalles)
            {
                totalDebe += d.Debe;
                totalHaber += d.Haber;
            }

            if (totalDebe != totalHaber)
                throw new Exception($"El asiento no cuadra: Debe={totalDebe}, Haber={totalHaber}");

            using (var connection = DatabaseConnection.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        long idAsiento = CrearAsiento(asiento, connection, transaction);

                        foreach (var detalle in detalles)
                        {
                            detalle.IdAsiento = (int)idAsiento;
                            AgregarDetalle(detalle, connection, transaction);
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Obtiene todas las cuentas contables activas.
        /// </summary>
        public static List<CuentaContable> ObtenerCuentas()
        {
            var cuentas = new List<CuentaContable>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT IdCuenta, Codigo, Nombre, Tipo, Activa FROM CuentasContables WHERE Activa = 1 ORDER BY Codigo";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cuentas.Add(new CuentaContable
                            {
                                IdCuenta = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Activa = reader.GetInt32(4) == 1
                            });
                        }
                    }
                }
            }

            return cuentas;
        }

        /// <summary>
        /// Obtiene una cuenta contable por su codigo.
        /// </summary>
        public static CuentaContable ObtenerCuentaPorCodigo(string codigo)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT IdCuenta, Codigo, Nombre, Tipo, Activa FROM CuentasContables WHERE Codigo = @Codigo";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CuentaContable
                            {
                                IdCuenta = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Activa = reader.GetInt32(4) == 1
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
