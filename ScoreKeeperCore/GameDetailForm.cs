using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreKeeper.Datatypes;

namespace ScoreKeeper
{
    public partial class GameDetailForm : Form
    {
        public GameDetailForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(GameOutcome)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        internal string GetOpponent()
        {
            return tbOpponent.Text;
        }

        internal GameOutcome GetOutcome()
        {
            return (GameOutcome)Enum.Parse(typeof(GameOutcome), comboBox1.SelectedItem.ToString());

        }

        internal string GetScore()
        {
            return $"{tbOurScore.Text} - {tbOpponentScore.Text}";
        }
    }
}
