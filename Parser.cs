using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class Parser
    {
        public static IEnumerable<Indirizzo> Read()
        {
           using var input = File.OpenText("..\\..\\..\\addresses.csv");
           var indirizzi = new List<Indirizzo>();

           input.ReadLine();


           while (true)
           {
                string? line = input.ReadLine();
                if (line is null) return indirizzi;

                var chunks = line.Split(',')!;
                if (chunks.Length < 6) continue;
                var name = chunks[0];
                var surname = chunks[1];
                var street = chunks[2];
                var city = chunks[3];
                var province = chunks[4];
                var zip = chunks[5];
                 
                Indirizzo indirizzo = new Indirizzo(name , surname, street, city , province , zip);

                indirizzi.Add(indirizzo);
                
            }


        }

        public static void Write( IEnumerable<Indirizzo> indirizzi) 
        {
            using var output = File.CreateText("addresses.csv");
        }

    }
}
