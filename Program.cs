using csharp_lista_indirizzi;

var indirizzi = Parser.Read();
var ultimiTreIndirizzi = indirizzi.Skip(Math.Max(0, indirizzi.Count() - 3)).Take(3);

foreach (var indirizzo in indirizzi)
{
    Console.WriteLine(indirizzo);
}
