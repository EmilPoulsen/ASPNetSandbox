using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_DefaultManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create instance of backend, get case list and bind data
        BackEnd backEnd = new BackEnd();
        gridViewCrimes.DataSource = backEnd.GetCaseList();
        gridViewCrimes.DataBind();

        //Get status list, bind it and make "välj alla" first 
        //default option.
        dropDownStatus.DataSource = backEnd.GetStatusList();
        dropDownStatus.DataBind();
        dropDownStatus.Items.Insert(0, new ListItem("Välj alla", "0"));

        //Get employeelist, bind data and make "välj alla" first
        //default option.
        dropDownInvestigator.DataSource = backEnd.GetEmployeeList();
        dropDownInvestigator.DataBind();
        dropDownInvestigator.Items.Insert(0, new ListItem("Välj alla", "0"));
    }
}