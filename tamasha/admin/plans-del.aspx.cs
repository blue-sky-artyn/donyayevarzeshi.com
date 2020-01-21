using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


public partial class admin_faq_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["itemId"] != null)
        {
            itemGet = Int32.Parse(Request.QueryString["itemId"]);
        }
        else
            Response.Redirect("subscription-plans.aspx");

        tblSubscriptionPlansCollection membershipPlans = new tblSubscriptionPlansCollection();
        membershipPlans.ReadList(Criteria.NewCriteria(tblSubscriptionPlans.Columns.id, CriteriaOperators.Equal, itemGet));

        membershipPlans[0].Delete();

        Response.Redirect("subscription-plans.aspx");
    }
}