using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// Responsible for handling creation of differens lists
/// </summary>
public class BackEnd
{
    private List<Case> _CaseList = null;
    private List<String> _EmployeeList = null;
    private List<String> _DepartmentList = null;
    private List<String> _StatusList = null;

    /// <summary> Constructor where initiating of the differens lists are done</summary>
    public BackEnd()
    {
        _CaseList = new List<Case>();

        Case case1 = new Case();
        case1.ID = "2014-45-0001";
        case1.Place = "Skogslunden vid Jensens gård";
        case1.TypeOfCrime = "Sopor";
        case1.DateTimeOfObservation = new DateTime(2014, 04, 24);
        case1.Observation = "Anmälaren var på promenad i skogslunden när hon upptäckte soporna";
        case1.Info = "Undersökning har gjorts och bland soporna hittades bl.a ett brev till Gösta Olsson";
        case1.Action = "Brev har skickats till Gösta Olsson om soporna och anmälan har gjorts till polisen 2014-05-10";
        case1.InformerName = "Ada Bengtsson";
        case1.InformerPhone = "0432-5545522";
        case1.Status = "Klar";
        case1.Department = "Renhållning och Avfall";
        case1.Employee = "Susanne Fred";

        _CaseList.Add(case1);

        Case case2 = new Case();
        case2.ID = "2014-45-0002";
        case2.Place = "Småstadsjön";
        case2.TypeOfCrime = "Oljeutsläpp";
        case2.DateTimeOfObservation = new DateTime(2014, 04, 29);
        case2.Observation = "Jag såg en oljefläck på vattnet när jag var där för att fiska";
        case2.Info = "Undersökning gjorts på plats, ingen fläck har hittats";
        case2.InformerName = "Bengt Svensson";
        case2.InformerPhone = "0432-5152255";
        case2.Status = "Ingen åtgärd";
        case2.Department = "Natur och Skogsvård";
        case2.Employee = "Oskar Ivarsson";

        _CaseList.Add(case2);

        Case case3 = new Case();
        case3.ID = "2014-45-0003";
        case3.Place = "Ödehuset";
        case3.TypeOfCrime = "Skrot";
        case3.DateTimeOfObservation = new DateTime(2014, 05, 02);
        case3.Observation = "Anmälaren körde förbi ödehuset och upptäcket ett antal bilar och annat skrot";
        case3.Info = "Undersökning har gjorts och bilder tagits";
        case3.InformerName = "Olle Pettersson";
        case3.InformerPhone = "0432-5255522";
        case3.Status = "Påbörjad";
        case3.Department = "Miljö och Hälsoskydd";
        case3.Employee = "Lena Larsson";

        _CaseList.Add(case3);

        Case case4 = new Case();
        case4.ID = "2014-45-0004";
        case4.Place = "Restaurang Krögaren";
        case4.TypeOfCrime = "Buller";
        case4.DateTimeOfObservation = new DateTime(2014, 06, 04);
        case4.Observation = "Restaurang hade för högt ljud på så man kunde inte sova";
        case4.Info = "Bullermätning har gjorts. Håller sig inom riktvärden.";
        case4.Action = "Meddelat restaurangen att tänka på ljudet i fortsättningen";
        case4.InformerName = "Roland Jönsson";
        case4.InformerPhone = "0432-532 22 55";
        case4.Status = "Klar";
        case4.Department = "Miljö och Hälsoskydd";
        case4.Employee = "Martin Kvist";

        _CaseList.Add(case4);

        Case case5 = new Case();
        case5.ID = "2014-45-0005";
        case5.Place = "Torget";
        case5.TypeOfCrime = "Klotter";
        case5.DateTimeOfObservation = new DateTime(2014, 07, 10);
        case5.Observation = "Samtliga skräpkorgar och bänkar är nedklottrade";
        case5.Info = "Ingen ytterligare information är inlagd.";
        case5.Action = "Inga händelser är ännu inlagda";
        case5.InformerName = "Peter Svensson";
        case5.InformerPhone = "0432-5322555";
        case5.Status = "Inrapporterad";
        case5.Department = "Ej tillsatt";
        case5.Employee = "Ej tillsatt";

        _CaseList.Add(case5);

        //Skapar en lista med anställda, obs! endast fiktiv lista, tills databasen kopplas in
        _EmployeeList = new List<String>();
        _EmployeeList.Add("Martin Kvist");
        _EmployeeList.Add("Lena Larsson");
        _EmployeeList.Add("Oskar Ivarsson");
        _EmployeeList.Add("Susanne Fred");

        //Skapar en lista med enheter, obs! endast fiktiv lista, tills databasen kopplas in
        _DepartmentList = new List<String>();
        _DepartmentList.Add("Småstads Kommun");
        _DepartmentList.Add("IT-avdelningen");
        _DepartmentList.Add("Lek och Skoj");
        _DepartmentList.Add("Miljöskydd");

        //Skapar en lista med status, obs! endast fiktiv lista, tills databasen kopplas in
        _StatusList = new List<String>();
        _StatusList.Add("Rapporterad");
        _StatusList.Add("Ingen åtgärd");
        _StatusList.Add("Startad");
        _StatusList.Add("Färdig");

    }

    /// <summary>Method to return the whole Case List</summary>
    /// <returns>The Case List</returns>
    public IEnumerable<Case> GetCaseList()
    {
        //TODO
        throw new NotImplementedException();
    }

    /// <summary>Method that gets one specific Case</summary>
    /// <param name="productID">The id of the Case</param>
    /// <returns>The specific Case</returns>
    public Case GetCaseByID(string caseID)
    {
        //TODO
        throw new NotImplementedException();
    }

    /// <summary>Method to return the whole Employee List</summary>
    /// <returns>The Employee List</returns>
    public IEnumerable<String> GetEmployeeList()
    {
        //TODO
        throw new NotImplementedException();
    }

    /// <summary>Method to return the whole Department List</summary>
    /// <returns>The Department List</returns>
    public IEnumerable<String> GetDepartmentList()
    {
        //TODO
        throw new NotImplementedException();
    }

    /// <summary>Method to return the whole Status List</summary>
    /// <returns>The Status List</returns>
    public IEnumerable<String> GetStatusList()
    {
        //TODO
        throw new NotImplementedException();
    }
}