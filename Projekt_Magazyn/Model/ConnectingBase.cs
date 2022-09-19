using Newtonsoft.Json;
using System.IO;

namespace Projekt_Magazyn
{
    public class Połaczenie
    {
        [JsonProperty("Nazwa_servera")]
        public string Nazwa_servera { get; set; }
        [JsonProperty("Nazwa_Bazy")]
        public string Nazwa_Bazy { get; set; }
        [JsonProperty("Login")]
        public string Login { get; set; }
        [JsonProperty("Password")]
        public object Password { get; set; }

    }
}