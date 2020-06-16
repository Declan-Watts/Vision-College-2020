using CSharpClassMovingMonsters.Business;
using System;
using System.Windows.Forms;

namespace CSharpClassMovingMonsters
{
    public partial class Form1 : Form
    {
        //Create my monsters
        Monster[] monster = new Monster[4];
        Punter[] myPunter = new Punter[3]; //all our punters
        //   Punter CurrentPunter = new Howard(); //used in the code for a default punter

        //which monster wins
        private int MonsterWinner;

        public Form1()
        {
            InitializeComponent();
            LoadMonsters();
            LoadPunters();

        }

        #region Load The Monsters and Punters
        private void LoadMonsters()
        {
            //make an instance of our monster
            // myPB is Binded to pb
            monster[0] = new Monster { length = 0, myPB = pb1, name = "Agor" };
            monster[0].myPB.BackgroundImage = Resource1.Agor;
            monster[1] = new Monster { length = 0, myPB = pb2, name = "Igor" };
            monster[1].myPB.BackgroundImage = Resource1.Igor;
            monster[2] = new Monster { length = 0, myPB = pb3, name = "Ogor" };
            monster[2].myPB.BackgroundImage = Resource1.Ogor;
            monster[3] = new Monster { length = 0, myPB = pb4, name = "Ugor" };
            monster[3].myPB.BackgroundImage = Resource1.Ugor;
        }

        private void LoadPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
                //myPunter[0] which is howard is a New Howard
                myPunter[i].labelWinner = lblWinner;

            }

        }
        #endregion


        private void RunRace()
        {
            bool end = false;

            while (!end)
            {
                int distance = Form1.ActiveForm.Width - pb1.Width - 30;
                var myrand = new Random();
                for (int i = 0; i < monster.Length; i++)
                {
                    monster[i].myPB.Left += myrand.Next(1, 5);

                    if (monster[i].myPB.Left > distance)
                    {
                        MonsterWinner = i;
                        end = true;
                        this.Text = $"{monster[i].name} Wins";

                    }
                }


            }
            FindWinner();

        }

        private void FindWinner()
        {
            int[] winners = new int[0];
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].monster == MonsterWinner)
                {
                    myPunter[i].cash += myPunter[i].bet;
                    Array.Resize(ref winners, winners.Length + 1);
                    winners[winners.Length - 1] = i;
                }
                else
                {
                    myPunter[i].cash -= myPunter[i].bet;
                }
            }
            myPunter[1].labelWinner.Text = $@"{monster[MonsterWinner].name} WON!! {WinnersText(winners)}";

        }

        private string WinnersText(int[] winners)
        {
            bool first = true;
            string winnersText = "";
            for (int i = 0; i < winners.Length; i++)
            {
                if (first == true)
                {
                    winnersText += $"{myPunter[winners[i]].name} Won ${myPunter[winners[i]].bet}";
                    first = false;
                }
                else
                {
                    winnersText += $@", {myPunter[winners[i]].name} Won ${myPunter[winners[i]].bet}";
                }
            }
            return winnersText;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            RunRace();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {


        }

        private void AllRB_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton fakeRB = new RadioButton();
            fakeRB = (RadioButton)sender;

            //if (fakeRB.Checked == true)
            //{
            //look for the name of the person we have clicked on


            // }


        }

        private void BtnBets_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                myPunter[i].monster = i;
                myPunter[i].bet = myPunter[i].cash;
                myPunter[i].labelWinner.ForeColor = myPunter[i].myColor;
            }


            //CurrentPunter.Bet = (float)udBet.Value;

            //lblBettorName.Text += CurrentPunter.PunterName + " Bets " + CurrentPunter.Bet + Environment.NewLine;


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
