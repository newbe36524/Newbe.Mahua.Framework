using Dapper;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.Sqlite.Services.Impl
{
    internal class SqliteDbHelper : IDbHelper
    {
        public Task InitDbAsync()
        {
            return Task.Run(() => CreateDbIfnotExists());
        }

        public Task<DbConnection> CreateDbConnectionAsync()
        {
            return Task.Run(() => CreateDbConnectionCore());
        }

        private static DbConnection CreateDbConnectionCore()
        {
            var dbf = DbProviderFactories.GetFactory("System.Data.SQLite");
            var conn = dbf.CreateConnection();
            Debug.Assert(conn != null, nameof(conn) + " != null");
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            return conn;
        }

        private static void CreateDbIfnotExists()
        {
            var dbDirectory = (string)AppDomain.CurrentDomain.GetData("DataDirectory");
            if (!Directory.Exists(dbDirectory))
            {
                Directory.CreateDirectory(dbDirectory);
            }

            var dbfile = Path.Combine(dbDirectory, "mydb.db");
            if (!File.Exists(dbfile))
            {
                SQLiteConnection.CreateFile(dbfile);
                using (var conn = CreateDbConnectionCore())
                {
                    conn.Execute(@" CREATE TABLE MSG(
                        Id TEXT PRIMARY KEY  ,
                        Qq           TEXT    NOT NULL,
                        Message            TEXT     NOT NULL,
                        ReceivedTime       TEXT NOT NULL
                        )");
                }
            }
        }
    }
}
