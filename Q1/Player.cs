using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /*14.	Add another class called Player.  This is a small class that has player name and position as properties.  
     * Add a property to Team which is a List of Players.  Create some players and add them to the Team.  
     * In program.cs display the players on one team. 
     */
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            
                {
                return string.Format($"{Name,-15}{Position,-7}");
            }
        }
    }
}
