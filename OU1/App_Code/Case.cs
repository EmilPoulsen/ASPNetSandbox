using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Represents one Case
/// </summary>
public class Case
{
    private String _ID;
    private String _Place;
    private String _TypeOfCrime;
    private DateTime _DateTimeOfObservation;
    private String _Observation;
    private String _Info;
    private String _Action;
    private String _InformerName;
    private String _InformerPhone;
    private String _Status;
    private String _Department;
    private String _Employee;
    private String _StatusId;
    private String _EmployeeId;
    private String _DepartmentId;

    private double _Latitud;
    private double _Longitud;

    public double Longitud
    {
        get { return _Longitud; }
        set { _Longitud = value; }
    }
    


    public double Latitude
    {
        get { return _Latitud; }
        set { _Latitud = value; }
    }
    

    public Case()
    {
    }


    public String DepartmentId
    {
        get { return _DepartmentId; }
        set { _DepartmentId = value; }
    }

    public String EmployeeId
    {
        get { return _EmployeeId; }
        set { _EmployeeId = value; }
    }

    /// <summary>
    /// Properties for different attributes
    /// </summary>
    public String ID
    {
        set { _ID = value; }
        get { return _ID; }
    }

    public String StatudId
    {
        set { _StatusId = value; }
        get { return _StatusId; }
    }
    

    public String Place
    {
        set { _Place = value; }
        get { return _Place; }
    }

    public String TypeOfCrime
    {
        set { _TypeOfCrime = value; }
        get { return _TypeOfCrime; }
    }

    public string DateOfObservation
    {
        get { return _DateTimeOfObservation.ToString("yyyy-MM-dd"); }
    }

    public DateTime DateTimeOfObservation
    {
        set { _DateTimeOfObservation = value; }
        get { return _DateTimeOfObservation; }
    }

    public String Observation
    {
        set { _Observation = value; }
        get { return _Observation; }
    }

    public String Info
    {
        set { _Info = value; }
        get { return _Info; }
    }

    public String Action
    {
        set { _Action = value; }
        get { return _Action; }
    }

    public String InformerName
    {
        set { _InformerName = value; }
        get { return _InformerName; }
    }

    public String InformerPhone
    {
        set { _InformerPhone = value; }
        get { return _InformerPhone; }
    }

    public String Status
    {
        set { _Status = value; }
        get { return _Status; }
    }

    public String Department
    {
        set { _Department = value; }
        get { return _Department; }
    }

    public String Employee
    {
        set { _Employee = value; }
        get { return _Employee; }
    }

}