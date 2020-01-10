using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;

public partial class admin_faq_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["socialId"] != null)
        {
            itemGet = Int32.Parse(Request.QueryString["socialId"]);
        }
        else
            Response.Redirect("social.aspx");

        //tblSocialsCollection socialTbl = new tblSocialsCollection();
        //socialTbl.ReadList(Criteria.NewCriteria(tblSocials.Columns.id, CriteriaOperators.Equal, itemGet));

        //socialTbl[0].Delete();

        Response.Redirect("socials.aspx");
    }
}