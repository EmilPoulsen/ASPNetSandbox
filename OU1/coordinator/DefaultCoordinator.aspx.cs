using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class coordinator_DefaultCoordinator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BackEnd backEnd = new BackEnd();
        gridViewCrimes.DataSource = backEnd.GetCaseList();
        gridViewCrimes.DataBind();

        dropDownStatus.DataSource = backEnd.GetStatusList();
        dropDownStatus.DataBind();
        dropDownStatus.Items.Insert(0, new ListItem("Välj alla", "0"));

        dropDownDepartment.DataSource = backEnd.GetDepartmentList();
        dropDownDepartment.DataBind();
        dropDownDepartment.Items.Insert(0, new ListItem("Välj alla", "0"));
    }
}