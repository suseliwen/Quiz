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
        HandleTeam handleTeam = new HandleTeam();
        

        bool isRunning = true;    

        System.Console.WriteLine("**********************************************");
        System.Console.WriteLine("Välkommen till Quiz-night på restaurang Valen!");
        System.Console.WriteLine("**********************************************");

        while (isRunning)
        {       

            System.Console.WriteLine("Gör ett av följande val:");
            System.Console.WriteLine("1. Skapa lag och lägg till spelare: ");
            System.Console.WriteLine("2. Starta quiz.");
            System.Console.WriteLine("3. Se ställning för alla deltagande lag.");
            System.Console.WriteLine("4. Avsluta");
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
                    System.Console.WriteLine("**** 1. Lägg till lag och deltagare****");
                    handleTeam.AddPlayerToteam();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine(" ****2. Starta quiz****");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("****3. Se ställning för varje lag**** ");
                    handleTeam.ShowTeamInfo();
                    break;
                } 
                case 4:
                {
                    System.Console.WriteLine("**** 4. Avsluta spelet****");
                     isRunning = false;
                     break;
                }               

            }           

        }
        
    }
}



