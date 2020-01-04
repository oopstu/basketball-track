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
    public partial class Form1 : Form
    {
        public PlayerStat[] playerData = new PlayerStat[9];

        public Form1()
        {
            playerData[0] = new PlayerStat(13, "Erik");
            playerData[1] = new PlayerStat(2, "Elijah");

            playerData[2] = new PlayerStat(23, "Kid 23");
            playerData[3] = new PlayerStat(11, "Kid 11");
            playerData[4] = new PlayerStat(15, "Kid 15");
            playerData[5] = new PlayerStat(32, "Kid 32");
            playerData[6] = new PlayerStat(3, "Kid 3");
            playerData[7] = new PlayerStat(5, "Kid 5");
            playerData[8] = new PlayerStat(14, "Kid 14");

            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[0]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[1]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[2]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[3]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[4]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[5]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[6]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[7]));
            flowLayoutPanel1.Controls.Add(new PlayerStatPanel(playerData[8]));

            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer thing = new XmlSerializer(typeof(PlayerStat[]));
            using (FileStream fs = new FileStream(@"c:\temp\game.xml" , FileMode.Create)) {
                thing.Serialize(fs, playerData);
                    }
        }
    }
}
