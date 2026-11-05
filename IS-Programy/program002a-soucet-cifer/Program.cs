Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("************* Ciferný součet *************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************ Sára Kendžirová *************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup celého čísla
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte celé číslo znovu: ");
    }

    
    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Celé číslo: {number}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    

    // 1. Příprava pomocných promněnýchpro výpočet
    int numberBackup = number;  //záloha původního čísla pro závěrečný výpis
    int sum = 0;                //Neutrální hodnotou pro sčítání je 0
    int digit;                  //Proměnná pro uložení právě zpracovávané cifry
    // 2. ošetření záporného čísla (znaménko nemá vliv na součet cifer)
    if(number < 0)
    {
        number = -number;  // Převod záporného čísla na kladné
    }

    // 3. Zvláštní případ
    if(number == 0)
    {
        sum = 0; // Součet cifer čísla 0 je 0
    }
    else
    {
     Console.WriteLine();
     Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice (z prava doleva)");

     // 4. Jádro problému - matematický rozklad čísla pomocí cyklu
     while (number > 0)
        {
            // Operátoru % se říká "modulo" (slouží k určení zbytku po dělení)
            digit = number % 10; // Získání poslední cifry čísla
            sum = sum + digit;   // Přičtení cifry k součtu
            number /= 10;        // Odstranění poslední cifry z čísla

            Console.WriteLine($"aktuální číslice (zbytek): {digit}");
            Console.WriteLine($"číslo po odříznutí aktuální číslice: {number}");
            Console.WriteLine($"aktuální hodnota cigferného součtu: {sum}");
        }
    }

    // 5. Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Ciferný součet čísla {numberBackup} je: {sum}");
    Console.WriteLine("==================================");
    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   