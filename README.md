Syntax, vad är det?

Hej Manuel!
Hello, Manuel!

Manuel sa igår "Vi ses imorn"

```csharp
// <datatyp>[] <namn> = new <datatyp>[<längd>]
int[] myArray = new int[64];

// olika datatyper, t.ex. int, string, bool
// variabler, deklaration

int age; // <datatyp> <variabelnamn> 

age = 10; // <variabelnamn> = <value>; variable assignment

int other_age = 20; // variable declaration and assignment

// arrays, en samling/lista av flera värden

// {} är ett kodblock, saker som kommer innan ett kodblock hanterar kontrollflöden, 
// just nu känner vi till följande: for, while, if, else, else if, switch

// boolean expressions, saker som kan vara true eller false

bool allowed_to_consume_alcohol = age >= 18;

// hur vi kan repettera kod => loopar, while och for

// for(<datatyp> <namn> = <startvärde>; <boolean expression>; <end_of_loop_exression>) { kod som ska repeteras i loopen}
// <end_of_loop_exression> är oftast något sätt att öka på en variabel som används i vår <boolean expression>, t.ex. i += 1;
for(int i = 0; i < 10; i += 1)
{

}

string input = Console.ReadLine(); // "11"

// int.TryParse exempel

bool succeeded = int.TryParse(<string, or a string variable>, out int <ny variabel>); // 11

if(int.TryParse(input, out int input_as_int))
{

}

```

Lista av keywords som vi har i C#:
- int:          datatyp (heltal)
- string:       datatyp (text)
- bool:         datatyp (sant eller falskt, true/false)
- for:          kontrolflöde (loop)
- while:        kontrolflöde (loop)
- \<datatyp\>[]:  del av datatyp (används för att skapa en array av någon datatyp)
- = :           används för att ge ett värde till en variablel
- == :          används för att se ifall ett värde är lika med ett annat
- \<  :          används för att se ifall värdet på vänster sida är mindre än värdet på höger sida
- \>  :          används för att se ifall värdet på höger sida är mindre än värder på vänster sida
- \<= :          används för att se ifall värder på vänster sida är mindre än eller lika med värder på höger sida
- \>= :          används för att se ifall värder på höger sida är mindre än eller lika med värder på vänster sida
- if:           kontrolflöde (bestämmer ifall kod ska köra eller ej)
- else:         kontrolflöde (måste ligga efter en if sats, körs ifall if satsen inte kördes)
- else if:      kontrolflöde (måste ligga efter en if sats eller en annan else if sats, ifall if satsen åvanför inte kördes, så körs kanske denna ifall den är true)
- &&:           boolean AND, left AND right side must be true for it to equal true
- ||:           boolean OR, left OR right side must eb true for it to equal true
- &:            binary AND

Lista av metoder/funktioner som vi har i C#:
- Console.WriteLine():  skriver ut text till konsollen
- Console.ReadLine():   läser in användarinput från konsollen
- int.TryParse():       försöker göra om en "string" till en "int"




