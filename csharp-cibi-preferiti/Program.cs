// See https://aka.ms/new-console-template for more information

string[] cibi = { "pizza", "carne", "seadas", "cheesecake", "torta", "tiramisù" };

//Stampo la lunghezza dell'array.
Console.WriteLine("Gli elementi nella mia lista sono: " + cibi.Length);

//Stampo L'intero array.
for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i} - {cibi[i]}");
}

//Stampo il cibo preferito.
Console.WriteLine($"Il mio cibo preferito è indubbiamente la {cibi[0]}");

//Stampo il mio ultimo cibo preferito
Console.WriteLine($"Invece uno dei cibi che più mi piacciono ma non è in cima alla classifica è il {cibi.Last()}");

//Stampo tutto