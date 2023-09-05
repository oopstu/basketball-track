using ScoreKeeper.Datatypes;

namespace ScoreKeeper
{
    public partial class PlayerStatPanel : UserControl
    {

        PlayerGameStat myStat;
        public int order { get; set; }

        public PlayerGameStat GetStat()
        {

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
            lblNumber.Text = "" + bindingContext.Player.Number;

            order = bindingContext.Player.Number;
            bindingContext.PlayerNumber = order;

            t.Interval = 1000;
            t.Tick += T_Tick;
            ResetButtonColors();

        }

        long secondsPlayed = 0;
        private void T_Tick(object sender, EventArgs e)
        {
            secondsPlayed++;
            lblMin.Text = secondsPlayed / 60 + ":" + secondsPlayed % 60;
        }

        private void ResetButtonColors()
        {
            Color good = Color.DarkBlue;
            Color bad = Color.Magenta;
            if (cbCorrect.Checked)
            {
                good = Color.OrangeRed;
                bad = Color.Red;
            }

            btnSave.ForeColor = good;
            btnPassMade.ForeColor = good;
            btnShotTaken.ForeColor = good;
            btnAssist.ForeColor = good;
            btnSave.ForeColor = good;
            btnGoalMade.ForeColor = good;
            btnSteals.ForeColor = good;

            btnCommitFoul.ForeColor = bad;
            btnCommitTurnOver.ForeColor = bad;




        }

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
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
            else
            {
                t.Stop();

                myStat.PlayedMinutes += (int)secondsPlayed / 60;

                btnIn.Text = "In";
                btnIn.BackColor = Color.Pink;
                lblMin.BackColor = Color.Pink;
            }
            kidIn = !kidIn;
        }


        private void click_MadeGoal(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.GoalsMade--;
            }
            else
            {
                myStat.GoalsMade++;
            }
            btnGoalMade.Text = "Goals\r\n" + myStat.GoalsMade;
        }

        private void click_ShotTaken(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.ShotsOnGoal--;
            }
            else
            {
                myStat.ShotsOnGoal++;
            }
            btnShotTaken.Text = "Shots\r\n" + myStat.ShotsOnGoal;

        }

        private void click_PassMade(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.PassesMade--;
            }
            else
            {
                myStat.PassesMade++;
            }

            btnPassMade.Text = $"Passes\r\n{myStat.PassesMade}";
        }

        internal bool IsIn()
        {
            return t.Enabled;
        }

        private void click_Turnover(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.CommittedTurnOvers--;
            }
            else
            {
                myStat.CommittedTurnOvers++;
            }

            btnCommitTurnOver.Text = $"Turnovers\r\n{myStat.CommittedTurnOvers}";

        }

        private void click_FoulCommit(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.CommittFoul--;
            }
            else
            {
                myStat.CommittFoul++;
            }
            btnCommitFoul.Text = $"Fouls\r\n{myStat.CommittFoul}";
        }

        private void click_GoalSaveMade(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.SavesMade--;
            }
            else
            {
                myStat.SavesMade++;
            }

            btnSave.Text = $"Saves\r\n{myStat.SavesMade}";
        }

        private void click_AssistMade(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Assists--;
            }
            else
            {
                myStat.Assists++;
            }

            btnSave.Text = $"Assist\r\n{myStat.Assists}";
        }
        
        private void click_StealMade(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Steals--;
            }
            else
            {
                myStat.Steals++;
            }

            btnSave.Text = $"Steals\r\n{myStat.Steals}";
        }
        
        private void cbCorrect_CheckedChanged(object sender, EventArgs e)
        {
            ResetButtonColors();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            btnIn_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.ListenGeneral--;
            }
            else
            {
                myStat.ListenGeneral++;
            }

            button1.Text = $"Gen\r\n{myStat.ListenGeneral}";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.DefensivePressure--;
            }
            else
            {
                myStat.DefensivePressure++;
            }

            btnDefPress.Text = $"Defense\r\n{myStat.DefensivePressure}";
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            if (cbCorrect.Checked)
            {
                myStat.Sportsmanship--;
            }
            else
            {
                myStat.Sportsmanship++;
            }

            btnSports.Text = $"Sportsman\r\n{myStat.Sportsmanship}";

        }


    }
}