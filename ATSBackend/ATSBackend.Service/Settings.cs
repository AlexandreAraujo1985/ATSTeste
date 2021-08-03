using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ATSBackend
{
    /// <summary>
    /// Chave secreta
    /// </summary>
    public static class Settings
    {
        public static string SecretKey() 
        {
            using (var md5 = MD5.Create())
            {
                var hash = new StringBuilder();

                byte[] inputBytes = Encoding.ASCII.GetBytes($"TesteTotvs-{DateTime.Now.ToString("dd/MM/yyyy")}");
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                for (int i = 0; i < hashBytes.Length; i++)
                    hash.Append(hashBytes[i].ToString("X2"));

                return hash.ToString();
            }
        }
    }
}
