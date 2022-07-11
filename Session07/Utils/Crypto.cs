using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.Utils
{
    public static class Crypto
    {
        public static string ToSHA512(string plain)
        {
            var SHA512 = System.Security.Cryptography.SHA512.Create();
            var bytes = Encoding.UTF8.GetBytes(plain);
            var hash = SHA512.ComputeHash(bytes);
            //byte to hex string
            return String.Concat(hash.Select(b => b.ToString("X2")).ToArray());
        }
    }
}
