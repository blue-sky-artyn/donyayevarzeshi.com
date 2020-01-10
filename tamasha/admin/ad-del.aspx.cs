using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using BlueSky.Artin;


public partial class admin_faq_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["adId"] != null)
        {
            itemGet = Int32.Parse(Request.QueryString["adId"]);
        }
        else
            Response.Redirect("ad.aspx");

        tblAdCollection adTbl = new tblAdCollection();
        adTbl.ReadList(Criteria.NewCriteria(tblAd.Columns.id, CriteriaOperators.Equal, itemGet));

        adTbl[0].Delete();

        Response.Redirect("ad.aspx");
    }
}