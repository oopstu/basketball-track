using ScoreKeeperData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ScoreKeeper.Datatypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ScoreKeeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // RelationalDatabaseCreator databaseCreator = 
            //     (RelationalDatabaseCreator) new GamekeeperDB().Database.GetService<IDatabaseCreator>();
            
            // databaseCreator.CreateTables();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StatTrackForm());
        }
    }
}
