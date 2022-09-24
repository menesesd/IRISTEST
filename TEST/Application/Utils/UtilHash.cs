using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Application.Utils
{
    static class UtilHash
    {
       public static string getHastFromString(string data)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(data);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
        
            string encoded = BitConverter.ToString(hash)              
               .Replace("-", string.Empty)               
               .ToLower();

            return encoded;
        }
    }
}
