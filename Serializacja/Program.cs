using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacja
{
    class Program
    {
        static void Main(string[] args)
        { 
            Osoba1 osoba1 = Osoba1.Load("Dane.xml");
            osoba1.Imie = "Kamil";
            osoba1.Nazwisko = "Paszkiet";
            osoba1.Wiek = 25;
            osoba1.Save("Dane.xml");

            
        }
    }
}