using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Magazyn.Service
{
    public static class SaveStateSevice
    {
        public static void Zapisz(Połaczenie połaczenie)
        {
            string json = JsonConvert.SerializeObject(połaczenie);
            File.WriteAllText("pathConnetion.json", json);
        }

        public static Połaczenie Odczytaj()
        {
            if (File.Exists("pathConnetion.json"))
            {
                string jsonSerialized = File.ReadAllText("pathConnetion.json");
                Połaczenie a = JsonConvert.DeserializeObject<Połaczenie>(jsonSerialized);
                return a;
            }
            else
            {
                return new Połaczenie() { Login = "" , Nazwa_Bazy = "" , Nazwa_servera = "" , Password = ""};
            }
        }

        public static void Clear(Połaczenie połaczenie)
        {
            połaczenie.Login = "";
            połaczenie.Password = "";
            string json = JsonConvert.SerializeObject(połaczenie);
            File.WriteAllText("pathConnetion.json", json);
        }

    }
}
