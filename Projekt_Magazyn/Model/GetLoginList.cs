using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Magazyn.Model
{
    internal class GetLoginList
    {
        public string Login { get; set; }
        //Co z hashowaniem
        public string Password { get; set; }
        public user id_user { get; set; }
    }

    enum user
    {
        admin=1, user=2 , mod=3
    }

  
}
