/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Windows.Forms;
using TimeTrackerLibrary;
using Microsoft.Extensions.DependencyInjection;
using TimeTrackerLibrary.Interfaces;
using System.IO;
using TimeTrackerLibrary.DataAccess;
using System.Threading.Tasks;

namespace TimeTrackerUI
{
    static class Program
    {
        public static DatabaseType dbType = DatabaseType.SQLite;
        public static readonly IServiceProvider Container = new ContainerBuilder().Build(dbType);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            var config = Container.GetRequiredService<IConfig>();
            config.Initialize(dbType);

            await CreateSQLiteDatabase(config, Container.GetRequiredService<IDataAccess>());

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(Container.GetRequiredService<frmMain>());
        }

        private static async Task CreateSQLiteDatabase(IConfig config, IDataAccess dataAccess)
        {
            SqlliteDb db = dataAccess as SqlliteDb;

            if (dbType == DatabaseType.SQLite)
            {
                if(db == null)
                {
                    throw new ArgumentException("db is null", "dataAccess");
                }

                if ( !File.Exists(config.SQLiteDBFile) )
                {
                    File.AppendAllText(config.Logfile, $"{DateTimeOffset.Now}: Database {config.SQLiteDBFile} does not exist. Creating.");

                    await db.CreateDatabase();
                }
            }
            else
            {
                return;
            }
        }
    }
}
