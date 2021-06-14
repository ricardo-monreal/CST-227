using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class SuperHero
    {
        public String name { get; set; }
        public int age { get; set; }
        public DateTime inception { get; set; }
        public DateTime daySavedEarth { get; set; }
        public DateTime death { get; set; }
        public ArrayList stats { get; set; }

        // Experiential Attr
        public int yearsActive { get; set; }
        public String symbolColor { get; set; }
        public int moralLevel { get; set; }

        // Metadata
        public String location { get; set; }
        public String trasnportation { get; set; }

        public ArrayList teamAffiliation { get; set; }
        // Physical Attributes
        public int speed { get; set; }
        public int strength { get; set; }
        public int stamina { get; set; }
        public int agility { get; set; }
        public int intelligence { get; set; }

        public SuperHero()
        {
            stats = new ArrayList();
            teamAffiliation = new ArrayList();
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\n" +
                "Age: {1}\n" +
                "Inception: {2}\n" +
                "Saved Earth On: {3}\n" +
                "Death: {4}\n" +
                "Abilities: {5}\n" +
                "Years Active: {6}\n" +
                "Symbol Color: {7}\n" +
                "Moral Level: {8}\n, " +
                "Location: {9}\n" +
                "Way of Transportation: {10}\n" +
                "Team Affiliation: {11}\n" +
                "\n" +
                "\bStats\b" +
                "Speed: {12}, Strength: {13}\n" +
                "Stamina: {14}, Agility: {15}\n" +
                "Intellect: {16}", name, age, inception.ToString(), daySavedEarth.ToString(), death.ToString(), string.Join(", ", stats.ToArray()), yearsActive, symbolColor, moralLevel, location, trasnportation, string.Join(", ", teamAffiliation.ToArray()), speed, strength, stamina, agility, intelligence).Replace("\n",
                                                         Environment.NewLine);
        }
    }
}