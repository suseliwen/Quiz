using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

//Ska man ha lag, eller enstaka spelare???????
//Om lag- skapa en lista för lag, där alla deltagare i ett lag läggs till.
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
            System.Console.WriteLine("1. Lägg till kvällens deltagare.");
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
                    handlePlayer.AddPlayer();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Alt 2");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Alt 3");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Alt 4");
                    isRunning = false;
                    break;
                }                

            }           

        }

        
        
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

class Question
{
    public string QuestionText {get; set;}
    public string Answer {get; set;}

    public Question(string questionText, string answer )
    {
        QuestionText = questionText;
        Answer = answer;
    }

}

class Quiz
{
   List<Question> questions = new List<Question>();

    public void AddQuestion(string questionText, string answer)
    {
        Question newQuestion = new Question(questionText, answer);
        questions.Add(newQuestion);
        
    }

    public void ShowAllQuestions()
    {
        foreach(Question question in questions)
        {
            System.Console.WriteLine(question);
        }
    }
}