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
console.Clear(); 
Console.WriteLine("***********************");
Console.WriteLine("Program pro výpis číselné řady");
Console.WriteLine("***********************");   
console.WriteLine("Sára K.");
console.WriteLine("***********************");


   
   // dotaz směrem k uživateli na opakování programu 
   console.WriteLine();
   console.WriteLine();
   console.WriteLine("pro opakování programu stisknete klávesu a. Následně potvrďte klávesou Enter.");
    console.WriteLine("pro ukončení programu stiskněte libovolnouklávesu.");
    console.WriteLine();
    console.Write("chete program spustit znovu?");
   again = Console.ReadLine() ?? "";
 
}

