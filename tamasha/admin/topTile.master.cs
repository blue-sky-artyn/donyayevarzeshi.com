using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_topTile : System.Web.UI.MasterPage
{
    public tblAdmin CurrentMember
    {
        get
        {
            if (Session["tblUser"] == null)
            {
                return null;
            }
            else return ((tblAdmin)Session["tblUser"]);

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (CurrentMember == null)
        //{
        //    Response.Redirect("../login.aspx");
        //}
        //else
        //    userNameHtml.InnerHtml = "Username: " + Session["tblUser"];
    }
}
