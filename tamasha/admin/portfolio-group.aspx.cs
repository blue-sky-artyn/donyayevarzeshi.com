using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bluesky.artyn;
using Cruder.Core;



public partial class admin_gallery_groups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //kill cookies
        if (!IsPostBack)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "killCookie();", true);
        }



        string itemsString = string.Empty;
        string popupPageString = string.Empty;

        tblPortfolioGroupCollection portfolioGroupTbl = new tblPortfolioGroupCollection();
        portfolioGroupTbl.ReadList();

        for (int i = 0; i < portfolioGroupTbl.Count; i++)        
            itemsString += "<div class='popup panel-footer'>" +
                             (i + 1) + "- <a id=\"" + portfolioGroupTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + portfolioGroupTbl[i].id + "','')\" Class='clickable'>" + portfolioGroupTbl[i].groupTitle + "</a><br />" +
                             "</div";

        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblPortfolioGroup portfolioGroupTbl = new tblPortfolioGroup();
        lblError.Visible = false;

        if (txtGroupName.Text.Length > 0)
        {
            portfolioGroupTbl.allow = "1";
            portfolioGroupTbl.groupTitle = txtGroupName.Text;
            portfolioGroupTbl.groupDetails = txtGroupDetail.Text;
            portfolioGroupTbl.Create();
            Response.Redirect("portfolio-group.aspx");
        }
        else
        {
            lblError.Text = "*Please fill out the required field.";
            lblError.Visible = true;
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblPortfolioGroupCollection portfolioGroupTbl = new tblPortfolioGroupCollection();
        portfolioGroupTbl.ReadList(Criteria.NewCriteria(tblPortfolioGroup.Columns.id, CriteriaOperators.Equal, idElement));

        if (txtTitleUpdate.Text.Trim().Length > 0)
            portfolioGroupTbl[0].groupTitle = txtTitleUpdate.Text;
        else
            lblError.Visible = true;

        portfolioGroupTbl[0].groupDetails = txtDetailUpdate.Text;

        if (lblError.Visible == false)
        {
            portfolioGroupTbl[0].Update();
            Response.Redirect("portfolio-group.aspx");
        }

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblPortfolioGroupCollection portfolioGroupTbl = new tblPortfolioGroupCollection();
        portfolioGroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, idElement));

        lblTitle.Text = portfolioGroupTbl[0].groupTitle;

        txtTitleUpdate.Text = portfolioGroupTbl[0].groupTitle;
        txtDetailUpdate.Text = portfolioGroupTbl[0].groupDetails;

        ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblPortfolioGroupCollection portfolioGroupTbl = new tblPortfolioGroupCollection();
        portfolioGroupTbl.ReadList(Criteria.NewCriteria(tblPortfolioGroup.Columns.id, CriteriaOperators.Equal, idElement));

        portfolioGroupTbl[0].Delete();

        Response.Redirect("portfolio-group.aspx");
    }
}