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

        tblNewsGroupCollection newsGroupTbl = new tblNewsGroupCollection();
        newsGroupTbl.ReadList();

        for (int i = 0; i < newsGroupTbl.Count; i++)
        {
            //item to be shown
            itemsString += "<div class='popup panel-footer'>" +
                             (i + 1) + "- <a id=\"" + newsGroupTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + newsGroupTbl[i].id + "','')\" Class='clickable'>" + newsGroupTbl[i].newsGroupTitle + "</a><br />" +
                             "</div";
        }



        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblNewsGroup newsGroupTbl = new tblNewsGroup();
        lblError.Visible = false;

        if (txtGroupName.Text.Length > 0)
        {
            newsGroupTbl.allow = "1";
            newsGroupTbl.newsCreateDate = "";
            newsGroupTbl.newsGroupTitle = txtGroupName.Text;
            newsGroupTbl.newsGroupDetail = txtGroupDetail.Text;
            newsGroupTbl.Create();
            Response.Redirect("news-groups.aspx");
        }
        else
        {
            lblError.Text = "*Please fill out the size dimentions frist.";
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

        tblNewsGroupCollection newsGroupTbl = new tblNewsGroupCollection();
        newsGroupTbl.ReadList(Criteria.NewCriteria(tblNewsGroup.Columns.id, CriteriaOperators.Equal, idElement));

        if (txtTitleUpdate.Text.Trim().Length > 0)
            newsGroupTbl[0].newsGroupTitle = txtTitleUpdate.Text;
        else
            lblError.Visible = true;

        newsGroupTbl[0].newsGroupDetail = txtDetailUpdate.Text;

        if (lblError.Visible == false)
        {
            newsGroupTbl[0].Update();
            Response.Redirect("news-groups.aspx");
        }

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblNewsGroupCollection newsGroupTbl = new tblNewsGroupCollection();
        newsGroupTbl.ReadList(Criteria.NewCriteria(tblNewsGroup.Columns.id, CriteriaOperators.Equal, idElement));

        lblTitle.Text = newsGroupTbl[0].newsGroupTitle;

        txtTitleUpdate.Text = newsGroupTbl[0].newsGroupTitle;
        txtDetailUpdate.Text = newsGroupTbl[0].newsGroupDetail;

        ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblNewsGroupCollection newsGroupTbl = new tblNewsGroupCollection();
        newsGroupTbl.ReadList(Criteria.NewCriteria(tblNewsGroup.Columns.id, CriteriaOperators.Equal, idElement));

        newsGroupTbl[0].Delete();

        Response.Redirect("news-groups.aspx");
    }
}