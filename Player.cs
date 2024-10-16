public class Player
{
    public string Name {get; set;}    

    public Player (string name) 
    {
        Name = name;        
    }
    public void ShowPlayer()
    {
        System.Console.WriteLine($"Spelaren{Name} ingå i lag x"); //här saknas logik för vilket lag spelaren ingår i!
    }

}
public class HandleTeam //En klass som hanterar de olika lagen - skapar team, lägger till spelare, hanterar poängställning
{
    public List<Team> teams = new List<Team>();
    public void AddPlayerToteam() //En metod där man först skapar ett lag (lista) och sedan lägger till deltagare i laget. 
    {       
        System.Console.Write("Skriv in namnet på ditt lag: ");
        string quizTeam = Console.ReadLine();

        Team team = new Team(quizTeam);
        teams.Add(team);
        
        bool keepAdding = true; 

        while (keepAdding) //En loop där man lägger till deltagare till laget. Skulle kunna utökas med begränsat antal platser om man vill...
        {
            System.Console.Write("Skriv in ditt namn: ");
            string playerName = Console.ReadLine();
            
            Player newPlayer = new Player(playerName); //Skapar en ny spelare mha klassen Player. 
            team.AddPlayer(newPlayer); //Här anropar jag funktionen AddPlayer som finns i klassen Team för att lägga till deltagaren till laget!

            System.Console.WriteLine("Vill du lägga till ytterligare spelare? Y/N");
            string answer = Console.ReadLine();

            if(answer != "Y" && answer != "y")
            {
                keepAdding = false;
            }
        }
       
    }
    public void ShowTeamInfo() //En metod för att skriva ut namn och poängställning. ??Egen metod för att skriva ut även deltagare i laget?!
    {
        foreach(var team in teams)
        {
            System.Console.WriteLine("********************************************************");
            System.Console.WriteLine($"Lagnamn: {team.TeamName}. Antal poäng: {team.TotalScore}");
            System.Console.WriteLine();
            foreach(var player in team.GetPlayers())
            {
                System.Console.WriteLine($"Spelare: {player.Name}");
                System.Console.WriteLine("-----------------------");
            }

        }
    }

}

public class Team //En klass för själva teamet - vilka egenskaper ska ett team ha?
{
    public string TeamName {get; set;}
    public int TotalScore {get; set;}
    public List<Player> players = new List<Player>();

    public Team(string teamName) //Konstruktor för teamet - namn, en lista som hämtar spelare från klassen Player, poäng m startvärde 0. 
    {
        TeamName = teamName;
        players = new List<Player>();
        TotalScore = 0;
    }

    public void AddPlayer(Player player) //Funktion för att lägga till spelare till laget. 
    {
        players.Add(player);
    }

    public List<Player> GetPlayers()
    {
        return players;
    }

    public void AddPoints(int points) //Räknare för respektive lags poäng.
    {
        TotalScore += points;
    }

    
    
    
    

}