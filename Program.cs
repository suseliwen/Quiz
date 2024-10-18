using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

//Ska man ha lag, eller enstaka spelare???????
//Om lag - skapa en lista för lag, där alla deltagare i ett lag läggs till.
//Skapa frågor och logik för hur frågorna ska visas. 
//Skapa en räknare för lagens poängställning
//Dela upp klasserna i olika filer

class Program
{

    public static void Main()
    {
        HandlePlayer handlePlayer = new HandlePlayer();

        bool isRunning = true;    

        System.Console.WriteLine("**********************************************");
        System.Console.WriteLine("Välkommen till Quiz-night på restaurang Valen!");
        System.Console.WriteLine("**********************************************");

        while (isRunning)
        {       

            System.Console.WriteLine("Gör ett av följande val:");
            System.Console.Write("1. Lägg till spelare i ditt lag: ");
            System.Console.Write("2. Lägg till ditt lag: ");
            System.Console.WriteLine("3. Starta quiz.");
            System.Console.WriteLine("4. Se ställning för alla deltagande lag.");
            System.Console.WriteLine("5. Avsluta");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                System.Console.WriteLine("Felaktig inmatning. Ange giltigt val");
                break;
            }

            switch(choice)
            {
                case 1:
                {
                    handlePlayer.AddPlayer();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("2. LÄgg till ditt lag");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("3. Starta quiz");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Alt 4 - se ställning för varje ");
                    break;
                } 
                case 5:
                {
                    System.Console.WriteLine("Avsluta spelet");
                     isRunning = false;
                     break;
                }               

            }           

        }

        
        
    }
}



