using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *************** MONTY HALL PROBLEM SIMULATOR ****************
 * 
 * Author: Joshua McMahan
 * Last Updated: 05/21/2019
 * Description: 
 *      This program simulates the infamous "Monty Hall" game theory problem solved by vos Savant, as described below:
 *      
 *      1. Players are shown three (3) doors, two (2) of which hide a goat behind them, and one (1) which hides a car
 *      2. Players choose a door. After their choice has been made, the game's host opens another door, revealing a 
 *         goat behind it, and then offers the player a choice: open the door they've already chosen, or switch to the 
 *         other unopened door.
 *      3. Statistically, the player has a 2/3 chance of winning a car if they choose to switch doors, as opposed to
 *         a 1/3 chance of winning if they choose not to switch; this probability is what this simulator intends to prove
 *         
 * Thanks for playing! Enjoy!
 * 
 * - JGM
 *         
 *************************************************************
 */

namespace MontyHall
{
    public partial class frmMain : Form
    {
        // Easier way to keep track of which integer represents which prize
        private static int CAR = 0;
        private static int GOAT = 1;

        private static int firstChoice;
        private static int revealedDoor;

        // Track current round number
        private static int ROUND = 0;

        // Array to track the current status of each door (prize type, chosen by player)
        private static object[,] DOOR_LIST = { { 2, false }, { 2, false }, { 2, false } };

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Listener for Start button; start new game on click (if not already playing)
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ROUND == 0) {
                ROUND = 1;
                populateDoors(DoorStocker.Stock());
            }
        }

        // Listener for Button for Door 1
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (ROUND == 1) {
                DOOR_LIST[0, 1] = true;
                firstChoice = 0;
                ROUND++;
                rtbOne.AppendText("\n\nChosen");
                revealGoat();
            } else if (ROUND == 2 && revealedDoor != 0) {
                DOOR_LIST[0, 1] = true;
                DOOR_LIST[1, 1] = false;
                DOOR_LIST[2, 1] = false;
                ROUND = 0;

                if (firstChoice == 0) {
                    calcResult(true, 0);
                } else {
                    calcResult(false, 0);
                }
                
            }
        }

        // Listener for Button for Door 2
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (ROUND == 1) {
                DOOR_LIST[1, 1] = true;
                firstChoice = 1;
                ROUND++;
                rtbTwo.AppendText("\n\nChosen");
                revealGoat();
            } else if (ROUND == 2 && revealedDoor != 1) {
                DOOR_LIST[0, 1] = false;
                DOOR_LIST[1, 1] = true;
                DOOR_LIST[2, 1] = false;
                ROUND = 0;

                if (firstChoice == 1) {
                    calcResult(true, 1);
                } else {
                    calcResult(false, 1);
                }
            }
        }

        // Listener for Button for Door 3
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (ROUND == 1) {
                DOOR_LIST[2, 1] = true;
                firstChoice = 2;
                ROUND++;
                rtbThree.AppendText("\n\nChosen");
                revealGoat();
            } else if (ROUND == 2 && revealedDoor != 2) {
                DOOR_LIST[0, 1] = false;
                DOOR_LIST[1, 1] = false;
                DOOR_LIST[2, 1] = true;
                ROUND = 0;

                if (firstChoice == 2) {
                    calcResult(true, 2);
                } else {
                    calcResult(false, 2);
                }
            }
        }

        // Listener for Reset button; reset all stored values to 0 and clear all text boxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            ROUND = 0;
            Calculator.resetCalc();

            tbStayWin.ResetText();
            tbStayLose.ResetText();
            tbStayPct.ResetText();
            tbStayRnds.ResetText();
            tbSwitchWin.ResetText();
            tbSwitchLose.ResetText();
            tbSwitchPct.ResetText();
            tbSwitchRnds.ResetText();

            rtbOne.ResetText();
            rtbTwo.ResetText();
            rtbThree.ResetText();

            for (int i = 0; i < 3; i++)
            {
                DOOR_LIST[i, 0] = 2;
                DOOR_LIST[i, 1] = false;
            }
        }

        // Prepare the doors, and assign the prizes to their respective doors
        private void populateDoors(int[] prizes)
        {
            rtbOne.ResetText();
            rtbTwo.ResetText();
            rtbThree.ResetText();

            rtbOne.AppendText("Door One");
            rtbTwo.AppendText("Door Two");
            rtbThree.AppendText("Door Three");

            for (int i = 0; i < 3; i++)
            {
                DOOR_LIST[i, 0] = prizes[i];
                DOOR_LIST[i, 1] = false;
            }
        }

        // Reveal all unrevealed doors, and show the results of the player's choice
        private void revealDoors(bool won)
        {
            rtbOne.ResetText();
            rtbTwo.ResetText();
            rtbThree.ResetText();

            rtbOne.AppendText( ( ( (int)DOOR_LIST[0, 0] == CAR) ? "Car" : "Goat" ) + ( ( (bool)DOOR_LIST[0, 1] == true) ? (won ? "\n\nWon!" : "\n\nLost") : "" ) );
            rtbTwo.AppendText( ( ( (int)DOOR_LIST[1, 0] == CAR) ? "Car" : "Goat" ) + ( ( (bool)DOOR_LIST[1, 1] == true) ? (won ? "\n\nWon!" : "\n\nLost") : "") );
            rtbThree.AppendText( ( ( (int)DOOR_LIST[2, 0] == CAR) ? "Car" : "Goat" ) + ( ( (bool)DOOR_LIST[2, 1] == true) ? (won ? "\n\nWon!" : "\n\nLost") : "" ) );
        }

        // Reveal a door that the player has not chosen, and that contains a goat
        private void revealGoat()
        {
            bool chosen = false;
            int choiceFinal = 3;

            // Keep picking doors at random until the chosen door satisfies the criteria mentioned above
            do {
                int choice = DoorPicker.Pick();

                if ((int)DOOR_LIST[choice, 0] == GOAT && (bool)DOOR_LIST[choice, 1] == false) {
                    choiceFinal = choice;
                    chosen = true;
                }

            } while (chosen == false);

            switch (choiceFinal)
            {
                case 0:
                    rtbOne.ResetText();
                    rtbOne.AppendText("Goat");
                    revealedDoor = 0;
                    break;
                case 1:
                    rtbTwo.ResetText();
                    rtbTwo.AppendText("Goat");
                    revealedDoor = 1;
                    break;
                case 2:
                    rtbThree.ResetText();
                    rtbThree.AppendText("Goat");
                    revealedDoor = 2;
                    break;
                default:
                    System.Console.Write("Error: Invalid number - " + choiceFinal);
                    break;
            }
        }

        // Calculate the results of the game, and the percentages thusfar, before revealing prizes
        private void calcResult(bool stayed, int choice)
        {
            // If won or lost, increase respective stored value in Calculator
            if ((int)DOOR_LIST[choice, 0] == CAR) {
                if (!stayed) {
                    Calculator.SwitchWins++;
                    tbSwitchWin.ResetText();
                    tbSwitchWin.AppendText("" + Calculator.SwitchWins);
                } else {
                    Calculator.StayWins++;
                    tbStayWin.ResetText();
                    tbStayWin.AppendText("" + Calculator.StayWins);
                }

                revealDoors(true);
            } else if ((int)DOOR_LIST[choice, 0] == GOAT) {
                if (!stayed) {
                    Calculator.SwitchLosses++;
                    tbSwitchLose.ResetText();
                    tbSwitchLose.AppendText("" + Calculator.SwitchLosses);
                } else {
                    Calculator.StayLosses++;
                    tbStayLose.ResetText();
                    tbStayLose.AppendText("" + Calculator.StayLosses);
                }

                revealDoors(false);
            }

            // Update percentages
            tbStayPct.ResetText();
            tbSwitchPct.ResetText();
            tbStayRnds.ResetText();
            tbSwitchRnds.ResetText();
            tbStayPct.AppendText(Calculator.getStayPercent() + "% Wins");
            tbSwitchPct.AppendText(Calculator.getSwitchPercent() + "% Wins");
            tbStayRnds.AppendText("" + Calculator.getStayRounds());
            tbSwitchRnds.AppendText("" + Calculator.getSwitchRounds());
        }
    }

    /* Fun bit of trivia: 
     *      When Savant published her (correct) answer, she received about 10,000~ letters that
     *      claimed she was wrong, and about 1,000 of those were from PhDs.
     *      
     *      One letter said, "Maybe women look at math problems differently than men."
     *      
     *      Oops~
     */
}
