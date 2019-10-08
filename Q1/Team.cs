using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Q1
{
    public enum Result
    {
        Win,
        Draw,
        Loss
    }


    /*1.	Create a class called Team that has properties to hold the team name, 
     * number of wins, number of draws, number of losses, number of games. 
     * All these properties have private setters. 
     *
     * 2.	Add a property called Points which calculates the points based on the values for Wins,
     * Draws and Losses.  3 Points for a win, 1 for a draw and 0 for a loss.  
     * You need to use the long hand means of writing a property here as there is a calculation in the getter.
     *
     * * 3.	Create a constructor where the team name is set.  It should take in one parameter.  
     * In the program.cs file create Team objects for five teams such as the following:
     * Team SligoRovers = new Team("Sligo  Rovers"); 
     * Team FinnHarps =  new Team("Finn  Harps");
     * Team GalwayUnited = new Team("Galway  United"); 
     * Team DerryCity	= new Team("Derry  City");
     * Team Dundalk	= new Team("Dundalk");
     * 
     *14.	Add another class called Player.  This is a small class that has player name and position as properties.  
     * Add a property to Team which is a List of Players.  Create some players and add them to the Team.  
     * In program.cs display the players on one team. 
     */
    public class Team : IComparable
    {
        
        public string Name { get; private set; }
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Losses { get; private set; }
        public int Played { get; private set; }

       public List<Player> Players { get; set; }

       

        private int _points;
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

       

       

        public string DisplayTeamTable()
        {
            return string.Format($"{Name,-15}{Points,-7}{Wins,-7}{Draws,-7}{Losses,-7}{Played,-7}");
        }

        public void AddResult(Result result)
        {
            Played++;

            switch(result)
            {
                case Result.Win:
                    Wins++;
                    break;

                case Result.Loss:
                    Losses++;
                    break;

                case Result.Draw:
                    Draws++;
                    break;
            }
        }

        public int CompareTo(object obj)
        {
            Team teamObj = (Team)obj;

            return Points.CompareTo(teamObj.Points);
        }

        
    }
}
