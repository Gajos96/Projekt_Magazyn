using Projekt_Magazyn.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projekt_Magazyn.Service
{
    
    /// <summary>
    /// Pamietaj o hashowaniu hasła 
    /// </summary>
    internal class DataSetConneting : GetLoginList
    {
        #region variable
        //List przetrzymywana w pamieci.
        public List<GetLoginList> Obslist { get => GetUserTable(InfoDatabase); }
        public string InfoDatabase
        {
            get 
            { 
                DataBase123
                return @"Kropeczka nad i";
            }
        }
        #endregion

        /// <summary>
        /// Retrieves a list from the database.
        /// </summary>
        /// <param name="connection">Database connenction string</param>
        /// <returns></returns>
        public List<GetLoginList> GetUserTable(string connection)
        {
            //Zapytanie do bazy
            string qwerty = "Select * from Użytkownicy";
            if (Obslist?.Count != 0)
            {
                return Obslist;
            }
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(qwerty, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Hashowane hasło posiada 64 znaki => pole bazy musi tyle posiadać
                        Obslist.Add(new GetLoginList() { Login = (string)reader[1], Password = (string)reader[2], id_user = (user)reader[3] });
                    }
                }
            }
            return Obslist;
        }

        /// <summary>
        /// It uses the list downloaded from sql and only reads logins.
        /// </summary>
        /// <param name="Obslist">List in memory</param>
        /// <returns></returns>
        public List<string> GetLoginList() 
        {
            List<string> list = new List<string>();
            if(Obslist?.Count != 0)
            {
                list = (List<string>)Obslist.Select(o => o.Login);
            }
            else
            {
                //Pamietaj że musi być chociaż jeden element w liscie Userów "Szef"
                throw new Exception("Lista jest pusta");
            }
            return list;
        }

       








    }
}
