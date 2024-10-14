using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

class Program
{

    public static void Main()
    {
        HandlePlayer handlePlayer = new HandlePlayer();

        System.Console.WriteLine("Välkommen till Quiz-night!");

        handlePlayer.AddPlayer();         
       
    }

}


public class Player
{
    public string Name {get; set;}
    public int Score {get; set;}
    bool isActive {get; set;}

    public Player (string name, int score)
    {
        Name = name;
        Score = 0;
        isActive = true;
    }

    public void ShowPlayer()
    {
        System.Console.WriteLine($"Spelaren{Name} har {Score} poäng");
    }

}

public class HandlePlayer
{
    List<Player> players = new List<Player>();


    public void AddPlayer()
    {
        bool keepAdding = true; 

        while (keepAdding)
        {
            System.Console.Write("Skriv in ditt namn: ");
            string playerName = Console.ReadLine();
            
            Player newPlayer = new Player(playerName, 0);
            players.Add(newPlayer);

            System.Console.WriteLine("Vill du lägga till ytterligare spelare? Y/N");
            string answer = Console.ReadLine();

            if(answer != "Y" && answer != "y")
            {
                keepAdding = false;
            }
        }

        System.Console.WriteLine("Du har lagt till följande spelare:");
        foreach(Player player in players)
        {
            System.Console.WriteLine(player.Name);
        }
      
        
    }

    

    

}
