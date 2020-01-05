using Commons.Collections;
using Intro;
using Microsoft.EntityFrameworkCore;
using NVelocity;
using NVelocity.App;
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

namespace ScoreKeeper
{
    public partial class GameListForm : Form
    {
        public GameListForm()
        {
            InitializeComponent();
        }

        public GameListForm(Team teamForGames) : this()
        {
            using (GamekeeperDB d = new GamekeeperDB()) {
                Game[] allGamesForTeam = d.Games.Where(x => x.Team == teamForGames).ToArray();
                dataGridView1.DataSource = allGamesForTeam;
            }

        }

        private void btnGenReportForSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0] != null)
            {
                using (GamekeeperDB gDB = new GamekeeperDB())
                {
                    Game selectedGame = gDB.Games.FirstOrDefault(x => x.GameId == (int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show("Generating Reports for Game: " + selectedGame.GameDateTime);

                    // Get All Player Stats for Game.  
                    
                    PlayerGameStat[] pgs = gDB.PlayerGameStats.Where(x => x.Game == selectedGame).OrderBy(u => u.PlayerNumber).Include(a => a.Player).ToArray();

                    Directory.CreateDirectory("Reports");

                    foreach (PlayerGameStat eachPlayerStat in pgs)
                    {
                        // Now we have all player game stats.  Now we need all player game stats for team?
                        VelocityEngine velocity = new VelocityEngine();
                        ExtendedProperties props = new ExtendedProperties();
                        velocity.Init(props);
                        var writer = new StringWriter();
                        string template = File.ReadAllText(Path.Combine("..", "..", "ReportTemplates", "PlayerReport.vm"));

                        PlayerGameStat[] allStatsForSeason = gDB.PlayerGameStats.Where(x => x.Player == eachPlayerStat.Player).OrderBy(y => y.GameDate).ToArray();

                        PlayerGameStat seasonHolder = CreateSeasonSummary(allStatsForSeason);

                        VelocityContext context = new VelocityContext();
                        context.Put("PlayerStats", eachPlayerStat);
                        context.Put("Player", eachPlayerStat.Player);
                        context.Put("AllPlayers", pgs);
                        context.Put("SeasonStats", seasonHolder);
                        context.Put("AllGames", allStatsForSeason);
                        context.Put("GameData", selectedGame);
                        velocity.Evaluate(context, writer, null, template);
                                             
                        File.WriteAllText(Path.Combine("Reports", eachPlayerStat.Player.Name + ".html"), writer.GetStringBuilder().ToString());
                    }
                }
            }
        }

        private PlayerGameStat CreateSeasonSummary(PlayerGameStat[] allStatsForSeason)
        {
            PlayerGameStat summary = new PlayerGameStat();

            if (allStatsForSeason != null && allStatsForSeason.Length > 0) {
                foreach (PlayerGameStat eachStat in allStatsForSeason) {
                    summary.Assists += eachStat.Assists;
                    summary.Blocks += eachStat.Blocks;
                    summary.CommittedTurnOvers += eachStat.CommittedTurnOvers;
                    summary.CommittFoul += eachStat.CommittFoul;
                    summary.FGMade += eachStat.FGMade;
                    summary.FGMissed += eachStat.FGMissed;
                    summary.InsideShotsMade += eachStat.InsideShotsMade;
                    summary.InsideShotsMissed += eachStat.InsideShotsMissed;
                    summary.MadeFoulShots += eachStat.MadeFoulShots;
                    summary.MissedFoulShots += eachStat.MissedFoulShots;
                    summary.PlayedMinutes += eachStat.PlayedMinutes;
                    summary.Rebounds += eachStat.Rebounds;
                    summary.Steals += eachStat.Steals;
                    summary.ThreeMade += eachStat.ThreeMade;
                    summary.ThreeMissed += eachStat.ThreeMissed;
                    
                }
            }

            return summary;
        }
    }
}
