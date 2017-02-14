using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    private string _eId;
    private string _fName;
    private string _lName;
    private string _role;
    private string _dId;

    public Employee()
    {

    }

    public string DId
    {
        get { return _dId; }
        set { _dId = value; }
    }
    
    public string Role
    {
        get { return _role; }
        set { _role = value; }
    }
    

    public string LName
    {
        get { return _lName; }
        set { _lName = value; }
    }
    

    public string FName
    {
        get { return _fName; }
        set { _fName = value; }
    }
    

    public string EId
    {
        get { return _eId; }
        set { _eId = value; }
    }
    




}