using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    static class Calculator
    {
        private static int stayWins = 0;
        private static int stayLosses = 0;

        private static int switchWins = 0;
        private static int switchLosses = 0;

        // Getters and Setters for Stay wins/losses
        public static int StayWins { get => stayWins; set => stayWins = value; }
        public static int StayLosses { get => stayLosses; set => stayLosses = value; }

        // Getters and Setters for Switch wins/losses
        public static int SwitchWins { get => switchWins; set => switchWins = value; }
        public static int SwitchLosses { get => switchLosses; set => switchLosses = value; }

        // Calculate and return the percentage of wins made by staying with the first choice
        public static double getStayPercent()
        {
            int rounds = stayWins + stayLosses;

            try {
                return (stayWins * 100) / rounds;
            } catch {
                return 0;
            }
            
        }

        // Calculate and return the percentage of wins made by switching from the first choice
        public static double getSwitchPercent()
        {
            int rounds = switchWins + switchLosses;

            try {
                return (switchWins * 100) / rounds;
            } catch {
                return 0;
            }            
        }

        // Return number of rounds that player has chosen to stay
        public static int getStayRounds()
        {
            return stayWins + stayLosses;
        }

        // Return number of rounds that player has chosen to switch
        public static int getSwitchRounds()
        {
            return switchWins + switchLosses;
        }

        // Reset all stored values to 0
        public static void resetCalc()
        {
            stayWins = 0;
            stayLosses = 0;
            switchWins = 0;
            switchLosses = 0;
        }
    }
}
