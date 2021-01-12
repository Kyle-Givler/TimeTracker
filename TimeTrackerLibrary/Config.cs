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

using Microsoft.Extensions.Configuration;
using System;
using TimeTrackerLibrary.DataAccess;
using TimeTrackerLibrary.Interfaces;

namespace TimeTrackerLibrary
{

    public class Config : IConfig
    {
        public IDataAccess Connection { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public DatabaseType DBTtype { get; private set; }

        // Probably a better way, since we would have to change this here and in appsettings.json if we change the name
        public string SQLiteDBFile { get; } = "TimeTracker.db";
        // TODO implement a better solution like log4net
        public string Logfile { get; } = ".\\TimeTracker.log";

        public Config()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
        }

        public void Initialize(DatabaseType db)
        {
            if (db == DatabaseType.MSSQL)
            {
                SqlDb sql = new SqlDb(this);
                Connection = sql;
                DBTtype = db;

                return;
            }

            if (db == DatabaseType.SQLite)
            {
                SqlliteDb sql = new SqlliteDb(this);
                Connection = sql;
                DBTtype = db;

                return;
            }

            throw new ArgumentException("Data source not valid", "db");
        }

        public string ConnectionString()
        {
            if (DBTtype == DatabaseType.MSSQL)
            {
                return Configuration.GetConnectionString("MSSQL");
            }

            if(DBTtype == DatabaseType.SQLite)
            {
                return Configuration.GetConnectionString("SQLITE");
            }

            throw new InvalidOperationException("DBType is not valid");
        }
    }
}
