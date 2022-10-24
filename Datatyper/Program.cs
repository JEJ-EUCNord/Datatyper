// 
// Tegn og strenge
//

// En enkelt karakter angives med enkelt sitationstegn '
char bogstav = 'A';
char symbol = '#';

Console.WriteLine(bogstav);
Console.WriteLine(symbol);

// En streng (tekst angives med dobbelt sitationstegn "
string navn = "Jens Jensen";
Console.WriteLine(navn);
// En streng kan indeholde kontroltegn
string navn1 = "Jens\tJensen";
Console.WriteLine(navn1);
// Med @ læses alle tegn som de er skrevet
string navn2 = @"Jens\tJensen";
Console.WriteLine(navn2);
// Den interpolerede streng kan dannes dynamisk
string fornavn = "Jens";
int alder = 56;
string interpoleretStreng = $"Mit navn er {fornavn} og jeg er {alder} gammel";
Console.WriteLine(interpoleretStreng);

// 
// Tal
//

// heltal
uint naturligtTal = 8; // unsigned integer
Console.WriteLine(naturligtTal);
int helTal = -8; // integer
Console.WriteLine(helTal);

// flydende tal
double flydendeTal = 3.14;
Console.WriteLine(flydendeTal);

//
// størrelser for typer
//
Console.WriteLine(sizeof(int));
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

Console.WriteLine($"Typen int fylder {sizeof(int),9} bytes og den mindst mulige værdi er {int.MinValue,-15}");
Console.WriteLine($"Typen int fylder {sizeof(int),-9} bytes og den mindst mulige værdi er {int.MinValue,15}");

//
// Her arbejdes med øvelse 2.3 Practice number sizes and ranges
//
