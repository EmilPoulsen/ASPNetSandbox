using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_CrimeManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Request the ID
        String s = Request.QueryString["ID"];
        //Defend against null strings. Makes sense in a debug
        //environment.
        if (s == null)
            s = "2014-45-0001";
        //Set the case ID on top of page
        literalCaseId.Text = s;
        literalCaseId.DataBind();

        //Get the Case object from the ID
        BackEnd backEnd = new BackEnd();
        Case requestedCase = backEnd.GetCaseByID(s);
        if (requestedCase == null) {
            //TODO: throw meaningful error message.
        }
        //Collect the case in a list bind it as data source
        List<Case> caseList = new List<Case>();
        caseList.Add(requestedCase);
        formViewSpecificCrime.DataSource = caseList;
        formViewSpecificCrime.DataBind();

        //Get the empoyee list and bind
        dropDownEmployees.DataSource = backEnd.GetEmployeeList();
        dropDownEmployees.DataBind();
        dropDownEmployees.Items.Insert(0, new ListItem("Välj alla", "0"));
    }
}