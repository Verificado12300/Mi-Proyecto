using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaPOS.Models;

namespace SistemaPOS.Data
{
    public class CategoriaRepository
    {
        public static List<Categoria> ObtenerTodas()
        {
            var categorias = new List<Categoria>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT CategoriaID, Nombre, Descripcion, Activo FROM Categorias WHERE Activo = 1 ORDER BY Nombre";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            CategoriaID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Activo = reader.GetInt32(3) == 1
                        });
                    }
                }
            }

            return categorias;
        }

        public static List<CategoriaListItem> Listar(string busqueda = null, bool? soloActivos = null)
        {
            var lista = new List<CategoriaListItem>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT c.CategoriaID, c.Nombre, c.Descripcion, c.Activo,
                           (SELECT COUNT(*) FROM Productos p WHERE p.CategoriaID = c.CategoriaID) as CantidadProductos
                    FROM Categorias c
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(busqueda))
                    query += " AND c.Nombre LIKE @busqueda";

                if (soloActivos.HasValue)
                    query += soloActivos.Value ? " AND c.Activo = 1" : " AND c.Activo = 0";

                query += " ORDER BY c.Nombre";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrWhiteSpace(busqueda))
                        cmd.Parameters.AddWithValue("@busqueda", $"%{busqueda}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CategoriaListItem
                            {
                                CategoriaID = reader.GetInt32(0),
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

        public static Categoria ObtenerPorID(int categoriaID)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT CategoriaID, Nombre, Descripcion, Activo FROM Categorias WHERE CategoriaID = @id";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", categoriaID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Categoria
                            {
                                CategoriaID = reader.GetInt32(0),
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

        public static bool Crear(Categoria categoria)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        INSERT INTO Categorias (Nombre, Descripcion, Activo)
                        VALUES (@nombre, @descripcion, @activo)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion ?? "");
                        cmd.Parameters.AddWithValue("@activo", categoria.Activo ? 1 : 0);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear categoría: {ex.Message}", ex);
            }
        }

        public static bool Actualizar(Categoria categoria)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        UPDATE Categorias SET
                            Nombre = @nombre,
                            Descripcion = @descripcion,
                            Activo = @activo
                        WHERE CategoriaID = @id";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", categoria.CategoriaID);
                        cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion ?? "");
                        cmd.Parameters.AddWithValue("@activo", categoria.Activo ? 1 : 0);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar categoría: {ex.Message}", ex);
            }
        }

        public static bool Eliminar(int categoriaID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    // Verificar si tiene productos asociados
                    string checkQuery = "SELECT COUNT(*) FROM Productos WHERE CategoriaID = @id";
                    using (var checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@id", categoriaID);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Tiene productos, solo desactivar
                            string updateQuery = "UPDATE Categorias SET Activo = 0 WHERE CategoriaID = @id";
                            using (var updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@id", categoriaID);
                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                        else
                        {
                            // Sin productos, eliminar completamente
                            string deleteQuery = "DELETE FROM Categorias WHERE CategoriaID = @id";
                            using (var deleteCmd = new SQLiteCommand(deleteQuery, connection))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", categoriaID);
                                return deleteCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar categoría: {ex.Message}", ex);
            }
        }

        public static bool ExisteNombre(string nombre, int? exceptoCategoriaID = null)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Categorias WHERE LOWER(Nombre) = LOWER(@nombre)";
                    if (exceptoCategoriaID.HasValue)
                        query += " AND CategoriaID != @exceptoID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        if (exceptoCategoriaID.HasValue)
                            cmd.Parameters.AddWithValue("@exceptoID", exceptoCategoriaID.Value);

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
    public class CategoriaListItem
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int CantidadProductos { get; set; }
    }
}
