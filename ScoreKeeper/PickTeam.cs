using ScoreKeeperData;
using ScoreKeeper.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreKeeper
{
    public partial class PickTeam : Form
    {
        public PickTeam()
        {
            InitializeComponent();

            using (GamekeeperDB d = new GamekeeperDB()) {
                Team[] all = d.Teams.ToArray();
                comboBox1.Items.AddRange(all);
                comboBox1.DisplayMember = "Name";
            }
        }

        public Team SelectedTeam { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedTeam = comboBox1.SelectedItem as Team;
            DialogResult = DialogResult.OK;
        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            TeamEditorForm tef = new TeamEditorForm();
            tef.SetTeam(new Team());
            tef.ShowDialog();
        }

        private void onChangeEnableEdit(object sender, EventArgs e)
        {
            btnEdit.Enabled = (comboBox1.SelectedItem != null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TeamEditorForm tef = new TeamEditorForm();
            tef.SetTeam((Team)comboBox1.SelectedItem);
            tef.ShowDialog();
        }
    }
}
