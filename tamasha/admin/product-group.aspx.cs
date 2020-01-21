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

        tblProductGroupCollection productGroupTbl = new tblProductGroupCollection();
        productGroupTbl.ReadList();

        for (int i = 0; i < productGroupTbl.Count; i++)        
            itemsString += "<div class='popup panel-footer'>" +
                             (i + 1) + "- <a id=\"" + productGroupTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + productGroupTbl[i].id + "','')\" Class='clickable'>" + productGroupTbl[i].groupName + "</a><br />" +
                             "</div";

        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblProductGroup productGroupTbl = new tblProductGroup();
        lblError.Visible = false;

        if (txtGroupName.Text.Length > 0)
        {
            productGroupTbl.allow = "1";
            productGroupTbl.groupPicAddr = "";
            productGroupTbl.groupPicName = "";
            productGroupTbl.groupName = txtGroupName.Text;
            productGroupTbl.groupDetail = txtGroupDetail.Text;
            productGroupTbl.allow = "1";
            productGroupTbl.Create();
            Response.Redirect("product-group.aspx");
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

        tblProductGroupCollection productGroupTbl = new tblProductGroupCollection();
        productGroupTbl.ReadList(Criteria.NewCriteria(tblProductGroup.Columns.id, CriteriaOperators.Equal, idElement));

        if (txtTitleUpdate.Text.Trim().Length > 0)
            productGroupTbl[0].groupName = txtTitleUpdate.Text;
        else
            lblError.Visible = true;

        productGroupTbl[0].groupDetail = txtDetailUpdate.Text;

        if (lblError.Visible == false)
        {
            productGroupTbl[0].Update();
            Response.Redirect("product-group.aspx");
        }

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblProductGroupCollection productGroupTbl = new tblProductGroupCollection();
        productGroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, idElement));

        lblTitle.Text = productGroupTbl[0].groupName;

        txtTitleUpdate.Text = productGroupTbl[0].groupName;
        txtDetailUpdate.Text = productGroupTbl[0].groupDetail;

        ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblProductGroupCollection productGroupTbl = new tblProductGroupCollection();
        productGroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, idElement));

        productGroupTbl[0].Delete();

        Response.Redirect("product-group.aspx");
    }
}