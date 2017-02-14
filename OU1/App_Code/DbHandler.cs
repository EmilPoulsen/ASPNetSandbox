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
    private Dictionary<string, string> _statusIdMap;
    private Dictionary<string, string> _departmentIdMap;
    private List<Employee> _employees;

    public DbHandler()
    {
        
        CreateStatusIdMap();
        CreateDepartmentIdMap();
        CreateEmployeesFromDb();
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
            string sId = myReader["SId"].ToString();//"Klar";
            crimeCase.Status = GetStatusFromStatusId(sId);
            //crimeCase.Department = myReader["Place"].ToString();//"Miljö och Hälsoskydd";
            string dId = myReader["DId"].ToString();
            crimeCase.Department = GetDepartmentFromDepartmentId(dId);
            //crimeCase.Employee = myReader["Place"].ToString();//"Martin Kvist";
            string eId = myReader["EId"].ToString();//"Martin Kvist";
            crimeCase.Employee = GetEmployeeNameById(eId);
            caseList.Add(crimeCase);
        }

        myReader.Close();
        conn.Close();
        return caseList;
    }

    private string GetStatusFromStatusId(string id)
    {
        if (_statusIdMap.ContainsKey(id))
            return _statusIdMap[id];
        else {
            return "unknown";
        }
    }

    private string GetEmployeeNameById(string id)
    {
        var name = from e in _employees
                   where e.EId.Equals(id)
                   select e;

        if (name.Count() == 1)
            return name.ElementAt(0).FName + " " + name.ElementAt(0).LName;
        else
            return "Unknown";
    }

    private string GetDepartmentFromDepartmentId(string id)
    {
        if (_departmentIdMap.ContainsKey(id))
            return _departmentIdMap[id];
        else {
            return "unknown";
        }
    }

    private void CreateDepartmentIdMap()
    {
        _departmentIdMap = new Dictionary<string, string>();
        MySqlConnection conn = ConnectToDbUsingConfigData();//SqlConnect(server, database, uid, password);
        string sql = "SELECT * FROM departments;";
        var myReader = GetSqlDataReader(sql, conn);

        while (myReader.Read()) {
            string key = myReader["DId"].ToString();
            string val = myReader["DName"].ToString();
            _departmentIdMap.Add(key, val);
        }

        myReader.Close();
        conn.Close();
    }

    private void CreateStatusIdMap()
    {
        _statusIdMap = new Dictionary<string, string>();
        MySqlConnection conn = ConnectToDbUsingConfigData();//SqlConnect(server, database, uid, password);
        string sql = "SELECT * FROM status;";
        var myReader = GetSqlDataReader(sql, conn);

        while (myReader.Read()) {
            string key = myReader["SId"].ToString();
            string val = myReader["Status"].ToString();
            _statusIdMap.Add(key, val);
        }
        myReader.Close();
        conn.Close();
    }

    private void CreateEmployeesFromDb()
    {
        _employees = new List<Employee>();
        MySqlConnection conn = ConnectToDbUsingConfigData();//SqlConnect(server, database, uid, password);
        string sql = "SELECT * FROM employees;";
        var myReader = GetSqlDataReader(sql, conn);

        while (myReader.Read()) {
            Employee employee = new Employee();
            employee.EId = myReader["EId"].ToString();
            employee.FName = myReader["FName"].ToString();
            employee.LName = myReader["LName"].ToString();
            employee.Role = myReader["Role"].ToString();
            employee.DId = myReader["DId"].ToString();
            _employees.Add(employee);
        }

        myReader.Close();
        conn.Close();
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