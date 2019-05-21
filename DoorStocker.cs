using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    // This class is responsible for "stocking" the doors with their prizes at the beginning of the game
    class DoorStocker
    {
        private static int[] LIMITS = { 249, 250, 499, 500 };
        private static int CAR = 0;
        private static int GOAT = 1;

        // Randomly assign and return the prizes
        public static int[] Stock()
        {
            Random rnd = new Random();

            // Using a random int between 0-750 to generate more consistently random results
            int[] doors = new int[3];
            int prize = rnd.Next(750);

            if (prize <= LIMITS[0]) {
                doors[0] = CAR;
                doors[1] = GOAT;
                doors[2] = GOAT;
            } else if (prize >= LIMITS[1] && prize <= LIMITS[2]) {
                doors[0] = GOAT;
                doors[1] = CAR;
                doors[2] = GOAT;
            } else if (prize >= LIMITS[3])
            {
                doors[0] = GOAT;
                doors[1] = GOAT;
                doors[2] = CAR;
            }

            return doors;
        }
    }

    // This class is responsible for picking a door to reveal after the player has made their first choice
    class DoorPicker
    {
        private static int[] LIMITS = { 249, 250, 499, 500 };

        // Return the randomly chosen door (1, 2, or 3)
        public static int Pick()
        {
            Random rnd = new Random();
            int random = rnd.Next(750);

            if (random <= LIMITS[0])
            {
                return 0;
            }
            else if (random >= LIMITS[1] && random <= LIMITS[2])
            {
                return 1;
            }
            else if (random >= LIMITS[3])
            {
                return 2;
            }

            return 3;
        }
    }
}
