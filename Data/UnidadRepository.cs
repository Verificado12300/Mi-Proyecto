using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaPOS.Models;

namespace SistemaPOS.Data
{
    public class UnidadRepository
    {
        public static List<UnidadBase> ObtenerTodas()
        {
            var unidades = new List<UnidadBase>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT UnidadID, Nombre, Simbolo, Tipo, Activo FROM UnidadesBase WHERE Activo = 1 ORDER BY Nombre";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        unidades.Add(new UnidadBase
                        {
                            UnidadID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Simbolo = reader.GetString(2),
                            Tipo = reader.GetString(3),
                            Activo = reader.GetInt32(4) == 1
                        });
                    }
                }
            }

            return unidades;
        }

        public static List<UnidadListItem> Listar(string busqueda = null, bool? soloActivos = null)
        {
            var lista = new List<UnidadListItem>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT u.UnidadID, u.Nombre, u.Simbolo, u.Tipo, u.Activo,
                           (SELECT COUNT(*) FROM Productos p WHERE p.UnidadBaseID = u.UnidadID) as CantidadProductos
                    FROM UnidadesBase u
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(busqueda))
                    query += " AND (u.Nombre LIKE @busqueda OR u.Simbolo LIKE @busqueda)";

                if (soloActivos.HasValue)
                    query += soloActivos.Value ? " AND u.Activo = 1" : " AND u.Activo = 0";

                query += " ORDER BY u.Nombre";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrWhiteSpace(busqueda))
                        cmd.Parameters.AddWithValue("@busqueda", $"%{busqueda}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new UnidadListItem
                            {
                                UnidadID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Simbolo = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Activo = reader.GetInt32(4) == 1,
                                CantidadProductos = reader.GetInt32(5)
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public static UnidadBase ObtenerPorID(int unidadID)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT UnidadID, Nombre, Simbolo, Tipo, Activo FROM UnidadesBase WHERE UnidadID = @id";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", unidadID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UnidadBase
                            {
                                UnidadID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Simbolo = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Activo = reader.GetInt32(4) == 1
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static bool Crear(UnidadBase unidad)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        INSERT INTO UnidadesBase (Nombre, Simbolo, Tipo, Activo)
                        VALUES (@nombre, @simbolo, @tipo, @activo)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", unidad.Nombre);
                        cmd.Parameters.AddWithValue("@simbolo", unidad.Simbolo);
                        cmd.Parameters.AddWithValue("@tipo", unidad.Tipo);
                        cmd.Parameters.AddWithValue("@activo", unidad.Activo ? 1 : 0);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear unidad: {ex.Message}", ex);
            }
        }

        public static bool Actualizar(UnidadBase unidad)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        UPDATE UnidadesBase SET
                            Nombre = @nombre,
                            Simbolo = @simbolo,
                            Tipo = @tipo,
                            Activo = @activo
                        WHERE UnidadID = @id";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", unidad.UnidadID);
                        cmd.Parameters.AddWithValue("@nombre", unidad.Nombre);
                        cmd.Parameters.AddWithValue("@simbolo", unidad.Simbolo);
                        cmd.Parameters.AddWithValue("@tipo", unidad.Tipo);
                        cmd.Parameters.AddWithValue("@activo", unidad.Activo ? 1 : 0);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar unidad: {ex.Message}", ex);
            }
        }

        public static bool Eliminar(int unidadID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    // Verificar si tiene productos asociados
                    string checkQuery = "SELECT COUNT(*) FROM Productos WHERE UnidadBaseID = @id";
                    using (var checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@id", unidadID);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Tiene productos, solo desactivar
                            string updateQuery = "UPDATE UnidadesBase SET Activo = 0 WHERE UnidadID = @id";
                            using (var updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@id", unidadID);
                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                        else
                        {
                            // Sin productos, eliminar completamente
                            string deleteQuery = "DELETE FROM UnidadesBase WHERE UnidadID = @id";
                            using (var deleteCmd = new SQLiteCommand(deleteQuery, connection))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", unidadID);
                                return deleteCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar unidad: {ex.Message}", ex);
            }
        }

        public static string ObtenerSimboloPorID(int unidadID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT Simbolo FROM UnidadesBase WHERE UnidadID = @id";
                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", unidadID);
                        return cmd.ExecuteScalar()?.ToString() ?? "";
                    }
                }
            }
            catch
            {
                return "";
            }
        }

        public static bool ExisteNombre(string nombre, int? exceptoUnidadID = null)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM UnidadesBase WHERE LOWER(Nombre) = LOWER(@nombre)";
                    if (exceptoUnidadID.HasValue)
                        query += " AND UnidadID != @exceptoID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        if (exceptoUnidadID.HasValue)
                            cmd.Parameters.AddWithValue("@exceptoID", exceptoUnidadID.Value);

                        long count = (long)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static string[] ObtenerTipos()
        {
            return new[] { "PESO", "VOLUMEN", "UNIDAD" };
        }
    }

    // Clase auxiliar para la lista
    public class UnidadListItem
    {
        public int UnidadID { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public int CantidadProductos { get; set; }
    }
}
