using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class coordinator_CrimeCoordinator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String s = Request.QueryString["ID"];

        if (s == null)
            s = "2014-45-0001"; //just for debugging. remember to delete..
            //return;
        literalCaseId.Text = s;
        literalCaseId.DataBind();

        BackEnd backEnd = new BackEnd();
        Case requestedCase = backEnd.GetCaseByID(s);
        if (requestedCase == null) {
            //abort
        }

        List<Case> caseList = new List<Case>();
        caseList.Add(requestedCase);

        formViewSpecificCrime.DataSource = caseList;
        formViewSpecificCrime.DataBind();

        dropDownDepartment.DataSource = backEnd.GetDepartmentList();
        dropDownDepartment.DataBind();
        dropDownDepartment.Items.Insert(0, new ListItem("Välj alla", "0"));
        
    }
}