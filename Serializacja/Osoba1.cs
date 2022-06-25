using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacja
{
    public class Osoba1
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public void Save(string nazwaPliku)
        {
            using (var stream = new FileStream(nazwaPliku, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Osoba1));
                XML.Serialize(stream, this);
            }
        }
        public static Osoba1 Load(string nazwaPliku)
        {
            using(var stream = new FileStream(nazwaPliku, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Osoba1));
                return (Osoba1)XML.Deserialize(stream);
            }
        }
    }
}
