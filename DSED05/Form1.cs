using DSED05.Business;
using DSED05.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DSED05
{
    public partial class Form1 : Form
    {
        #region Global Veriables
        //Create my racers
        Racer[] racers = new Racer[4];
        //Create my Punters
        Punter[] myPunters = new Punter[3];
        //Create my Punters Balance Labels
        Label[] puntersBalanceLabels;

        //Which Racer Wins
        private int RacerWinner;

        private bool betPlaced = false;
        #endregion

        #region Form Initiate
        public Form1()
        {
            InitializeComponent();
            LoadRacers();
            LoadPunters();
            updatePuntersBalanceLabels();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Load Punters and Racers
        private void LoadPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunters[i] = Factory.GetAPunter(i);
                //myPunter[0] which is howard is a New Howard
                myPunters[i].labelWinner = lblWinner;
            }
            puntersBalanceLabels = new Label[] { lblJack, lblVaughn, lblJeremy };
        }

        private void LoadRacers()
        {
            racers[0] = new Racer { length = 0, myPB = pbRacer1, name = "CSharp" };
            racers[0].myPB.BackgroundImage = Resources.csharpLogoResize;
            racers[1] = new Racer { length = 0, myPB = pbRacer2, name = "Java" };
            racers[1].myPB.BackgroundImage = Resources.javaLogoResize;
            racers[2] = new Racer { length = 0, myPB = pbRacer3, name = "Php" };
            racers[2].myPB.BackgroundImage = Resources.phpLogoResize;
            racers[3] = new Racer { length = 0, myPB = pbRacer4, name = "Python" };
            racers[3].myPB.BackgroundImage = Resources.pythonLogoResize;
            for (int i = 0; i < racers.Length; i++)
            {
                cbxRacers.Items.Add(racers[i].name);
            }
        }
        #endregion

        #region Resetting the Race
        private void ResetRace()
        {
            int start = pbRaceTrack.Left;
            for (int i = 0; i < racers.Length; i++)
            {
                racers[i].myPB.Left = start;
            }
            for (int i = 0; i < myPunters.Length; i++)
            {
                myPunters[i].bet = 0;
            }
        }
        #endregion

        #region Running the Race
        private void RunRace()
        {
            bool end = false;

            while (!end)
            {
                int distance = pbRaceTrack.Width - (pbRacer1.Width);
                var myrand = new Random();
                for (int i = 0; i < racers.Length; i++)
                {
                    racers[i].myPB.Left += myrand.Next(1, 5);

                    if (racers[i].myPB.Left > distance)
                    {
                        RacerWinner = i;
                        end = true;
                        betPlaced = false;
                        lbxEvents.Items.Add($"{racers[i].name} Wins!");

                    }
                }
            }
            FindWinner();
        }

        #region Race Finished
        private void FindWinner()
        {
            int[] winners = new int[0];
            int[] loosers = new int[0];
            for (int i = 0; i < 3; i++)
            {
                if (myPunters[i].racer == RacerWinner)
                {
                    myPunters[i].cash += myPunters[i].bet;
                    Array.Resize(ref winners, winners.Length + 1);
                    winners[winners.Length - 1] = i;
                }
                else
                {
                    myPunters[i].cash -= myPunters[i].bet;
                    Array.Resize(ref loosers, loosers.Length + 1);
                    loosers[loosers.Length - 1] = i;
                }
            }
            // Label Winner
            string[] winnersTextArr = WinnersText(winners, loosers);
            foreach (string text in winnersTextArr)
            {
                lbxEvents.Items.Add(text);
            }
            updatePuntersBalanceLabels();
        }

        private string[] WinnersText(int[] winners, int[] loosers)
        {
            string[] winnersText = new string[3];
            for (int i = 0; i < winners.Length; i++)
            {
                winnersText[i] = $"{myPunters[winners[i]].name} Won {myPunters[winners[i]].bet}";
            }
            for (int i = 0; i < loosers.Length; i++)
            {
                winnersText[i + winners.Length] = $"{myPunters[loosers[i]].name} Lost {myPunters[loosers[i]].bet}";
            }
            return winnersText;
        }
        #endregion
        #endregion

        #region Bettings

        private void updatePuntersBalanceLabels()
        {
            for (int i = 0; i < myPunters.Length; i++)
            {
                puntersBalanceLabels[i].Text = $"${myPunters[i].cash}";
            }
        }

        private void placeBet()
        {
            var currentPunter = puntersRADBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (currentPunter != null)
            {
                if (betAmount.Value.ToString() != "0")
                {
                    if (cbxRacers.SelectedItem != null)
                    {
                        for (int i = 0; i < myPunters.Length; i++)
                        {
                            if (myPunters[i].name == currentPunter.Text)
                            {
                                if (myPunters[i].cash >= float.Parse(betAmount.Value.ToString()))
                                {
                                    if (myPunters[i].bet == 0)
                                    {
                                        myPunters[i].bet = float.Parse(betAmount.Value.ToString());
                                        for (int x = 0; x < racers.Length; x++)
                                        {
                                            if (racers[x].name == cbxRacers.SelectedItem.ToString())
                                            {
                                                myPunters[i].racer = x;
                                            }
                                        }
                                        lbxEvents.Items.Add($"{myPunters[i].name} has placed a bet of {myPunters[i].bet} on {racers[myPunters[i].racer].name}");
                                    }
                                    else
                                    {
                                        MessageBox.Show("This punter has already placed their bet");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Sorry the bet is to high");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a Racer");

                    }
                }
                else
                {
                    MessageBox.Show("Please choose a bet Amount");

                }

            }
            else
            {
                MessageBox.Show("Please select a Punter before placing your bet!");
            }
        }

        private bool checkBetsPlaced()
        {
            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].bet == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Form Controls
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbRacer1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (checkBetsPlaced())
            {
                RunRace();
            }
            else
            {
                MessageBox.Show("Please make sure all bets are placed");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetRace();
        }
        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            placeBet();
        }
        #endregion


    }
}
