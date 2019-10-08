using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /* * 3.	Create a constructor where the team name is set.It should take in one parameter.
     * In the program.cs file create Team objects for five teams such as the following:
     * Team SligoRovers = new Team("Sligo  Rovers");
     * Team FinnHarps =  new Team("Finn  Harps");
     * Team GalwayUnited = new Team("Galway  United");
     * Team DerryCity	= new Team("Derry  City");
     * Team Dundalk	= new Team("Dundalk");
     * 4.	In the program.cs file create an List of type Team 
     * to hold all the Team  objects and add the Team  objects created to the list.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Team SligoRovers = new Team("Sligo  Rovers");
            Team FinnHarps = new Team("Finn  Harps");
            Team GalwayUnited = new Team("Galway  United");
            Team DerryCity = new Team("Derry  City");
            Team Dundalk = new Team("Dundalk");

            var teamList = new List<Team>();
            teamList.Add(SligoRovers);
            teamList.Add(FinnHarps);
            teamList.Add(GalwayUnited);
            teamList.Add(DerryCity);
            teamList.Add(Dundalk);

            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Loss);
            FinnHarps.AddResult(Result.Draw);
            GalwayUnited.AddResult(Result.Win);
            Dundalk.AddResult(Result.Loss);

            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAMES", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            foreach (Team team in teamList)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }

            teamList.Sort();

            teamList.Reverse();

            Console.WriteLine();

            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAMES", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            foreach (Team team in teamList)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }

            Console.WriteLine();

            SligoRovers.Players.Add(new Player() { Name = "Ed Mcginty", Position = "GoalKeeper" });
            SligoRovers.Players.Add(new Player() { Name = "Jon Tron", Position = "Striker" });
            SligoRovers.Players.Add(new Player() { Name = "Dimitar Dimadome", Position = "Midfield" });

            Console.WriteLine("Sligo Rovers Teamsheet");
            foreach (Player player in SligoRovers.Players)
            {
                Console.WriteLine($"{player.Name} - {player.Position}");
            }

        }

    

    }
}
