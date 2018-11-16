using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SingUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["type"] == null)
        {
            Response.Redirect("PreSingup.aspx");
        }
        var type = Request["type"];
        var ImgType = "";
        if (type == "p")
        {
            ImgType= "<img src='img/family.png' class='rounded mx-auto d-block'  width='250' height='250'/>";
        }
        else if (type == "b")
        {
            ImgType = "<img src='img/babysitter.png' class='rounded mx-auto d-block'  width='250' height='250'/>";
        }
        LtlType.Text = ImgType;
    }

    protected void BtnLog_Click(object sender, EventArgs e)
    {
        Session["UserN"] = "1";
        if (Request["type"] == "p")
        {
            Response.Redirect("SingUpForChild.aspx");
        }
    }
}