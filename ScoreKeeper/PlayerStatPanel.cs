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

        PlayerStat myStat;
        private DateTime inStart;

        public PlayerStatPanel()
        {
            InitializeComponent();
        }

        public PlayerStatPanel(PlayerStat bindingContext)
        {
            myStat = bindingContext;
            InitializeComponent();
            lblNumber.Text = "" + myStat.PlayerNumber;
            lblName.Text = myStat.Name;
        }

        bool kidIn = false;
        private void btnIn_Click(object sender, EventArgs e)
        {

            if (!kidIn)
            {
                inStart = DateTime.Now;
                btnIn.Text = "Out";
            }
            else {
                double minutes = (DateTime.Now - inStart).TotalMinutes;
                myStat.PlayedMinutes += (int)minutes;
                lblMin.Text = "" + myStat.PlayedMinutes;
                btnIn.Text = "In";
            }
            kidIn = !kidIn;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            myStat.MadeFoulShots++;
            lblFoulStat.Text = myStat.MadeFoulShots + "-" + myStat.MissedFoulShots;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myStat.MissedFoulShots++;
            lblFoulStat.Text = myStat.MadeFoulShots + "-" + myStat.MissedFoulShots;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myStat.InsideShotsMade++;
            lblInsideStat.Text = myStat.InsideShotsMade + "-" + myStat.InsideShotsMissed;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myStat.InsideShotsMissed++;
            lblInsideStat.Text = myStat.InsideShotsMade + "-" + myStat.InsideShotsMissed;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            myStat.FGMade++;
            lblFieldStat.Text = myStat.FGMade + "-" + myStat.FGMissed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myStat.FGMissed++;
            lblFieldStat.Text = myStat.FGMade + "-" + myStat.FGMissed;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myStat.ThreeMade++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myStat.ThreeMissed++;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myStat.Steals++;
            lblStealStat.Text = "" + myStat.Steals;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myStat.Rebounds++;
            lblReboundStat.Text = "" + myStat.Rebounds;
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            myStat.CommittedTurnOvers++;
            lblTOStat.Text = "" + myStat.CommittedTurnOvers;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            myStat.Assists++;
            lblAssistStat.Text = "" + myStat.Assists;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myStat.CommittFoul++;
            lblFlStat.Text = myStat.CommittFoul + "";
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            myStat.Blocks++;

        }
    }
}
