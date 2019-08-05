using System;
using System.Windows.Forms;
using SwimmersRace.Business;
using SwimmersRace.Business.allPunters;

namespace SwimmersRace
{
    public partial class Form1 : Form
    {
        private Swimmer[] Swimmer = new Swimmer[4];
        private Punter[] Punter = new Punter[4];

        //winner of the race
        private string raceWinner;

        Punter CurrentPunter = new Zeph();
        Swimmer ChosenSwimmer = new Swimmer();



        public Form1()
        {
            InitializeComponent();
            LoadSwimmers();
            LoadPunters();
        }

        #region Load Swimmers and Punters

        public void LoadSwimmers()
        {
            Swimmer[0] = new Swimmer { Length = 0, myPB = pbDuck, Name = "Duck" };
            //assigns image to picture box
            Swimmer[0].myPB.BackgroundImage = Resource1.duck;

            Swimmer[1] = new Swimmer { Length = 0, myPB = pbFish, Name = "Fish" };
            //assigns image to picture box
            Swimmer[1].myPB.BackgroundImage = Resource1.fish;

            Swimmer[2] = new Swimmer { Length = 0, myPB = pbChild, Name = "Child" };
            //assigns image to picture box
            Swimmer[2].myPB.BackgroundImage = Resource1.child;

            Swimmer[3] = new Swimmer { Length = 0, myPB = pbMan, Name = "Man" };
            //assigns image to picture box
            Swimmer[3].myPB.BackgroundImage = Resource1.man;
        }

        private void LoadPunters()
        {
            for (int i = 0; i < 4; i++)
            {
                Punter[i] = Factory.GetAPunter(i);
                Punter[i].labelWinner = lblWinner;
            }
        }

        #endregion

        #region Buttons

        private void BtnStart_Click(object sender, EventArgs e)
        {
            RunRace();
        }

        #region RunRace
        private void RunRace()
        {
            bool end = false;

            var myRand = new Random();

            //resets swimmers' positions every time "start race" is clicked
            for (int i = 0; i < 4; i++)
            {
                Swimmer[i].myPB.Left = 10;
            }

            while (end != true)
            {
                for (int i = 0; i < 4; i++)
                {
                    //sets random speed for the swimmers
                    Swimmer[i].myPB.Left += myRand.Next(1, 8);

                    Application.DoEvents();

                    //if the swimmer's location is greater than the form, minus the width of pb then stop
                    if (Swimmer[i].myPB.Left > Form1.ActiveForm.Width - Swimmer[i].myPB.Width - 20)
                    {
                        end = true; //loop until end = true

                        //Swimmer that won the race
                        raceWinner = Swimmer[i].Name;

                        FindTheWinner();

                    }
                }
            }
        }
        #endregion

        private void FindTheWinner()
        {
            lblWinner.Text = string.Empty;

            for (int j = 0; j < 4; j++)
            {
                if (Punter[j].Swimmer == raceWinner)
                {
                    //adds 2x the bet of punter to the punter's cash
                    Punter[j].Cash += Punter[j].Bet * 2;

                    Punter[j].labelWinner.Text += Punter[j].PunterName + " and " + raceWinner + " won  and now has " + Punter[j].Cash + "." + Environment.NewLine;

                    //updates cash display for current punter
                    switch (CurrentPunter.PunterName)
                    {
                        case "Zeph":
                            CurrentPunter = Punter[0];
                            lblZephCash.Text = " has $" + Punter[j].Cash;
                            lblSarahCash.Text = "";
                            lblMaeCash.Text = "";
                            lblFeyCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbZeph.Enabled = false;
                            }
                            else
                            {
                                rbZeph.Enabled = true;
                            }

                            break;

                        case "Sarah":
                            CurrentPunter = Punter[1];
                            lblSarahCash.Text = " has $" + Punter[j].Cash;
                            lblZephCash.Text = "";
                            lblMaeCash.Text = "";
                            lblFeyCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbSarah.Enabled = false;
                            }
                            else
                            {
                                rbSarah.Enabled = true;
                            }

                            break;

                        case "Mae":
                            CurrentPunter = Punter[2];
                            lblMaeCash.Text = " has $" + Punter[j].Cash;
                            lblZephCash.Text = "";
                            lblSarahCash.Text = "";
                            lblFeyCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbMae.Enabled = false;
                            }
                            else
                            {
                                rbMae.Enabled = true;
                            }

                            break;

                        case "Fey":
                            CurrentPunter = Punter[3];
                            lblFeyCash.Text = " has $" + Punter[j].Cash;
                            lblZephCash.Text = "";
                            lblSarahCash.Text = "";
                            lblMaeCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbFey.Enabled = false;
                            }
                            else
                            {
                                rbFey.Enabled = true;
                            }

                            break;
                    }


                }
                else
                {
                    Punter[j].labelWinner.Text += " " + Punter[j].PunterName + " lost and now has " + Punter[j].Cash + "." + Environment.NewLine;

                    //updates cash display for current punter
                    switch (CurrentPunter.PunterName)
                    {
                        case "Zeph":
                            CurrentPunter = Punter[0];
                            lblZephCash.Text = " has $" + Punter[j].Cash;
                            lblSarahCash.Text = "";
                            lblMaeCash.Text = "";
                            lblFeyCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbZeph.Enabled = false;
                            }
                            else
                            {
                                rbZeph.Enabled = true;
                            }

                            break;

                        case "Sarah":
                            CurrentPunter = Punter[1];
                            lblSarahCash.Text = " has $" + Punter[j].Cash;
                            lblZephCash.Text = "";
                            lblMaeCash.Text = "";
                            lblFeyCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbSarah.Enabled = false;
                            }
                            else
                            {
                                rbSarah.Enabled = true;
                            }

                            break;

                        case "Mae":
                            CurrentPunter = Punter[2];
                            lblMaeCash.Text = " has $" + Punter[j].Cash;
                            lblZephCash.Text = "";
                            lblSarahCash.Text = "";
                            lblFeyCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbMae.Enabled = false;
                            }
                            else
                            {
                                rbMae.Enabled = true;
                            }

                            break;

                        case "Fey":
                            CurrentPunter = Punter[3];
                            lblFeyCash.Text = " has $" + Punter[j].Cash;
                            lblZephCash.Text = "";
                            lblSarahCash.Text = "";
                            lblMaeCash.Text = "";

                            if (Punter[j].Cash <= 0)
                            {
                                rbFey.Enabled = false;
                            }
                            else
                            {
                                rbFey.Enabled = true;
                            }

                            break;
                    }
                }
            }

            //resets punters' chosen swimmers for the next bet and race
            for (int i = 0; i < 4; i++)
            {
                Punter[i].Swimmer = "";
            }

            //game ends when all punters run out of cash
            if (Punter[0].Cash <= 0 && Punter[1].Cash <= 0 && Punter[2].Cash <= 0 && Punter[3].Cash <= 0)
            {
                MessageBox.Show("GAME OVER! ALL PLAYERS HAVE NO CASH LEFT!");
            }

            //updates punter's maximum bet
            udBets.Maximum = (decimal)CurrentPunter.Cash;
        }


        #region Buttons
        private void BtnReset_Click(object sender, EventArgs e)
        {
            //resets swimmers' location when "reset" is clicked
            for (int i = 0; i < 4; i++)
            {
                Swimmer[i].myPB.Left = 10;
            }

            Punter[0].Cash = 50;
            Punter[1].Cash = 50;
            Punter[2].Cash = 50;
            Punter[3].Cash = 50;

            switch (CurrentPunter.PunterName)
            {
                case "Zeph":
                    CurrentPunter = Punter[0];
                    lblZephCash.Text = " has $" + Punter[0].Cash;
                    lblSarahCash.Text = "";
                    lblMaeCash.Text = "";
                    lblFeyCash.Text = "";
                    break;

                case "Sarah":
                    CurrentPunter = Punter[1];
                    lblSarahCash.Text = " has $" + Punter[1].Cash;
                    lblZephCash.Text = "";
                    lblMaeCash.Text = "";
                    lblFeyCash.Text = "";
                    break;

                case "Mae":
                    CurrentPunter = Punter[2];
                    lblMaeCash.Text = " has $" + Punter[2].Cash;
                    lblZephCash.Text = "";
                    lblSarahCash.Text = "";
                    lblFeyCash.Text = "";
                    break;

                case "Fey":
                    CurrentPunter = Punter[3];
                    lblFeyCash.Text = " has $" + Punter[3].Cash;
                    lblZephCash.Text = "";
                    lblSarahCash.Text = "";
                    lblMaeCash.Text = "";
                    break;
            }

            //clears all items in the list box
            lbxBets.Items.Clear();
            lblWinner.Text = "Results: ";

            //enables all disabled radio buttons upon game reset
            rbZeph.Enabled = true;
            rbSarah.Enabled = true;
            rbMae.Enabled = true;
            rbFey.Enabled = true;
        }

        private void PunterRb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton PunterRB = new RadioButton();
            PunterRB = (RadioButton)sender;

            if (PunterRB.Checked == true)
            {
                this.Text = PunterRB.Text;

                //look for the punter name
                switch (PunterRB.Text)
                {
                    //instatiate that punter

                    case "Zeph":
                        CurrentPunter = Punter[0];
                        lblZephCash.Text = " has $" + CurrentPunter.Cash;
                        lblSarahCash.Text = "";
                        lblMaeCash.Text = "";
                        lblFeyCash.Text = "";
                        break;

                    case "Sarah":
                        CurrentPunter = Punter[1];
                        lblSarahCash.Text = " has $" + CurrentPunter.Cash;
                        lblZephCash.Text = "";
                        lblMaeCash.Text = "";
                        lblFeyCash.Text = "";
                        break;

                    case "Mae":
                        CurrentPunter = Punter[2];
                        lblMaeCash.Text = " has $" + CurrentPunter.Cash;
                        lblZephCash.Text = "";
                        lblSarahCash.Text = "";
                        lblFeyCash.Text = "";
                        break;

                    case "Fey":
                        CurrentPunter = Punter[3];
                        lblFeyCash.Text = " has $" + CurrentPunter.Cash;
                        lblZephCash.Text = "";
                        lblSarahCash.Text = "";
                        lblMaeCash.Text = "";
                        break;
                }

                udBets.Maximum = (decimal)CurrentPunter.Cash;
            }
        }

        private void SwimmerRb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton SwimmerRB = new RadioButton();
            SwimmerRB = (RadioButton)sender;

            if (SwimmerRB.Checked == true)
            {
                this.Text = SwimmerRB.Text;

                switch (SwimmerRB.Text)
                {
                    case "Duck":
                        ChosenSwimmer = Swimmer[0];
                        break;

                    case "Fish":
                        ChosenSwimmer = Swimmer[1];
                        break;

                    case "Child":
                        ChosenSwimmer = Swimmer[2];
                        break;

                    case "Man":
                        ChosenSwimmer = Swimmer[3];
                        break;

                }
            }
        }

        private void BtnPlaceBet_Click(object sender, EventArgs e)
        {
            //takes value from udBets
            CurrentPunter.Bet = (float)udBets.Value;
            udBets.Maximum = (decimal)CurrentPunter.Cash;
            udBets.Value = (decimal)CurrentPunter.Cash;

            //assigns chosen swimmer to the current punter's swimmer
            CurrentPunter.Swimmer = ChosenSwimmer.Name;

            //shows events in the listbox
            lbxBets.Items.Add(CurrentPunter.PunterName + " Bets " + " $" + CurrentPunter.Bet + " on " + ChosenSwimmer.Name + "." + Environment.NewLine);

            //minus bet from punter's current cash
            CurrentPunter.Cash -= CurrentPunter.Bet;

            //updates cash display for current punter
            switch (CurrentPunter.PunterName)
            {
                case "Zeph":
                    CurrentPunter = Punter[0];
                    lblZephCash.Text = " has $" + CurrentPunter.Cash;
                    lblSarahCash.Text = "";
                    lblMaeCash.Text = "";
                    lblFeyCash.Text = "";

                    if (CurrentPunter.Cash <= 0)
                    {
                        rbZeph.Enabled = false;
                    }
                    else
                    {
                        rbZeph.Enabled = true;
                    }

                    break;

                case "Sarah":
                    CurrentPunter = Punter[1];
                    lblSarahCash.Text = " has $" + CurrentPunter.Cash;
                    lblZephCash.Text = "";
                    lblMaeCash.Text = "";
                    lblFeyCash.Text = "";

                    if (CurrentPunter.Cash <= 0)
                    {
                        rbSarah.Enabled = false;
                    }
                    else
                    {
                        rbSarah.Enabled = true;
                    }

                    break;

                case "Mae":
                    CurrentPunter = Punter[2];
                    lblMaeCash.Text = " has $" + CurrentPunter.Cash;
                    lblZephCash.Text = "";
                    lblSarahCash.Text = "";
                    lblFeyCash.Text = "";

                    if (CurrentPunter.Cash <= 0)
                    {
                        rbMae.Enabled = false;
                    }
                    else
                    {
                        rbMae.Enabled = true;
                    }

                    break;

                case "Fey":
                    CurrentPunter = Punter[3];
                    lblFeyCash.Text = " has $" + CurrentPunter.Cash;
                    lblZephCash.Text = "";
                    lblSarahCash.Text = "";
                    lblMaeCash.Text = "";

                    if (CurrentPunter.Cash <= 0)
                    {
                        rbFey.Enabled = false;
                    }
                    else
                    {
                        rbFey.Enabled = true;
                    }

                    break;
            }

            #endregion
        }
    }
}
#endregion