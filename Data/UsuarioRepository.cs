using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaPOS.Models;
using SistemaPOS.Utils;

namespace SistemaPOS.Data
{
    public class UsuarioRepository
    {
        static UsuarioRepository()
        {
            EnsurePermissionColumnsExist();
        }

        private static void EnsurePermissionColumnsExist()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    // Verificar si existen las columnas de permisos
                    var columnsToAdd = new Dictionary<string, string>
                    {
                        { "PermisoVentas", "INTEGER DEFAULT 1" },
                        { "PermisoClientes", "INTEGER DEFAULT 1" },
                        { "PermisoCompras", "INTEGER DEFAULT 0" },
                        { "PermisoInventario", "INTEGER DEFAULT 0" },
                        { "PermisoReportes", "INTEGER DEFAULT 0" },
                        { "PermisoConfiguracion", "INTEGER DEFAULT 0" },
                        { "PermisoProveedores", "INTEGER DEFAULT 0" },
                        { "PermisoFinanzas", "INTEGER DEFAULT 0" },
                        { "PermisoDescuentos", "INTEGER DEFAULT 0" },
                        { "PermisoAnularVentas", "INTEGER DEFAULT 0" },
                        { "PermisoEliminarRegistros", "INTEGER DEFAULT 0" },
                        { "PermisoVerCostos", "INTEGER DEFAULT 0" },
                        { "PermisoModificarPrecios", "INTEGER DEFAULT 0" },
                        { "PermisoFueraHorario", "INTEGER DEFAULT 0" }
                    };

                    foreach (var col in columnsToAdd)
                    {
                        try
                        {
                            string alterQuery = $"ALTER TABLE Usuarios ADD COLUMN {col.Key} {col.Value}";
                            using (var cmd = new SQLiteCommand(alterQuery, connection))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch
                        {
                            // La columna ya existe, ignorar
                        }
                    }
                }
            }
            catch
            {
                // Si falla, continuamos sin las columnas extra
            }
        }

        public static List<UsuarioListItem> Listar(string busqueda = null)
        {
            var lista = new List<UsuarioListItem>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT u.UsuarioID, u.NombreCompleto, u.NombreUsuario,
                           r.Nombre as NombreRol, u.Activo
                    FROM Usuarios u
                    LEFT JOIN Roles r ON u.RolID = r.RolID
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    query += @" AND (u.NombreCompleto LIKE @busqueda
                               OR u.NombreUsuario LIKE @busqueda
                               OR r.Nombre LIKE @busqueda)";
                }

                query += " ORDER BY u.NombreCompleto";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrWhiteSpace(busqueda))
                        cmd.Parameters.AddWithValue("@busqueda", $"%{busqueda}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new UsuarioListItem
                            {
                                UsuarioID = reader.GetInt32(0),
                                NombreCompleto = reader.GetString(1),
                                NombreUsuario = reader.GetString(2),
                                NombreRol = reader.IsDBNull(3) ? "Sin Rol" : reader.GetString(3),
                                Activo = reader.GetInt32(4) == 1
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public static Usuario ObtenerPorID(int usuarioID)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT UsuarioID, NombreUsuario, Contraseña, NombreCompleto, DNI,
                           Email, Telefono, RolID, FechaCreacion, UltimoAcceso, Activo,
                           COALESCE(PermisoVentas, 1), COALESCE(PermisoClientes, 1),
                           COALESCE(PermisoCompras, 0), COALESCE(PermisoInventario, 0),
                           COALESCE(PermisoReportes, 0), COALESCE(PermisoConfiguracion, 0),
                           COALESCE(PermisoProveedores, 0), COALESCE(PermisoFinanzas, 0),
                           COALESCE(PermisoDescuentos, 0), COALESCE(PermisoAnularVentas, 0),
                           COALESCE(PermisoEliminarRegistros, 0), COALESCE(PermisoVerCostos, 0),
                           COALESCE(PermisoModificarPrecios, 0), COALESCE(PermisoFueraHorario, 0)
                    FROM Usuarios
                    WHERE UsuarioID = @id";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", usuarioID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapearUsuarioCompleto(reader);
                        }
                    }
                }
            }

            return null;
        }

        public static bool Crear(Usuario usuario)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        INSERT INTO Usuarios
                        (NombreUsuario, Contraseña, NombreCompleto, DNI, Email, Telefono, RolID, Activo,
                         PermisoVentas, PermisoClientes, PermisoCompras, PermisoInventario,
                         PermisoReportes, PermisoConfiguracion, PermisoProveedores, PermisoFinanzas,
                         PermisoDescuentos, PermisoAnularVentas, PermisoEliminarRegistros,
                         PermisoVerCostos, PermisoModificarPrecios, PermisoFueraHorario)
                        VALUES
                        (@NombreUsuario, @Contraseña, @NombreCompleto, @DNI, @Email, @Telefono, @RolID, @Activo,
                         @PermisoVentas, @PermisoClientes, @PermisoCompras, @PermisoInventario,
                         @PermisoReportes, @PermisoConfiguracion, @PermisoProveedores, @PermisoFinanzas,
                         @PermisoDescuentos, @PermisoAnularVentas, @PermisoEliminarRegistros,
                         @PermisoVerCostos, @PermisoModificarPrecios, @PermisoFueraHorario)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        AgregarParametrosUsuario(cmd, usuario);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear usuario: {ex.Message}", ex);
            }
        }

        public static bool Actualizar(Usuario usuario)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        UPDATE Usuarios SET
                            NombreUsuario = @NombreUsuario,
                            NombreCompleto = @NombreCompleto,
                            DNI = @DNI,
                            Email = @Email,
                            Telefono = @Telefono,
                            RolID = @RolID,
                            Activo = @Activo,
                            PermisoVentas = @PermisoVentas,
                            PermisoClientes = @PermisoClientes,
                            PermisoCompras = @PermisoCompras,
                            PermisoInventario = @PermisoInventario,
                            PermisoReportes = @PermisoReportes,
                            PermisoConfiguracion = @PermisoConfiguracion,
                            PermisoProveedores = @PermisoProveedores,
                            PermisoFinanzas = @PermisoFinanzas,
                            PermisoDescuentos = @PermisoDescuentos,
                            PermisoAnularVentas = @PermisoAnularVentas,
                            PermisoEliminarRegistros = @PermisoEliminarRegistros,
                            PermisoVerCostos = @PermisoVerCostos,
                            PermisoModificarPrecios = @PermisoModificarPrecios,
                            PermisoFueraHorario = @PermisoFueraHorario
                        WHERE UsuarioID = @UsuarioID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                        AgregarParametrosUsuario(cmd, usuario);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar usuario: {ex.Message}", ex);
            }
        }

        public static bool ActualizarContraseña(int usuarioID, string nuevaContraseñaHash)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Usuarios SET Contraseña = @contraseña WHERE UsuarioID = @id";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", usuarioID);
                        cmd.Parameters.AddWithValue("@contraseña", nuevaContraseñaHash);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar contraseña: {ex.Message}", ex);
            }
        }

        public static bool Eliminar(int usuarioID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    // Verificar si tiene operaciones asociadas
                    string checkQuery = @"
                        SELECT
                            (SELECT COUNT(*) FROM Ventas WHERE UsuarioID = @id) +
                            (SELECT COUNT(*) FROM Cajas WHERE UsuarioID = @id)";

                    using (var checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@id", usuarioID);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Tiene operaciones, solo desactivar
                            string updateQuery = "UPDATE Usuarios SET Activo = 0 WHERE UsuarioID = @id";
                            using (var updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@id", usuarioID);
                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                        else
                        {
                            // Sin operaciones, eliminar completamente
                            string deleteQuery = "DELETE FROM Usuarios WHERE UsuarioID = @id";
                            using (var deleteCmd = new SQLiteCommand(deleteQuery, connection))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", usuarioID);
                                return deleteCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar usuario: {ex.Message}", ex);
            }
        }

        public static List<Rol> ObtenerRoles()
        {
            var roles = new List<Rol>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT RolID, Nombre, Descripcion FROM Roles WHERE Activo = 1 ORDER BY RolID";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(new Rol
                        {
                            RolID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2)
                        });
                    }
                }
            }

            return roles;
        }

        public static string ObtenerNombreCompletoPorID(int usuarioID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT NombreCompleto FROM Usuarios WHERE UsuarioID = @id";
                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", usuarioID);
                        return cmd.ExecuteScalar()?.ToString() ?? "Desconocido";
                    }
                }
            }
            catch
            {
                return "Desconocido";
            }
        }

        public static bool ExisteNombreUsuario(string nombreUsuario, int? exceptoUsuarioID = null)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    if (exceptoUsuarioID.HasValue)
                        query += " AND UsuarioID != @exceptoID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        if (exceptoUsuarioID.HasValue)
                            cmd.Parameters.AddWithValue("@exceptoID", exceptoUsuarioID.Value);

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

        public static bool ExisteDNI(string dni, int? exceptoUsuarioID = null)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE DNI = @DNI";
                    if (exceptoUsuarioID.HasValue)
                        query += " AND UsuarioID != @exceptoID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DNI", dni);
                        if (exceptoUsuarioID.HasValue)
                            cmd.Parameters.AddWithValue("@exceptoID", exceptoUsuarioID.Value);

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

        public static Usuario ValidarLogin(string nombreUsuario, string contrasenaPlano)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT UsuarioID, NombreUsuario, Contraseña, NombreCompleto, DNI,
                               Email, Telefono, RolID, FechaCreacion, UltimoAcceso, Activo,
                               COALESCE(PermisoVentas, 1), COALESCE(PermisoClientes, 1),
                               COALESCE(PermisoCompras, 0), COALESCE(PermisoInventario, 0),
                               COALESCE(PermisoReportes, 0), COALESCE(PermisoConfiguracion, 0),
                               COALESCE(PermisoProveedores, 0), COALESCE(PermisoFinanzas, 0),
                               COALESCE(PermisoDescuentos, 0), COALESCE(PermisoAnularVentas, 0),
                               COALESCE(PermisoEliminarRegistros, 0), COALESCE(PermisoVerCostos, 0),
                               COALESCE(PermisoModificarPrecios, 0), COALESCE(PermisoFueraHorario, 0)
                        FROM Usuarios
                        WHERE NombreUsuario = @NombreUsuario AND Activo = 1";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashGuardado = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                if (!PasswordHelper.VerifyPassword(contrasenaPlano, hashGuardado))
                                    return null;

                                var usuario = MapearUsuarioCompleto(reader);

                                if (PasswordHelper.NeedsRehash(hashGuardado))
                                {
                                    string nuevoHash = PasswordHelper.HashPassword(contrasenaPlano);
                                    using (var updateCmd = new SQLiteCommand("UPDATE Usuarios SET Contraseña = @hash WHERE UsuarioID = @id", connection))
                                    {
                                        updateCmd.Parameters.AddWithValue("@hash", nuevoHash);
                                        updateCmd.Parameters.AddWithValue("@id", usuario.UsuarioID);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                    usuario.Contraseña = nuevoHash;
                                }

                                return usuario;
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al validar login: {ex.Message}", ex);
            }
        }

        public static void ActualizarUltimoAcceso(int usuarioID)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Usuarios SET UltimoAcceso = @UltimoAcceso WHERE UsuarioID = @UsuarioID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UltimoAcceso", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // No crítico
            }
        }

        private static void AgregarParametrosUsuario(SQLiteCommand cmd, Usuario usuario)
        {
            cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña ?? "");
            cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
            cmd.Parameters.AddWithValue("@DNI", usuario.DNI ?? "");
            cmd.Parameters.AddWithValue("@Email", usuario.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@RolID", usuario.RolID);
            cmd.Parameters.AddWithValue("@Activo", usuario.Activo ? 1 : 0);

            // Permisos de módulos
            cmd.Parameters.AddWithValue("@PermisoVentas", usuario.PermisoVentas ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoClientes", usuario.PermisoClientes ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoCompras", usuario.PermisoCompras ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoInventario", usuario.PermisoInventario ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoReportes", usuario.PermisoReportes ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoConfiguracion", usuario.PermisoConfiguracion ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoProveedores", usuario.PermisoProveedores ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoFinanzas", usuario.PermisoFinanzas ? 1 : 0);

            // Permisos de acciones especiales
            cmd.Parameters.AddWithValue("@PermisoDescuentos", usuario.PermisoDescuentos ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoAnularVentas", usuario.PermisoAnularVentas ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoEliminarRegistros", usuario.PermisoEliminarRegistros ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoVerCostos", usuario.PermisoVerCostos ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoModificarPrecios", usuario.PermisoModificarPrecios ? 1 : 0);
            cmd.Parameters.AddWithValue("@PermisoFueraHorario", usuario.PermisoFueraHorario ? 1 : 0);
        }

        private static Usuario MapearUsuarioCompleto(SQLiteDataReader reader)
        {
            return new Usuario
            {
                UsuarioID = reader.GetInt32(0),
                NombreUsuario = reader.GetString(1),
                Contraseña = reader.GetString(2),
                NombreCompleto = reader.GetString(3),
                DNI = reader.GetString(4),
                Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                Telefono = reader.IsDBNull(6) ? null : reader.GetString(6),
                RolID = reader.GetInt32(7),
                FechaCreacion = DateTime.Parse(reader.GetString(8)),
                UltimoAcceso = reader.IsDBNull(9) ? (DateTime?)null : DateTime.Parse(reader.GetString(9)),
                Activo = reader.GetInt32(10) == 1,
                // Permisos de módulos
                PermisoVentas = reader.GetInt32(11) == 1,
                PermisoClientes = reader.GetInt32(12) == 1,
                PermisoCompras = reader.GetInt32(13) == 1,
                PermisoInventario = reader.GetInt32(14) == 1,
                PermisoReportes = reader.GetInt32(15) == 1,
                PermisoConfiguracion = reader.GetInt32(16) == 1,
                PermisoProveedores = reader.GetInt32(17) == 1,
                PermisoFinanzas = reader.GetInt32(18) == 1,
                // Permisos de acciones especiales
                PermisoDescuentos = reader.GetInt32(19) == 1,
                PermisoAnularVentas = reader.GetInt32(20) == 1,
                PermisoEliminarRegistros = reader.GetInt32(21) == 1,
                PermisoVerCostos = reader.GetInt32(22) == 1,
                PermisoModificarPrecios = reader.GetInt32(23) == 1,
                PermisoFueraHorario = reader.GetInt32(24) == 1
            };
        }
    }

    // Clase auxiliar para la lista
    public class UsuarioListItem
    {
        public int UsuarioID { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreRol { get; set; }
        public bool Activo { get; set; }
    }

}
