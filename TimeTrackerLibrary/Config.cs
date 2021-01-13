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
        public DatabaseType DBType { get; private set; }
        public string SQLiteDBFile { get; private set; } = null;

        // TODO implement a better solution like log4net
        public string Logfile { get; } = ".\\TimeTracker.log";

        public Config()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
        }

        public void Initialize()
        {
            var databaseSetting = Configuration.GetSection("DatabaseType").Value;

            if (databaseSetting == "SQLite")
            {
                SQLiteDBFile = Configuration.GetSection("SQLiteSettings").GetSection("DatabaseFile").Value;

                DBType = DatabaseType.SQLite;
                SqlliteDb sql = new SqlliteDb(this);
                Connection = sql;

                return;
            } else if (databaseSetting == "MSSQL")
            {
                DBType = DatabaseType.MSSQL;
                SqlDb sql = new SqlDb(this);
                Connection = sql;

                return;
            }
            else
            {
                throw new InvalidOperationException("DatabaseType must be MSSQL or SQLite");
            }
        }

        public string ConnectionString()
        {
            if (DBType == DatabaseType.MSSQL)
            {
                return Configuration.GetConnectionString("MSSQL");
            }

            if(DBType == DatabaseType.SQLite)
            {
                //return Configuration.GetConnectionString("SQLite");
                return $"Data Source={SQLiteDBFile};Version=3;";
            }

            throw new InvalidOperationException("DBType is not valid");
        }
    }
}
