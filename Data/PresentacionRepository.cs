using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaPOS.Models;

namespace SistemaPOS.Data
{
    public class PresentacionRepository
    {
        public static List<Presentacion> ObtenerTodas()
        {
            var presentaciones = new List<Presentacion>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT PresentacionID, Nombre, Descripcion, Activo FROM Presentaciones WHERE Activo = 1 ORDER BY Nombre";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        presentaciones.Add(new Presentacion
                        {
                            PresentacionID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Activo = reader.GetInt32(3) == 1
                        });
                    }
                }
            }

            return presentaciones;
        }

        public static List<PresentacionListItem> Listar(string busqueda = null, bool? soloActivos = null)
        {
            var lista = new List<PresentacionListItem>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT p.PresentacionID, p.Nombre, p.Descripcion, p.Activo,
                           (SELECT COUNT(DISTINCT pp.ProductoID) FROM ProductoPresentaciones pp WHERE pp.PresentacionID = p.PresentacionID) as CantidadProductos
                    FROM Presentaciones p
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(busqueda))
                    query += " AND (p.Nombre LIKE @busqueda OR p.Descripcion LIKE @busqueda)";

                if (soloActivos.HasValue)
                    query += soloActivos.Value ? " AND p.Activo = 1" : " AND p.Activo = 0";

                query += " ORDER BY p.Nombre";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrWhiteSpace(busqueda))
                        cmd.Parameters.AddWithValue("@busqueda", $"%{busqueda}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new PresentacionListItem
                            {
                                PresentacionID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Activo = reader.GetInt32(3) == 1,
                                CantidadProductos = reader.GetInt32(4)
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public static Presentacion ObtenerPorID(int presentacionID)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT PresentacionID, Nombre, Descripcion, Activo FROM Presentaciones WHERE PresentacionID = @id";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", presentacionID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Presentacion
                            {
                                PresentacionID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Activo = reader.GetInt32(3) == 1
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static bool Crear(Presentacion presentacion)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        INSERT INTO Presentaciones (Nombre, Descripcion, Activo)
                        VALUES (@nombre, @descripcion, @activo)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", presentacion.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", presentacion.Descripcion ?? "");
                        cmd.Parameters.AddWithValue("@activo", presentacion.Activo ? 1 : 0);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear presentación: {ex.Message}", ex);
            }
        }

        public static bool Actualizar(Presentacion presentacion)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        UPDATE Presentaciones SET
                            Nombre = @nombre,
                            Descripcion = @descripcion,
                            Activo = @activo
                        WHERE PresentacionID = @id";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", presentacion.PresentacionID);
                        cmd.Parameters.AddWithValue("@nombre", presentacion.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", presentacion.Descripcion ?? "");
                        cmd.Parameters.AddWithValue("@activo", presentacion.Activo ? 1 : 0);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar presentación: {ex.Message}", ex);
            }
        }

        public static bool Eliminar(int presentacionID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    // Verificar si tiene productos asociados
                    string checkQuery = "SELECT COUNT(*) FROM ProductoPresentaciones WHERE PresentacionID = @id";
                    using (var checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@id", presentacionID);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Tiene productos, solo desactivar
                            string updateQuery = "UPDATE Presentaciones SET Activo = 0 WHERE PresentacionID = @id";
                            using (var updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@id", presentacionID);
                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                        else
                        {
                            // Sin productos, eliminar completamente
                            string deleteQuery = "DELETE FROM Presentaciones WHERE PresentacionID = @id";
                            using (var deleteCmd = new SQLiteCommand(deleteQuery, connection))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", presentacionID);
                                return deleteCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar presentación: {ex.Message}", ex);
            }
        }

        public static string ObtenerNombrePorID(int presentacionID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT Nombre FROM Presentaciones WHERE PresentacionID = @id";
                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", presentacionID);
                        return cmd.ExecuteScalar()?.ToString() ?? "Presentación";
                    }
                }
            }
            catch
            {
                return "Presentación";
            }
        }

        public static bool ExisteNombre(string nombre, int? exceptoPresentacionID = null)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Presentaciones WHERE LOWER(Nombre) = LOWER(@nombre)";
                    if (exceptoPresentacionID.HasValue)
                        query += " AND PresentacionID != @exceptoID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        if (exceptoPresentacionID.HasValue)
                            cmd.Parameters.AddWithValue("@exceptoID", exceptoPresentacionID.Value);

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
    }

    // Clase auxiliar para la lista
    public class PresentacionListItem
    {
        public int PresentacionID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int CantidadProductos { get; set; }
    }
}
