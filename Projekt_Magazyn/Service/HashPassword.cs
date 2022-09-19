using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Magazyn
{
    public class HashPassword
    {
        //Pomysł jest taki tworzymy konta i zakłądamy hasła w programie.
        //Na podstawie tego program hashuje hasło
        //


        /// <summary>
        /// Pamietaj o zapisaniu soli po jej wygenerowaniu ,aby odkodować zahashowane hasła
        /// </summary>
        /// <param name="size">Number np : 10</param>
        /// <returns></returns>
        public String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public String GenerateSHA256Hash(String input , String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sHA256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sHA256hashstring.ComputeHash(bytes);
            return ByteArrayToHexString(hash);
        }

        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }


    }
}
