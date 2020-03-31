using ScoreKeeper.Datatypes;
using ScoreKeeperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ScoreKeeper
{
    public partial class StatTrackForm : Form
    {
        public Team SelectedTeam { get; set; }
        public Game SelectedGame { get; set; }


        public StatTrackForm()
        {
            InitializeComponent();

            Refresh();
        }

        private void btnSaveClicked(object sender, EventArgs e)
        {
            GameDetailForm gd = new GameDetailForm();
            DialogResult dr = gd.ShowDialog();

           

            using (GamekeeperDB gkDB = new GamekeeperDB())
            {
                gkDB.Attach(SelectedTeam);

                SelectedGame.FinalScore = gd.GetScore();
                SelectedGame.Outcome = gd.GetOutcome();
                SelectedGame.OpposingTeamNameOrId = gd.GetOpponent();

                gkDB.Games.Add(SelectedGame);
              //  gkDB.SaveChanges();

                foreach (var controls in this.flowLayoutPanel1.Controls.OfType<Control>())
                {
                    if (controls is PlayerStatPanel)
                    {

                        PlayerGameStat pgs = ((PlayerStatPanel)controls).GetStat();
                        pgs.Game = SelectedGame;
                        gkDB.Attach(pgs.Player);
                        gkDB.PlayerGameStats.Add(pgs);
                    }
                }

                gkDB.SaveChanges();
            }

            flowLayoutPanel1.Controls.Clear();

            //XmlSerializer thing = new XmlSerializer(typeof(PlayerGameStat[]));
            //using (FileStream fs = new FileStream(@"c:\temp\game.xml" , FileMode.Create)) {
            //    thing.Serialize(fs, playerData);
            //}
        }

        private void lblPickTeam_Click(object sender, EventArgs e)
        {
            PickTeam pt = new PickTeam();
            DialogResult dr = pt.ShowDialog();
            if (dr == DialogResult.OK)
            {

                SelectedTeam = pt.SelectedTeam;
                // Set Team
                // Enable Stuff!
                lblNewGame.Enabled = true;
                lblViewGames.Enabled = true;

            }
        }

        private void lblCreateGameClicked(object sender, EventArgs e)
        {
            // Clear and reset game.
            if (SelectedTeam == null)
            {
                MessageBox.Show("Crap!  No selected team.  Please try again.");
            }
            else
            {
                CreateGame();
                PopulatePanelFromSelectedTeam();
            }

        }

        private void CreateGame()
        {
            Game g = new Game();
            g.GameDateTime = DateTime.Now;
            SelectedGame = g;
            g.Team = SelectedTeam;
            g.OpposingTeamNameOrId = "";
        }

        private void PopulatePanelFromSelectedTeam()
        {
            TeamPlayer[] allPlayers;
            using (GamekeeperDB d = new GamekeeperDB())
            {
                allPlayers = d.TeamPlayers.Where(x => x.Team == SelectedTeam).OrderBy(x => x.Number).ToArray();
            }

            if (allPlayers != null && allPlayers.Length > 0)
            {

                foreach (TeamPlayer tp in allPlayers)
                {
                    PlayerGameStat pgs = new PlayerGameStat();
                    pgs.Team = SelectedTeam;
                    pgs.Player = tp;

                    PlayerStatPanel psp = new PlayerStatPanel(pgs);
                    flowLayoutPanel1.Controls.Add(psp);
                }

            }
        }

        private void lblViewGames_Click(object sender, EventArgs e)
        {
            GameListForm glf = new GameListForm(SelectedTeam);
            glf.ShowDialog();
        }

        private void pbBtnSort_Click(object sender, EventArgs e)
        {
            IEnumerable<Control> kids = this.flowLayoutPanel1.Controls.OfType<Control>().ToArray();
            flowLayoutPanel1.Controls.Clear();

            List<PlayerStatPanel> statPanels = new List<PlayerStatPanel>();
            foreach (var c in kids)
            {
                if (c is PlayerStatPanel)
                {
                    statPanels.Add((PlayerStatPanel)c);
                }
            }

            foreach (var controls in statPanels.Where(x => x.IsIn()).OrderBy(x => x.order))
            {
                flowLayoutPanel1.Controls.Add(controls);
            }
            foreach (var controls in statPanels.Where(x => !x.IsIn()).OrderBy(x => x.order))
            {
                flowLayoutPanel1.Controls.Add(controls);
            }
        }
    }
}