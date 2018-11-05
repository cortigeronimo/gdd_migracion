using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PalcoNet.Config
{
    public class Hashing
    {
        public static byte[] GetSHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            byte[] InputBytes = Encoding.UTF8.GetBytes(input);
            byte[] HashedBytes = provider.ComputeHash(InputBytes);
            return HashedBytes;
        }

        //Compara passwords
        public static Boolean EqualPasswords(byte[] loginPassword, byte[] dbPassword)
        {
            Boolean equal = false;

            if (loginPassword.Length == dbPassword.Length)
            {
                int i = 0;
                while ((i < loginPassword.Length) && (loginPassword[i] == dbPassword[i]))
                {
                    i++;
                }
                if (i == loginPassword.Length)
                {
                    equal = true;
                }
            }
            return equal;
        }
    }
}
