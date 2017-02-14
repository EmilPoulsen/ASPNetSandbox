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
        //MainTest();
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
        }

        myReader.Close();
        conn.Close();
    }

    private MySqlDataReader GetSqlDataReader(string sql, MySqlConnection conn)
    {
        MySqlCommand command = new MySqlCommand();
        command.Connection = conn;
        command.CommandText = sql;
        conn.Open();
        MySqlDataReader myReader = command.ExecuteReader();
        return myReader;
    }

    public List<Case> GetCrimeData()
    {
        MySqlConnection conn = ConnectToDbUsingConfigData();//SqlConnect(server, database, uid, password);
        string sql = "SELECT * FROM crime;";
        var myReader = GetSqlDataReader(sql, conn);
        List<Case> caseList = new List<Case>();

        while (myReader.Read()) {
            Case crimeCase = new Case();
            crimeCase.ID = myReader["CId"].ToString();
            crimeCase.Place = myReader["Place"].ToString();
            crimeCase.Latitude = (double) myReader["Latitud"];
            crimeCase.Longitud = (double)myReader["Longitud"];
            crimeCase.TypeOfCrime = myReader["TypeOfCrime"].ToString();
            crimeCase.DateTimeOfObservation = (DateTime) myReader["DateOfObservation"];
            crimeCase.Observation = myReader["Observation"].ToString();//"Restaurang hade för högt ljud på så man kunde inte sova";
            crimeCase.Info = myReader["Info"].ToString();//"Bullermätning har gjorts. Håller sig inom riktvärden.";
            crimeCase.Action = myReader["Action"].ToString();//"Meddelat restaurangen att tänka på ljudet i fortsättningen";
            crimeCase.InformerName = myReader["InformerName"].ToString();//= "Roland Jönsson";
            crimeCase.InformerPhone = myReader["InformerPhone"].ToString();//= "0432-532 22 55";
            //crimeCase.Status = myReader["Place"].ToString();//"Klar";
            crimeCase.StatudId = myReader["SId"].ToString();//"Klar";
            //crimeCase.Department = myReader["Place"].ToString();//"Miljö och Hälsoskydd";
            crimeCase.DepartmentId = myReader["DId"].ToString();
            //crimeCase.Employee = myReader["Place"].ToString();//"Martin Kvist";
            crimeCase.EmployeeId = myReader["EId"].ToString();//"Martin Kvist";
            caseList.Add(crimeCase);
        }

        myReader.Close();
        conn.Close();
        return caseList;
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