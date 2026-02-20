using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaPOS.Models;

namespace SistemaPOS.Data
{
    public class ProductoRepository
    {
        public static List<Producto> BuscarProductos(string busqueda = "")
        {
            var productos = new List<Producto>();

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT p.ProductoID, p.Codigo, p.Nombre, p.StockTotal, 
                               c.Nombre as CategoriaNombre, u.Nombre as UnidadNombre,
                               p.CategoriaID, p.UnidadBaseID, p.StockMinimo, p.StockMaximo,
                               p.ProveedorID, p.Activo, p.Descripcion, p.CodigoBarras,
                               p.Imagen, p.FechaCreacion, p.FechaUltimaModificacion
                        FROM Productos p
                        INNER JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                        INNER JOIN UnidadesBase u ON p.UnidadBaseID = u.UnidadID
                        WHERE p.Activo = 1
                        AND (p.Nombre LIKE @Busqueda OR p.Codigo LIKE @Busqueda)
                        ORDER BY p.Nombre
                        LIMIT 50";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(new Producto
                                {
                                    ProductoID = reader.GetInt32(0),
                                    Codigo = reader.GetString(1),
                                    Nombre = reader.GetString(2),
                                    StockTotal = reader.GetDecimal(3),
                                    CategoriaID = reader.GetInt32(6),
                                    UnidadBaseID = reader.GetInt32(7),
                                    StockMinimo = reader.GetDecimal(8),
                                    StockMaximo = reader.GetDecimal(9),
                                    Imagen = reader.IsDBNull(14) ? null : (byte[])reader[14]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar productos: {ex.Message}");
            }

            return productos;
        }

        public static List<dynamic> BuscarProductosConDetalles(string busqueda = "")
        {
            var productos = new List<dynamic>();

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                SELECT
                    p.ProductoID,
                    p.Codigo,
                    p.Nombre,
                    c.Nombre as Categoria,
                    u.Simbolo as UnidadBase,
                    p.StockTotal,
                    p.StockMinimo,
                    GROUP_CONCAT(pr.Nombre, CHAR(10)) as Presentaciones,
                    GROUP_CONCAT('S/ ' || PRINTF('%.2f', pp.PrecioVenta), CHAR(10)) as Precios
                FROM Productos p
                INNER JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                INNER JOIN UnidadesBase u ON p.UnidadBaseID = u.UnidadID
                LEFT JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID AND pp.Activo = 1
                LEFT JOIN Presentaciones pr ON pp.PresentacionID = pr.PresentacionID
                WHERE p.Activo = 1
                AND (p.Nombre LIKE @Busqueda OR p.Codigo LIKE @Busqueda)
                GROUP BY p.ProductoID
                ORDER BY p.Nombre
                LIMIT 50";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(new
                                {
                                    ProductoID = reader.GetInt32(0),
                                    Codigo = reader.GetString(1),
                                    Nombre = reader.GetString(2),
                                    Categoria = reader.GetString(3),
                                    UnidadBase = reader.GetString(4),
                                    StockTotal = reader.GetDecimal(5),
                                    StockMinimo = reader.GetDecimal(6),
                                    Presentaciones = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    Precio = reader.IsDBNull(8) ? "" : reader.GetString(8)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar productos: {ex.Message}");
            }

            return productos;
        }

        public static Producto ObtenerPorID(int productoID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT ProductoID, Codigo, Nombre, CategoriaID, UnidadBaseID,
                               StockTotal, StockMinimo, StockMaximo, ProveedorID, Imagen
                        FROM Productos
                        WHERE ProductoID = @ProductoID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", productoID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Producto
                                {
                                    ProductoID = reader.GetInt32(0),
                                    Codigo = reader.GetString(1),
                                    Nombre = reader.GetString(2),
                                    CategoriaID = reader.GetInt32(3),
                                    UnidadBaseID = reader.GetInt32(4),
                                    StockTotal = reader.GetDecimal(5),
                                    StockMinimo = reader.GetDecimal(6),
                                    StockMaximo = reader.GetDecimal(7),
                                    ProveedorID = reader.IsDBNull(8) ? (int?)null : reader.GetInt32(8),
                                    Imagen = reader.IsDBNull(9) ? null : (byte[])reader["Imagen"]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener producto ID {productoID}: {ex.Message}", ex);
            }

            return null;
        }

        public static List<ProductoPresentacion> ObtenerPresentaciones(int productoID)
        {
            var presentaciones = new List<ProductoPresentacion>();

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT pp.ProductoPresentacionID, pp.PresentacionID, pp.PrecioVenta, 
                               pp.CantidadUnidades, pp.CostoBase, pp.Ganancia,
                               p.Nombre as NombrePresentacion
                        FROM ProductoPresentaciones pp
                        INNER JOIN Presentaciones p ON pp.PresentacionID = p.PresentacionID
                        WHERE pp.ProductoID = @ProductoID AND pp.Activo = 1";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", productoID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                presentaciones.Add(new ProductoPresentacion
                                {
                                    ProductoPresentacionID = reader.GetInt32(0),
                                    PresentacionID = reader.GetInt32(1),
                                    PrecioVenta = reader.GetDecimal(2),
                                    CantidadUnidades = reader.GetDecimal(3),
                                    CostoBase = reader.GetDecimal(4),
                                    Ganancia = reader.IsDBNull(5) ? (decimal?)null : reader.GetDecimal(5),
                                    ProductoID = productoID
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al obtener presentaciones del producto {productoID}: {ex.Message}");
            }

            return presentaciones;
        }

        public static bool Crear(Producto producto, List<ProductoPresentacion> presentaciones)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insertar producto
                        string queryProducto = @"
                            INSERT INTO Productos 
                            (Codigo, Nombre, CategoriaID, UnidadBaseID, StockTotal, StockMinimo, 
                             StockMaximo, ProveedorID, Imagen, Activo)
                            VALUES 
                            (@Codigo, @Nombre, @CategoriaID, @UnidadBaseID, @StockTotal, @StockMinimo,
                             @StockMaximo, @ProveedorID, @Imagen, 1);
                            SELECT last_insert_rowid();";

                        int productoID;
                        using (var cmd = new SQLiteCommand(queryProducto, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                            cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                            cmd.Parameters.AddWithValue("@UnidadBaseID", producto.UnidadBaseID);
                            cmd.Parameters.AddWithValue("@StockTotal", producto.StockTotal);
                            cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);
                            cmd.Parameters.AddWithValue("@StockMaximo", producto.StockMaximo);
                            cmd.Parameters.AddWithValue("@ProveedorID",
                                producto.ProveedorID.HasValue ? (object)producto.ProveedorID.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@Imagen",
                                producto.Imagen != null ? (object)producto.Imagen : DBNull.Value);

                            productoID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Insertar presentaciones
                        string queryPresentacion = @"
                            INSERT INTO ProductoPresentaciones 
                            (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
                            VALUES 
                            (@ProductoID, @PresentacionID, @CantidadUnidades, @CostoBase, @PrecioVenta, @Ganancia, 1)";

                        foreach (var presentacion in presentaciones)
                        {
                            using (var cmd = new SQLiteCommand(queryPresentacion, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                                cmd.Parameters.AddWithValue("@PresentacionID", presentacion.PresentacionID);
                                cmd.Parameters.AddWithValue("@CantidadUnidades", presentacion.CantidadUnidades);
                                cmd.Parameters.AddWithValue("@CostoBase", presentacion.CostoBase);
                                cmd.Parameters.AddWithValue("@PrecioVenta", presentacion.PrecioVenta);
                                cmd.Parameters.AddWithValue("@Ganancia", presentacion.Ganancia ?? 0);
                                cmd.ExecuteNonQuery();
                            }
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

        public static string GenerarCodigoProducto()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Productos";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    long count = (long)cmd.ExecuteScalar();
                    return "PROD" + (count + 1).ToString("D4");
                }
            }
        }

        public static bool Actualizar(Producto producto, List<ProductoPresentacion> presentaciones)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Actualizar producto
                        string queryProducto = @"
                    UPDATE Productos SET
                        Codigo = @Codigo,
                        Nombre = @Nombre,
                        CategoriaID = @CategoriaID,
                        UnidadBaseID = @UnidadBaseID,
                        StockTotal = @StockTotal,
                        StockMinimo = @StockMinimo,
                        StockMaximo = @StockMaximo,
                        ProveedorID = @ProveedorID,
                        Imagen = @Imagen,
                        FechaUltimaModificacion = @Fecha
                    WHERE ProductoID = @ProductoID";

                        using (var cmd = new SQLiteCommand(queryProducto, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                            cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                            cmd.Parameters.AddWithValue("@UnidadBaseID", producto.UnidadBaseID);
                            cmd.Parameters.AddWithValue("@StockTotal", producto.StockTotal);
                            cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);
                            cmd.Parameters.AddWithValue("@StockMaximo", producto.StockMaximo);
                            cmd.Parameters.AddWithValue("@ProveedorID",
                                producto.ProveedorID.HasValue ? (object)producto.ProveedorID.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@Imagen",
                                producto.Imagen != null ? (object)producto.Imagen : DBNull.Value);
                            cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                            cmd.ExecuteNonQuery();
                        }

                        // Desactivar todas las presentaciones existentes (soft delete para no romper FK de VentaDetalles)
                        string deactivateQuery = "UPDATE ProductoPresentaciones SET Activo = 0 WHERE ProductoID = @ProductoID";
                        using (var cmd = new SQLiteCommand(deactivateQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                            cmd.ExecuteNonQuery();
                        }

                        // Para cada presentacion: actualizar si existe o insertar nueva
                        string updatePresQuery = @"
                    UPDATE ProductoPresentaciones SET
                        CantidadUnidades = @CantidadUnidades,
                        CostoBase = @CostoBase,
                        PrecioVenta = @PrecioVenta,
                        Ganancia = @Ganancia,
                        Activo = 1
                    WHERE ProductoID = @ProductoID AND PresentacionID = @PresentacionID";

                        string insertPresQuery = @"
                    INSERT INTO ProductoPresentaciones
                    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
                    VALUES
                    (@ProductoID, @PresentacionID, @CantidadUnidades, @CostoBase, @PrecioVenta, @Ganancia, 1)";

                        foreach (var presentacion in presentaciones)
                        {
                            // Intentar actualizar primero
                            int rowsAffected;
                            using (var cmd = new SQLiteCommand(updatePresQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                                cmd.Parameters.AddWithValue("@PresentacionID", presentacion.PresentacionID);
                                cmd.Parameters.AddWithValue("@CantidadUnidades", presentacion.CantidadUnidades);
                                cmd.Parameters.AddWithValue("@CostoBase", presentacion.CostoBase);
                                cmd.Parameters.AddWithValue("@PrecioVenta", presentacion.PrecioVenta);
                                cmd.Parameters.AddWithValue("@Ganancia", presentacion.Ganancia ?? 0);
                                rowsAffected = cmd.ExecuteNonQuery();
                            }

                            // Si no existia, insertar nueva
                            if (rowsAffected == 0)
                            {
                                using (var cmd = new SQLiteCommand(insertPresQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                                    cmd.Parameters.AddWithValue("@PresentacionID", presentacion.PresentacionID);
                                    cmd.Parameters.AddWithValue("@CantidadUnidades", presentacion.CantidadUnidades);
                                    cmd.Parameters.AddWithValue("@CostoBase", presentacion.CostoBase);
                                    cmd.Parameters.AddWithValue("@PrecioVenta", presentacion.PrecioVenta);
                                    cmd.Parameters.AddWithValue("@Ganancia", presentacion.Ganancia ?? 0);
                                    cmd.ExecuteNonQuery();
                                }
                            }
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

        public static bool Eliminar(int productoID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    // Verificar si tiene ventas o compras asociadas
                    string checkVentas = "SELECT COUNT(*) FROM VentaDetalles WHERE ProductoID = @ProductoID";
                    using (var cmd = new SQLiteCommand(checkVentas, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", productoID);
                        long ventasCount = (long)cmd.ExecuteScalar();

                        if (ventasCount > 0)
                        {
                            // Tiene ventas, solo desactivar
                            string updateQuery = "UPDATE Productos SET Activo = 0 WHERE ProductoID = @ProductoID";
                            using (var updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@ProductoID", productoID);
                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }

                    // Verificar compras
                    string checkCompras = "SELECT COUNT(*) FROM CompraDetalles WHERE ProductoID = @ProductoID";
                    using (var cmd = new SQLiteCommand(checkCompras, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", productoID);
                        long comprasCount = (long)cmd.ExecuteScalar();

                        if (comprasCount > 0)
                        {
                            // Tiene compras, solo desactivar
                            string updateQuery = "UPDATE Productos SET Activo = 0 WHERE ProductoID = @ProductoID";
                            using (var updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@ProductoID", productoID);
                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }

                    // Sin ventas ni compras, eliminar completamente
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Eliminar presentaciones primero
                            string deletePres = "DELETE FROM ProductoPresentaciones WHERE ProductoID = @ProductoID";
                            using (var cmd = new SQLiteCommand(deletePres, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                                cmd.ExecuteNonQuery();
                            }

                            // Eliminar ajustes
                            string deleteAjustes = "DELETE FROM Ajustes WHERE ProductoID = @ProductoID";
                            using (var cmd = new SQLiteCommand(deleteAjustes, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                                cmd.ExecuteNonQuery();
                            }

                            // Eliminar producto
                            string deleteProducto = "DELETE FROM Productos WHERE ProductoID = @ProductoID";
                            using (var cmd = new SQLiteCommand(deleteProducto, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                                cmd.ExecuteNonQuery();
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
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar producto: {ex.Message}", ex);
            }
        }
    }
}