using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace MundoNaruro
{
    public class Criptografia
    {

        public string criptografa(string texto)
        {
            SHA1 sha1 = SHA1.Create();
            MD5 md5 = MD5.Create();
           
            byte[] data = sha1.ComputeHash(Encoding.Default.GetBytes(texto));
            StringBuilder cript = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                cript.Append(data[i].ToString("x2"));
            }
            return cript.ToString();
        }

        public bool verificarriptografia(string texto, string textoCriptografado)
        { 
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;

            if (0 == comparar.Compare(criptografa(texto), textoCriptografado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}