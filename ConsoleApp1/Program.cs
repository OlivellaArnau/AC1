using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace AC1_Olivella_Arnau
{
    class Program
    {
        public static void Main()
        {
            bool check = false;
            string player;
            string mission;
            int scoring;
            List<Score> scores = new List<Score>();
            for (int i = 0; i < 10; i++)
            {                
                do
                {
                    Console.WriteLine("Introdueix el nom del jugador (Només pot contenir caràcters alfabètics):");
                    player = Console.ReadLine(); 
                } while (!CheckValidity.CheckPlayer(player));
               
                do
                {
                    Console.WriteLine("Introdueix la missió (Ex:Delta-001):");
                    mission = Console.ReadLine();
                } while (!CheckValidity.CheckMission(mission));

                do
                {
                    Console.WriteLine("Introdueix la puntuació [0,500]:");
                    scoring = Convert.ToInt32(Console.ReadLine());
                } while (!CheckValidity.CheckScoring(scoring));
                scores.Add(new Score(player, mission, scoring));
            }
            List<Score> ranking = GenerateUniqueRanking(scores);
            foreach (Score score in ranking)
            {
                Console.WriteLine(score.Player + " " + score.Mission + " " + score.Scoring);
            }            
        }
        public static List<Score> GenerateUniqueRanking(List<Score> scores)
        {
            var ranking = scores
                .GroupBy(score => new { score.Player, score.Mission })
                .Select(group => group.OrderByDescending(score => score.Scoring).First())
                .ToList();
            return ranking;
        }
    }
}