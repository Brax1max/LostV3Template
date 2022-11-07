using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            outputLabel.Text = "You were transported to a new world";
            option1Label.Text = "go north";
            option2Label.Text = "go south";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 13;
            }



            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You were transported to a new world  ";
                    option1Label.Text = "go north";
                    option2Label.Text = "go south";
                    break;
                case 2:
                    outputLabel.Text = "while walking you find a  fruit do you eat it.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 3:
                    outputLabel.Text = "you were shot by a pirate and dead. would you like to restart? ";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "you die of hunger.would you like to start again";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    outputLabel.Text = "you eat the fruit and it tastes bad and now you have power to create , control , and transform into mochi . a man come up to you and ask you if you would like to join his pirate crew.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 6:
                    outputLabel.Text = "you go with them and you go on a lot of advancer and and have. the good ending. would you like to start again ?";
                    break;
                case 7:
                    outputLabel.Text = "you make it to a boat and go on advancer by yourself. you find a wondering trades man he is sale a sword do you buy it.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 8:
                    outputLabel.Text = "you go off on your own and get killed by a marine. the bad ending.would you like to start again? ";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 9:
                    outputLabel.Text = "you buy a sword and it turn out it has curse on it. as you start walk around you find a sword man do you ask him to trine you. ";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 10:
                    outputLabel.Text = "the man stab you and you die.do you want to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                     case 11:
                    outputLabel.Text = "well using your sword, you accidently stab your self and you die of blood lose. do you want to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 12:
                    outputLabel.Text = "you learn how to use your sword and you can now make a curse slash.  on your walk you see a marine do you fight him.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 13:
                    outputLabel.Text = "you fight the marine and you kill him but your bounty go up and now you are wanted by the world government. the end.would you like to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 14:
                    outputLabel.Text = "you leave the marine alone. the end.would you like to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                    break;
                case 99:

                    break;
                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            ///

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);

                if (chance < 70)
                {
                    page = 7;

                }
                else
                {
                    page = 8;
                }
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 99;
            }
             else if (page == 11)
            {
                page = 99;
            }
             else if (page == 12)
            {
                page = 14;
            }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You were transported to a new world  ";
                    option1Label.Text = "go north";
                    option2Label.Text = "go south";
                    break;
                case 2:
                    outputLabel.Text = "while walking you find a  fruit do you eat it.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 3:
                    outputLabel.Text = "you were shot by a pirate and dead. would you like to restart? ";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "you die of hunger.would you like to start again";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    outputLabel.Text = "you eat the fruit and it tastes bad and now you have power to create , control , and transform into mochi . ma man come up to you and ask you if you would like to join his pirate crew.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 6:
                    outputLabel.Text = "you go with them and you go on a lot of advancer and and have. the good ending. would you like to start again ?";
                    break;
                case 7:
                    outputLabel.Text = "you make it to a boat and go on advancer by yourself. you find a wondering trades man he is sale a sword do you buy it.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 8:
                    outputLabel.Text = "you go off on your own and get killed by a marine. the bad ending.would you like to start again? ";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 9:
                    outputLabel.Text = "you buy a sword and it turn out it has curse on it. as you start walk around you find a sword man do you ask him to trine you. ";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 10:
                    outputLabel.Text = "the man stab you and you die.do you want to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 11:
                    outputLabel.Text = "well using your sword, you accidently stab your self and you die of blood lose. do you want to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 12:
                    outputLabel.Text = "you learn how to use your sword and you can now make a curse slash.  on your walk you see a marine do you fight him.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 13:
                    outputLabel.Text = "you fight the marine and you kill him but your bounty go up and now you are wanted by the world government. the end.would you like to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 14:
                    outputLabel.Text = "you leave the marine alone. the end.would you like to play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 99:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
            private void outputLabel_Click(object sender, EventArgs e)
            {

            }
        }
    }


