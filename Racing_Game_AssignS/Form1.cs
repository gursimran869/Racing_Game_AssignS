using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game_AssignS
{
    public partial class Form1 : Form
    {
        //global variable 
        int selectedRat = 0;
        int sahilBudget = 100, dashmeshBudget = 90, higorBudget = 110;

        int winnerRat = 0;

        // object of the local class to work
        Ground ground_instance = new Ground();
        calculateBudget budget_instane = new calculateBudget();


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sahil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setBet_Click(object sender, EventArgs e)
        {
            //check the player is selected or not 
            if (Sahil.Checked == false && Dashmesh.Checked == false && Higor.Checked == false)
            {
                MessageBox.Show("Must Select any Player ");
            }
            else {
                if (Sahil.Checked == true && selectedRat > 0) {
                    //if we choose the player then we must verify the amount for the bet
                    if (Convert.ToInt32(nmBet.Value)<50 && Convert.ToInt32(nmBet.Value) < sahilBudget) {
                        //after filling the amount disolay the catalog to show which player choose how much amount 
                        lblSahil.Text = "Sahil choosed " + selectedRat + " and bet Amount " + nmBet.Value;
                        Sahil.Checked = false;
                        Rat1.Checked = false;
                        Rat2.Checked = false;
                        Rat3.Checked = false;
                        Rat4.Checked = false;
                        nmBet.Value = 1;

                    }
                    else {
                        MessageBox.Show("Bet Amount must be less than the 50 or budget ");
                    }
                } else if (Dashmesh.Checked == true && selectedRat > 0) {
                    //if we choose the player then we must verify the amount for the bet
                    if (Convert.ToInt32(nmBet.Value) < 50 && Convert.ToInt32(nmBet.Value) < dashmeshBudget)
                    {
                        //after filling the amount disolay the catalog to show which player choose how much amount 
                        lblDashmesh.Text = "Dashmesh choosed " + selectedRat + " and bet Amount " + nmBet.Value;
                        Dashmesh.Checked = false;
                        Rat1.Checked = false;
                        Rat2.Checked = false;
                        Rat3.Checked = false;
                        Rat4.Checked = false;
                        nmBet.Value = 1;

                    }
                    else
                    {
                        MessageBox.Show("Bet Amount must be less than the 50 or budget ");
                    }

                } else if (Higor.Checked == true && selectedRat > 0) {
                    //if we choose the player then we must verify the amount for the bet
                    if (Convert.ToInt32(nmBet.Value) < 50 && Convert.ToInt32(nmBet.Value) < higorBudget)
                    {
                        //after filling the amount disolay the catalog to show which player choose how much amount 
                        lblHigor.Text = "Higor choosed " + selectedRat + " and bet Amount " + nmBet.Value;

                        Higor.Checked = false;
                        Rat1.Checked = false;
                        Rat2.Checked = false;
                        Rat3.Checked = false;
                        Rat4.Checked = false;
                        nmBet.Value = 1;

                    }
                    else
                    {
                        MessageBox.Show("Bet Amount must be less than the 50 or budget ");
                    }
                }
                else {
                    MessageBox.Show("Must select the rat for the race if you want to start the bet ");
                }
                    
            }

            selectedRat = 0;
        }

        private void Rat1_CheckedChanged(object sender, EventArgs e)
        {
            //if we chose the first rat 
            if (Rat1.Checked == true) {
                selectedRat = 1;
            }
        }

        private void Rat2_CheckedChanged(object sender, EventArgs e)
        {
            //if we chose the second rat 
            if (Rat2.Checked == true)
            {
                selectedRat = 2;
            }
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            //after all setting start the timer to start the race to move the rats
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //move the rat from one position to another using jump method 
            PB_Rat1.Left = PB_Rat1.Left+ ground_instance.jump();
            Pbrat2.Left = Pbrat2.Left + ground_instance.jump();
            PBrat3.Left = PBrat3.Left + ground_instance.jump();
            PBrat4.Left = PBrat4.Left + ground_instance.jump();

            //when anyone of the player reach at the finish point stop the game and declare the recult 
            //anounce the winner rat and declare the budget 
            if (PB_Rat1.Left > 690)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Rat 1 win the Game ");
                winnerRat = 1;
                resultAnnounce();
            }

            if (Pbrat2.Left > 690)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Rat 2 win the Game ");
                winnerRat = 2;
                resultAnnounce();
            }
            if (PBrat3.Left > 690)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Rat 3 win the Game ");
                winnerRat = 3;
                resultAnnounce();

            }
            if (PBrat4.Left > 690)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Rat 4 win the Game ");
                winnerRat = 4;
                resultAnnounce();
            }



        }

        public void resultAnnounce() {
            
            //if the player  play the game then find he is the winner or loser of the game 
            if (lblSahil.Text.Contains("Sahil")) {
                String[] sahilData = lblSahil.Text.Split(' ');
                sahilBudget = budget_instane.BudgetCal(Convert.ToInt32(sahilData[2]), Convert.ToInt32(sahilData[6]),sahilBudget,winnerRat);
                Sahil.Text = "Sahil has "+sahilBudget+" Dollar";
                lblSahil.Text = "PRINT MESSAGE HERE ANY";
            }

            if (lblDashmesh.Text.Contains("Dashmesh"))
            {
                String[] DashmeshData = lblDashmesh.Text.Split(' ');
                dashmeshBudget = budget_instane.BudgetCal(Convert.ToInt32(DashmeshData[2]), Convert.ToInt32(DashmeshData[6]), dashmeshBudget, winnerRat);
                Dashmesh.Text = "Dashmesh has " + dashmeshBudget + " Dollar";
                lblDashmesh.Text = "PRINT MESSAGE HERE ANY ";
            }

            if (lblDashmesh.Text.Contains("Higor"))
            {
                String[] HigorData = lblHigor.Text.Split(' ');
                higorBudget = budget_instane.BudgetCal(Convert.ToInt32(HigorData[2]), Convert.ToInt32(HigorData[6]), higorBudget, winnerRat);
                Higor.Text = "Higor has " + dashmeshBudget + " Dollar";
                lblHigor.Text = "PRINT MESSAGE HERE ANY ";
            }


            PB_Rat1.Left = 0;
            Pbrat2.Left = 0;
            PBrat3.Left = 0;
            PBrat4.Left = 0;

        }

        private void Rat3_CheckedChanged(object sender, EventArgs e)
        {
            //if we chose the third rat 
            if (Rat3.Checked == true)
            {
                selectedRat = 3;
            }
        }

        private void Rat4_CheckedChanged(object sender, EventArgs e)
        {
            //if we chose the forth rat 
            if (Rat4.Checked == true)
            {
                selectedRat = 4;
            }
        }
    }
}
