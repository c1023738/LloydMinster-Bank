using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

public class SqliteDataAccess
{
    public SQLiteConnection myConnection;

    public SqliteDataAccess()
    {
        myConnection = new SQLiteConnection("Data Source=UserDatabase.db");


    }
    public void OpenConnection()
    {
        if (myConnection.State != System.Data.ConnectionState.Open)
        {
            myConnection.Open();
        }
    }
    public void CloseConnection()
    {
        if (myConnection.State != System.Data.ConnectionState.Closed)
        {
            myConnection.Close();
        }
    }
}

}