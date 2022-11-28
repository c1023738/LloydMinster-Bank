using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

public class SqliteDataAccess
{
    public static List<Account> LoadCustomer(int customerID, int customerPin)
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // Open Connection and Makes sure to close the conntection to the Database (Prevents Any Errors Occuring)
        {
            var output = cnn.Query<Account>("select CustomerID,FirstName,LastName,AccountBalance,OverdraftLimit,Pin from Customer WHERE CustomerID= '"+ customerID+"' AND WHERE Pin= '" + customerPin + "'", new DynamicParameters());
            return output.ToList();
            
        }
    }

    public void SaveCustomer(Account acc)
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))// Open Connection and Makes sure to close the conntection to the Database (Prevents Any Errors Occuring)
        {

        }
    }

    private static string LoadConnectionString(string id = "Defualt")
    {
        return ConfigurationManager.ConnectionStrings[id].ConnectionString;
    }
}