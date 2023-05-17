using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Aisys.Utilities
{
    public class Encryptor
    {    
        public byte[] Salt = new byte[16];
        
        public byte[] HashPassword(string password, byte[] salt)
        {
            var sha256 = new SHA256Managed();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordAndSaltBytes = new byte[passwordBytes.Length + salt.Length];

            Buffer.BlockCopy(passwordBytes, 0, passwordAndSaltBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, passwordAndSaltBytes, passwordBytes.Length, salt.Length);

            return sha256.ComputeHash(passwordAndSaltBytes);
        }
        
        public string ToBase(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }
    }
}
