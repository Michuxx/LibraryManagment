using LibraryManagmentProject.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentProject.Models
{
    public sealed class PasswordHasher : IPasswordHasher
    {
        private const int SaltSize = 128 / 8; // Size of the salt in bytes
        private const int KeySize = 256 / 8; // Size of the hash in bytes
        private const int Iterations = 10000; // Number of iterations for the PBKDF2 algorithm
        private static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA256; // Hash algorithm to use
        private static char Delimiter = ';'; // Delimiter for the hash string

        public string Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithm, KeySize);

            return string.Join(Delimiter.ToString(), Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public bool Verify(string passwordHash, string inputPassword)
        {
            var elements = passwordHash.Split(Delimiter);
            var salt = Convert.FromBase64String(elements[0]);
            var hash = Convert.FromBase64String(elements[1]);

            var inputHash = Rfc2898DeriveBytes.Pbkdf2(inputPassword, salt, Iterations, HashAlgorithm, KeySize);
        
            return CryptographicOperations.FixedTimeEquals(hash, inputHash);
        }
    }
}
