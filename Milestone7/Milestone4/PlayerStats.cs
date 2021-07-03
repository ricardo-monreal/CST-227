using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone6
{

    // Milestone 6.1 - 6.3
    //implement the IComparable interface and should contain attributes for the player’s initials(or names), the level of difficulty played, and the time elapsed
    public class PlayerStats : IComparable<PlayerStats>
    {
        public string playerInitials { get; set; }
        public string gameDifficulty { get; set; }  
        public TimeSpan playTime { get; set; }


        public PlayerStats(string playerInitials, string gameDifficulty, TimeSpan playTime)
        {
            this.playerInitials = playerInitials;
            this.gameDifficulty = gameDifficulty;
            this.playTime = playTime;
        }

        public int CompareTo(PlayerStats other)
        {
            return playTime.CompareTo(other.playTime);
        }
    }
}
