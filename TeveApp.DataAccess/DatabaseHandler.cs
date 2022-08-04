using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeveApp.DataAccess
{
    public class DatabaseHandler
    {
        private static DatabaseHandler instace;
        public static DatabaseHandler Instance
        {
            get
            {
                if (instace == null)
                    return new DatabaseHandler();

                return instace;
            }
        }

        public SQLiteConnection ConnectionUserDataBase { get; set; }

        public void CreateDataBase(string path)
        {
            SQLiteConnectionString connection = new SQLiteConnectionString(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache | SQLiteOpenFlags.FullMutex, false, "teveApp22x!", postKeyAction: c =>
            {
                c.Execute("PRAGMA cipher_compatibility = 3");
            });

            ConnectionUserDataBase = new SQLiteConnection(connection);
        }

        public void CreateTable(List<Type> tables)
        {
            ConnectionUserDataBase.CreateTables(CreateFlags.None, tables.ToArray());
        }
    }
}
