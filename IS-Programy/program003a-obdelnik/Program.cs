Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("******** Vykreslení obdelniku *********");
    Console.WriteLine("***************************************");
    Console.WriteLine("************ Sára Kendžirová **********");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");

    // Vstup pro šířku
    Console.Write("Zadejte šířku obrazce (kladné celé číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) ||  width <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte šířku obrazce znovu: ");
        Console.ResetColor();
    }

    // Vstup pro výšku
    Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) ||  height <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte výšku obrazce znovu: ");
        Console.ResetColor();
    }

    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Šířka: {width}; Výška: {height}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    
    // Vnějsí cyklus, který bude řídit správný počet řádků (výšku)
    for(int i = height; i >= 1; i--)
    {
        // Střídání barev pro sudé a liché řádky
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        for (int j = 1; j <= width; j++)
        {
             Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
        }
        Console.WriteLine();
    }
// Vrácení barvy konzole na výchozí hodnotu
    Console.ResetColor();


    // Konec jádra konkrétního algoritmu


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}  