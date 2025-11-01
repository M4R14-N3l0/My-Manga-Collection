using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyMangaCollections
{
    public class Encriptacion
    {   
        // Funcion para realizar la encriptacion en SHA256 de la contrasena
        public static string GetSHA256 (String str) {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding ();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder ();
            stream = sha256.ComputeHash (Encoding.UTF8.GetBytes (str));
            for(int i = 0; i<stream.Length; i++)sb.Append (stream [i]);
            return sb.ToString ();

        }
    }
}