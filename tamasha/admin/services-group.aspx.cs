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

        tblServiceGroupCollection GroupTbl = new tblServiceGroupCollection();
        GroupTbl.ReadList();

        for (int i = 0; i < GroupTbl.Count; i++)
        {
            //item to be shown
            itemsString += "<div class='popup panel-footer'>" +
                             (i + 1) + "- <a id=\"" + GroupTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + GroupTbl[i].id + "','')\" Class='clickable'>" + GroupTbl[i].ServiceGroupTitle + "</a><br />" +
                             "</div";
        }



        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblServiceGroup GroupTbl = new tblServiceGroup();
        lblError.Visible = false;

        if (txtGroupName.Text.Length > 0)
        {
            
            GroupTbl.ServiceGroupTitle = txtGroupName.Text;
            GroupTbl.ServiceGroupDetail = txtGroupDetail.Text;

            GroupTbl.Create();
            Response.Redirect("services-group.aspx");
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

        tblServiceGroupCollection GroupTbl = new tblServiceGroupCollection();
        GroupTbl.ReadList(Criteria.NewCriteria(tblServiceGroup.Columns.id, CriteriaOperators.Equal, idElement));

        if (txtTitleUpdate.Text.Trim().Length > 0)
            GroupTbl[0].ServiceGroupTitle = txtTitleUpdate.Text;
        else
            lblError.Visible = true;

        GroupTbl[0].ServiceGroupDetail = txtDetailUpdate.Text;

        if (lblError.Visible == false)
        {
            GroupTbl[0].Update();
            Response.Redirect("services-group.aspx");
        }

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblServiceGroupCollection GroupTbl = new tblServiceGroupCollection();
        GroupTbl.ReadList(Criteria.NewCriteria(tblServiceGroup.Columns.id, CriteriaOperators.Equal, idElement));

        lblTitle.Text = GroupTbl[0].ServiceGroupTitle;

        txtTitleUpdate.Text = GroupTbl[0].ServiceGroupTitle;
        txtDetailUpdate.Text = GroupTbl[0].ServiceGroupDetail;

        ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblServiceGroupCollection GroupTbl = new tblServiceGroupCollection();
        GroupTbl.ReadList(Criteria.NewCriteria(tblServiceGroup.Columns.id, CriteriaOperators.Equal, idElement));

        GroupTbl[0].Delete();

        Response.Redirect("services-group.aspx");
    }
}