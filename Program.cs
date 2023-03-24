using csharp_lista_indirizzi;

var indirizzi = Parser.Read();
Parser.Write(indirizzi);


foreach (var indirizzo in indirizzi)
{
    Console.WriteLine(indirizzo);
}
