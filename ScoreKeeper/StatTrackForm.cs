using ScoreKeeperData;
using ScoreKeeper.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ScoreKeeper
{
    public partial class StatTrackForm : Form
    {
        public PlayerGameStat[] playerData = new PlayerGameStat[9];
        public Team SelectedTeam { get; set; }
        public Game SelectedGame { get; set; }


        public StatTrackForm()
        {
            InitializeComponent();

            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer thing = new XmlSerializer(typeof(PlayerGameStat[]));
            using (FileStream fs = new FileStream(@"c:\temp\game.xml" , FileMode.Create)) {
                thing.Serialize(fs, playerData);
                    }
        }

        private void lblPickTeam_Click(object sender, EventArgs e)
        {
            PickTeam pt = new PickTeam();
            DialogResult dr = pt.ShowDialog();
            if (dr == DialogResult.OK) {

                SelectedTeam = pt.SelectedTeam;
                // Set Team
                // Enable Stuff!
                lblNewGame.Enabled = true;
                lblViewGames.Enabled = true;
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Clear and reset game.
            if (SelectedTeam == null)
            {
                MessageBox.Show("Crap!  No selected team.  Please try again.");
            }
            else {
                CreateGame();
                PopulatePanelFromSelectedTeam();
            }

        }

        private void CreateGame()
        {
            Game g = new Game();
            g.GameDateTime = DateTime.Now;
            SelectedGame = g;
            g.OpposingTeamNameOrId = "Those good kids";
        }

        private void PopulatePanelFromSelectedTeam()
        {
            TeamPlayer[] allPlayers;
            using (GamekeeperDB d = new GamekeeperDB()) {
                allPlayers = d.TeamPlayers.Where(x => x.Team == SelectedTeam).OrderBy(x => x.Number).ToArray();
            }

            if (allPlayers != null && allPlayers.Length > 0) {

                foreach (TeamPlayer tp in allPlayers) {
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
    }
}
