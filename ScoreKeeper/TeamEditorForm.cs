using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreKeeperData;
using ScoreKeeper.Datatypes;

namespace ScoreKeeper
{
    public partial class TeamEditorForm : Form
    {
        public TeamEditorForm()
        {
            InitializeComponent();
           // dataGridView1.DataSource = viewData;
        }

        private Team myBoundTeam;
        private BindingList<TeamPlayer> viewData = null;
        internal void SetTeam(Team team)
        {
            myBoundTeam = team;
            newPlayers.Clear();

            using (GamekeeperDB db = new GamekeeperDB()) {
                TeamPlayer[] tx = (TeamPlayer[])db.TeamPlayers.Where(x => x.Team == team).ToArray();

                viewData = new BindingList<TeamPlayer>(tx);
                dataGridView1.DataSource = viewData;
            }
            tbTeamName.Text = team.Name;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeamPlayer tp = new TeamPlayer();
            viewData.Add(tp);
            newPlayers.Add(tp);
        }

        List<TeamPlayer> newPlayers = new List<TeamPlayer>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            myBoundTeam.Name = tbTeamName.Text;

            using (GamekeeperDB gDB = new GamekeeperDB()) {

                if (gDB.Teams.Contains(myBoundTeam) == false)
                {
                    gDB.Teams.Add(myBoundTeam);

                }
                else {
                    gDB.Update(myBoundTeam);
                }

                if (newPlayers.Count > 0) {
                    gDB.TeamPlayers.AddRange(newPlayers);
                }

                foreach (TeamPlayer tp in viewData) {
                    tp.Team = myBoundTeam;
                }

                gDB.UpdateRange(viewData);

                gDB.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
