using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaPOS.Utils
{
    public static class PasswordHelper
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int DefaultIterations = 120000;
        private const string Pbkdf2Prefix = "PBKDF2";

        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("La contraseña no puede estar vacía");

            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] key;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, DefaultIterations, HashAlgorithmName.SHA256))
            {
                key = pbkdf2.GetBytes(KeySize);
            }

            return $"{Pbkdf2Prefix}${DefaultIterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(key)}";
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(storedHash))
                return false;

            if (storedHash.StartsWith(Pbkdf2Prefix + "$", StringComparison.Ordinal))
                return VerifyPbkdf2(password, storedHash);

            // Compatibilidad con hashes heredados SHA256 (sin salt)
            string legacyHash = ComputeLegacySha256(password);
            return string.Equals(legacyHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }

        public static bool NeedsRehash(string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash))
                return true;

            if (!storedHash.StartsWith(Pbkdf2Prefix + "$", StringComparison.Ordinal))
                return true;

            string[] parts = storedHash.Split('$');
            if (parts.Length != 4)
                return true;

            if (!int.TryParse(parts[1], out int iterations))
                return true;

            return iterations < DefaultIterations;
        }

        private static bool VerifyPbkdf2(string password, string storedHash)
        {
            string[] parts = storedHash.Split('$');
            if (parts.Length != 4)
                return false;

            if (!int.TryParse(parts[1], out int iterations) || iterations <= 0)
                return false;

            byte[] salt;
            byte[] expectedKey;
            try
            {
                salt = Convert.FromBase64String(parts[2]);
                expectedKey = Convert.FromBase64String(parts[3]);
            }
            catch
            {
                return false;
            }

            byte[] actualKey;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                actualKey = pbkdf2.GetBytes(expectedKey.Length);
            }

            return FixedTimeEquals(actualKey, expectedKey);
        }

        private static string ComputeLegacySha256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
                diff |= a[i] ^ b[i];

            return diff == 0;
        }
    }
}
