using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AC1_Olivella_Arnau
{
    public class CheckValidity
    {
        public static bool CheckPlayer(string player)
        {
            if (player == null)
            {
                return false;
            }
            if (player.Any(c => !char.IsLetter(c)))
            {
                return false;
            }
            return true;
        }
        public static bool CheckMission(string mission)
        {
            int counter = 0;
            bool found = false;
            List<string> letrasGriegas = new List<string>{
                "Delta",
                "Alpha",
                "Beta",
                "Gamma",
                "Epsilon",
                "Zeta",
                "Eta",
                "Theta",
                "Iota",
                "Kappa",
                "Lambda",
                "Mu",
                "Nu",
                "Xi",
                "Omicron",
                "Pi",
                "Rho",
                "Sigma",
                "Tau",
                "Upsilon",
                "Phi",
                "Chi",
                "Psi",
                "Omega"
            };
            List<char> Digit = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (mission == null)
            {
                return false;
            }
            if (!mission.Contains("-"))
            {
                Console.WriteLine("Ha de contenir un guió '-'");
                return false;
            }
            foreach (char c in mission)
                {
                    if (c == '-')
                    {
                        counter++;
                    }
                    if (counter > 1)
                    {
                        Console.WriteLine("Ha de contenir un únic guió '-'");
                        return false;
                    }
                }
            if (letrasGriegas.Contains(mission.Substring(0, mission.IndexOf("-"))))
            {
                found = true;
            }
            if (!found)
            {
                Console.WriteLine("Ha de començar amb el nom d'una lleta grega");
                for (int i = 0; i < letrasGriegas.Count; i++)
                {
                    Console.WriteLine(letrasGriegas[i] + "\n");
                }
                return false;
            }
            if (mission.Substring(mission.IndexOf("-") + 1).Length != 3)
            {
                Console.WriteLine("Ha d'acabar amb 3 caràcters numèrics");
                return false;
            }
            foreach (char c in mission.Substring(mission.IndexOf("-") + 1))
            {
                if (!Digit.Contains(c))
                {
                    Console.WriteLine("Ha d'acabar amb 3 caràcters numèrics");
                    return false;
                }
            }
            return true;
        }
        public static bool CheckScoring(int scoring)
        {
            if (scoring < 0 || scoring > 500)
            {
                return false;
            }
            return true;
        }
    }
}
