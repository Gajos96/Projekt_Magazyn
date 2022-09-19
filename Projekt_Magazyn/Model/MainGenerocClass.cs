using Projekt_Magazyn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Magazyn.Model
{

    public class Ogolna
    {
        #region MyRegion
        public class IconList
        {
            public string Nazwa { get; set; }
            public string IconActive { get; set; }
            public string IconDeacvite { get; set; }
        }

        public class GenericList
        {
            List<IconList> lista = new List<IconList>();

            public void AddElement(IconList element)
            {
                if (element != null)
                {
                    lista.Add(element);
                }
            }

            public IconList GetElement(int index)
            {
                if (index < lista.Count) { return lista[index]; }
                else { return default; }
            }

        }
    } 
    #endregion





   
}


