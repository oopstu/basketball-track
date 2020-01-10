using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreKeeper.Datatypes;

namespace ScoreKeeper
{
    public partial class PlayerStatPanel : UserControl
    {

        PlayerGameStat myStat;
        public int order { get; set; }

        public PlayerGameStat GetStat() {

            myStat.PlayedMinutes = (int)(secondsPlayed / 60);
            return myStat; 
        
        }

        public PlayerStatPanel()
        {
            InitializeComponent();
        }

        public PlayerStatPanel(PlayerGameStat bindingContext)
        {
            InitializeComponent();

            myStat = bindingContext;
            lblName.Text = bindingContext.Player.Name;
            lblNumber.Text = ""+ bindingContext.Player.Number;

            order = bindingContext.PlayerNumber;

            t.Interval = 1000;
            t.Tick += T_Tick;
            ResetButtonColors();
          
        }

        long secondsPlayed = 0;
        private void T_Tick(object sender, EventArgs e)
        {
            secondsPlayed++;
            lblMin.Text = secondsPlayed/60 + ":" + secondsPlayed%60;
        }

        private void ResetButtonColors()
        {
            Color good = Color.DarkBlue;
            Color bad = Color.Magenta;
            if (cbCorrect.Checked) {
                good = Color.OrangeRed;
                bad = Color.Red;
            }

            btnBlock.ForeColor = good;
            btn3Made.ForeColor = good;
            btnFGMade.ForeColor = good;
            btnInsideMade.ForeColor = good;
            btnAssist.ForeColor = good;
            btnBlock.ForeColor = good;
            btnRebound.ForeColor = good;
            btnFoulShotMade.ForeColor = good;
            btnSteals.ForeColor = good;

            btnCommitFoul.ForeColor = bad;
            btnCommitTurnOver.ForeColor = bad;
            btn3Miss.ForeColor = bad;
            btnFGMiss.ForeColor = bad;
            btnInsideMiss.ForeColor = bad;
            btnFoulShotMiss.ForeColor = bad;

        }

        Timer t = new Timer();
        bool kidIn = false;
        private void btnIn_Click(object sender, EventArgs e)
        {

            if (!kidIn)
            {
                t.Start();
                btnIn.Text = "Out";
                btnIn.BackColor = Color.LightGreen;
                lblMin.BackColor = Color.LightGreen;
            }
            else {
                t.Stop();
                
                myStat.PlayedMinutes += (int)secondsPlayed / 60;
                
                btnIn.Text = "In";
                btnIn.BackColor = Color.Pink;
                lblMin.BackColor = Color.Pink;
            }
            kidIn = !kidIn;
        }


        private void click_MadeFoul(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.MadeFoulShots--;
            }
            else
            {
                myStat.MadeFoulShots++;
            }

            lblFoulStat.Text = myStat.GetFoulSummary();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.MissedFoulShots--;
            }
            else
            {
                myStat.MissedFoulShots++;
            }
            lblFoulStat.Text = myStat.GetFoulSummary();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.InsideShotsMade--;
            }
            else
            {
                myStat.InsideShotsMade++;
            }
            lblInsideStat.Text = myStat.GetInsideSummary();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.InsideShotsMissed--;
            }
            else
            {
                myStat.InsideShotsMissed++;
            }
            lblInsideStat.Text = myStat.GetInsideSummary();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.FGMade--;
            }
            else
            {
                myStat.FGMade++;
            }
            lblFieldStat.Text = myStat.GetFieldGoalSummary();
        }

        internal bool IsIn()
        {
            return t.Enabled;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.FGMissed--;
            }
            else
            {
                myStat.FGMissed++;
            }
            lblFieldStat.Text = myStat.GetFieldGoalSummary();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.ThreeMade--;
            }
            else
            {
                myStat.ThreeMade++;
            }
            lbl3PtStat.Text = myStat.GetThreePtSummary();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.ThreeMissed--;
            }
            else
            {
                myStat.ThreeMissed++;
            }
            lbl3PtStat.Text = myStat.GetThreePtSummary();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Steals--;
            }
            else
            {
                myStat.Steals++;
            }
            lblStealStat.Text = "" + myStat.Steals;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Rebounds--;
            }
            else
            {
                myStat.Rebounds++;
            }
            lblReboundStat.Text = "" + myStat.Rebounds;
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.CommittedTurnOvers--;
            }
            else
            {
                myStat.CommittedTurnOvers++;
            }
            lblTOStat.Text = "" + myStat.CommittedTurnOvers;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Assists--;
            }
            else
            {
                myStat.Assists++;
            }
            lblAssistStat.Text = "" + myStat.Assists;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.CommittFoul--;
            }
            else
            {
                myStat.CommittFoul++;
            }
            lblFoulAgainstStat.Text = myStat.CommittFoul + "";
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Blocks--;
            }
            else
            {
                myStat.Blocks++;
            }
            lblBlockStat.Text = "" + myStat.Blocks;
        }

        private void cbCorrect_CheckedChanged(object sender, EventArgs e)
        {
            ResetButtonColors();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            btnIn_Click(sender, e);
        }
    }
}