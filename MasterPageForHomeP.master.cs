using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageForHomeP : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var srt = " ";
        string srt2 = "";
        if (Session["UserN"] != null)//nani
        {
           
            srt += "<li class='nav-item'><a href='Login.aspx' class='btn btn-outline-light'>you'r in</a></li>";
            LtlTlog.Text = srt;
            srt2 += "<li class='nav-item'><a href ='PreSingUp.aspx' class='btn btn-outline-light'>Yes!!</a></li>";
            LtlTlog2.Text = srt2;
        }
        else
        {
            srt += "<li class='nav-item'><a href='Login.aspx' class='btn btn-outline-light'>כניסה</a></li>";
            LtlTlog.Text = srt;
            srt2 += "<li class='nav-item'><a href ='PreSingUp.aspx' class='btn btn-outline-light'>הרשמה</a></li>";
            LtlTlog2.Text = srt2;
        }

    }
}
