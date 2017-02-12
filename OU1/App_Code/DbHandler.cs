using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Summary description for DbHandler
/// </summary>
public class DbHandler
{
    public DbHandler()
    {
        MainTest();
    }
    private void MainTest()
    {
        MySqlConnection conn = ConnectToDbUsingConfigData();//SqlConnect(server, database, uid, password);

        string sql = "SELECT * FROM employees;";
        MySqlCommand command = new MySqlCommand();
        command.Connection = conn;
        command.CommandText = sql;

        conn.Open();
        MySqlDataReader myReader = command.ExecuteReader();

        while (myReader.Read()) {
            string fName = myReader["FName"] as string;
            string lName = myReader["LName"] as string;
            Console.WriteLine(fName + " " + lName);
        }

        myReader.Close();
        conn.Close();

        Console.ReadKey();

    }

    public MySqlConnection ConnectToDbUsingConfigData()
    {
        string strcon = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
        MySqlConnection connection = SqlConnect(strcon);
        return connection;
    }

    public static MySqlConnection SqlConnect(string server, string database, string uid, string password)
    {
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }

    public static MySqlConnection SqlConnect(string connectionString)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }
}