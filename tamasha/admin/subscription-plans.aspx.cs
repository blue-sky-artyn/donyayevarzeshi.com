using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_need_to_know : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string planString = string.Empty;
        tblSubscriptionPlansCollection subscriptionPlansTbl = new tblSubscriptionPlansCollection();
        subscriptionPlansTbl.ReadList();

        for (int i = 0; i < subscriptionPlansTbl.Count; i++)
        {
            planString += "<div class='mediabox'><i class='fa fa-grav' aria-hidden='true'></i>" +
                         "<h3>" + subscriptionPlansTbl[i].planName + "</h3>" +
                         "<p>" + subscriptionPlansTbl[i].planDetails + "</p>" +
                         "<div><span class=elements-in-page'>From:  " + subscriptionPlansTbl[i].planStartDate + "</span><span class='elements-in-page'>To:  " + subscriptionPlansTbl[i].planEndDate + "</span></div>" +
                         "<div><span>Capacity: " + subscriptionPlansTbl[i].capacity + "</span></div>" +
                         "<a href='plans-delete.aspx?itemId=" + subscriptionPlansTbl[i].id + "'>Delete</a></div>";
        }

        faqHtml.InnerHtml = planString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblSubscriptionPlans subscriptionPlanTbl = new tblSubscriptionPlans();

        if (txtTitle.Text.Trim().Length > 0)
        {
            subscriptionPlanTbl.planName = txtTitle.Text;
            subscriptionPlanTbl.planDetails = txtDetail.Text;
            if (txtStart.Text.Length > 0)
                subscriptionPlanTbl.planStartDate = Convert.ToInt32(txtStart.Text);
            subscriptionPlanTbl.planStartTime = "";

            if (txtEnd.Text.Length > 0)
                subscriptionPlanTbl.planEndDate = Convert.ToInt32(txtEnd.Text);
            subscriptionPlanTbl.planEndTime = "";

            subscriptionPlanTbl.planDetails = txtDetail.Text;
            
            if (txtPrice.Text.Length > 0)
                subscriptionPlanTbl.price = Convert.ToInt32(txtPrice.Text);
            
            if (txtCapacity.Text.Length > 0)
                subscriptionPlanTbl.capacity = Convert.ToInt32(txtCapacity.Text);
            
            subscriptionPlanTbl.specification = "";
            subscriptionPlanTbl.allow = "1";
            subscriptionPlanTbl.Create();

            Response.Redirect("subscription-plans.aspx");
        }
        else
            lblError.Text = "* Please enter required fields.";


    }
}