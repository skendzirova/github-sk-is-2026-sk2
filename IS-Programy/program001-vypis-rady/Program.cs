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
Console.WriteLine("Program pro výpis číselné řady");
Console.WriteLine("***********************");   
Console.WriteLine("Sára K.");
Console.WriteLine("***********************");

// zadání počáteční hodnoty řady - španě řešený
// console.Write("Zadejte počáteční hodnotu řady: ");
// int first = int.Parse(Console.ReadLine() );

// zadání počáteční hodnoty řady - správné řešení
Console.Write("Zadejte počáteční hodnotu řady(celé číslo): ");
int first;
while(!int.TryParse(Console.ReadLine(), out first))
{
    Console.WriteLine("Nezadali jste celé číslo. Zadejte prosím celé číslo.");
    }

   // zadání poslední hodnoty řady - správné řešení
Console.Write("Zadejte poslední hodnotu řady(celé číslo): ");
int last;
while(!int.TryParse(Console.ReadLine(), out last))
{
    Console.WriteLine("Nezadali jste kladné celé číslo. Zadejte prosím celé číslo.");
    }
    
    // vstup diference s kontrolou kladné hodnoty 
Console.Write("Zadejte diferenci řady(kladné celé číslo): ");
int step;
while(!int.TryParse(Console.ReadLine(), out step) || step <= 0)
{
    Console.Write("Nezadali jste kladné celé číslo. Zadejte prosím kladné celé číslo.");
}

   // dotaz směrem k uživateli na opakování programu 
   Console.WriteLine();
   Console.WriteLine();
   Console.WriteLine("pro opakování programu stisknete klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("pro ukončení programu stiskněte libovolnouklávesu.");
    Console.WriteLine();
    Console.Write("chete program spustit znovu?");
   again = Console.ReadLine() ?? "";
 
}

