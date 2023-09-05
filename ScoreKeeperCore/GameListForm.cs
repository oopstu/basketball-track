using Commons.Collections;
using ScoreKeeperData;
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
                    Game selectedGame = gDB.Games.Include(a => a.Team).FirstOrDefault(x => x.GameId == (int)(dataGridView1.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show("Generating Reports for Game: " + selectedGame.GameDateTime);

                    // Get All Player Stats for Game.  
                    Team mainTeam = selectedGame.Team;

                    PlayerGameStat[] pgs = gDB.PlayerGameStats.Where(x => x.Game == selectedGame).OrderBy(u => u.PlayerNumber).Include(a => a.Player).ToArray();
                    IEnumerable<PlayerGameStat> allPlayersAllSeason = gDB.PlayerGameStats.Where(x => x.Team == selectedGame.Team).Include(a => a.Player).OrderBy(a => a.PlayerNumber);
                    PlayerGameStat[] allAll = Summarize(allPlayersAllSeason);

                    try
                    {
                        Directory.Delete("Reports");
                    }
                    catch { }
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
                        //context.Put("AllGames", allStatsForSeason);
                        context.Put("GameData", selectedGame);
                        context.Put("AllPlayersAllSeason", allAll);
                        velocity.Evaluate(context, writer, null, template);
                                             
                        File.WriteAllText(Path.Combine("Reports", eachPlayerStat.Player.Name + ".html"), writer.GetStringBuilder().ToString());
                    }
                }
            }
        }

        private PlayerGameStat[] Summarize(IEnumerable<PlayerGameStat> allStatsForSeason)
        {
            List<PlayerGameStat> all = new List<PlayerGameStat>();

            IEnumerable<IGrouping<TeamPlayer, PlayerGameStat>> players = allStatsForSeason.GroupBy(x => x.Player);
            foreach (IEnumerable<PlayerGameStat> tp in players) {
                all.Add(CreateSeasonSummary(tp));
            }

            return all.ToArray();
        }

        private PlayerGameStat CreateSeasonSummary(IEnumerable<PlayerGameStat> allStatsForSeason)
        {
            PlayerGameStat summary = new PlayerGameStat();
            
            if (allStatsForSeason != null && allStatsForSeason.Count() > 0) {
                foreach (PlayerGameStat eachStat in allStatsForSeason) {
                    summary.Player = eachStat.Player;
                    summary.PlayerNumber = eachStat.PlayerNumber;
                    summary.Assists += eachStat.Assists;
            
                    summary.CommittedTurnOvers += eachStat.CommittedTurnOvers;
                    summary.CommittFoul += eachStat.CommittFoul;
                    summary.SavesMade += eachStat.SavesMade;
                    summary.GoalsMade += eachStat.GoalsMade;
                    summary.ShotsOnGoal += eachStat.ShotsOnGoal;
                    summary.PassesMade += eachStat.PassesMade;
                    summary.PlayedMinutes += eachStat.PlayedMinutes;
                    summary.Steals += eachStat.Steals;
                }
            }

            return summary;
        }
    }
}
