//jednořádkový komentář

/* 
Toto je
více řádkový
komentář
*/

// jako první si připravíme smyčku pro opakování programu

string again = "a";
// .ToLower() - převede text na malá písmena, takže program bude pokračovaat i při zadání velkého písmena A
while(again.ToLower() == "a")
{
Console.Clear(); 
Console.WriteLine("***********************");
Console.WriteLine("název programu");
Console.WriteLine("***********************");   
Console.WriteLine("Sára K.");
Console.WriteLine("***********************");



// zadání počáteční hodnoty řady 
Console.Write("Zadejte počáteční hodnotu řady(celé číslo): ");
int aaa;
while(!int.TryParse(Console.ReadLine(), out aaa))
{
    Console.WriteLine("Nezadali jste celé číslo. Zadejte prosím celé číslo.");
    }

   // zadání poslední hodnoty řady - správné řešení
Console.Write("Zadejte poslední hodnotu řady(celé číslo): ");
int bbb;
while(!int.TryParse(Console.ReadLine(), out bbb))
{
    Console.WriteLine("Nezadali jste kladné celé číslo. Zadejte prosím celé číslo.");
    }
    

//rekapitulace zadaných hodnot
Console.WriteLine();
Console.WriteLine("========================");
// Console.WriteLine($"První číslo: {first}");
// Console.WriteLine($"Poslední číslo: {last}");
// Console.WriteLine($"Diference: {step}");

//výpis zadaných hodnot do jendoho řádku
Console.WriteLine($"První hodnota: {aaa}, Poslední hodnota: {bbb}");
Console.WriteLine("========================");
Console.WriteLine();

//jádro pro výpis algoritmu



//konec jádla

// dotaz směrem k uživateli na opakování programu 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
Console.WriteLine("pro ukončení programu stiskněte libovolnouklávesu.");
Console.WriteLine();
Console.Write("chete program spustit znovu?");
again = Console.ReadLine() ?? "";
 
}

Console.WriteLine("Hello, World!");
