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

        tblInformationGroupCollection infoGroupTbl = new tblInformationGroupCollection();
        infoGroupTbl.ReadList();

        for (int i = 0; i < infoGroupTbl.Count; i++)
        {
            //item to be shown
            itemsString += "<div class='popup panel-footer'>" +
                             (i + 1) + "- <a id=\"" + infoGroupTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + infoGroupTbl[i].id + "','')\" Class='clickable'>" + infoGroupTbl[i].infGroupTitle + "</a><br />" +
                             "</div";
        }



        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblInformationGroup infoGroupTbl = new tblInformationGroup();
        lblError.Visible = false;

        if (txtGroupName.Text.Length > 0)
        {
            infoGroupTbl.allow = "1";
            infoGroupTbl.infInsertDate = DateTime.Now.ToString("yyyy/MM/dd");
            infoGroupTbl.infGroupTitle = txtGroupName.Text;
            infoGroupTbl.infGroupDetail= txtGroupDetail.Text;
            infoGroupTbl.allow = "1";
            infoGroupTbl.Create();
            Response.Redirect("information-group.aspx");
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

        tblInformationGroupCollection infoGroupTbl = new tblInformationGroupCollection();
        infoGroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, idElement));

        if (txtTitleUpdate.Text.Trim().Length > 0)
            infoGroupTbl[0].infGroupTitle = txtTitleUpdate.Text;
        else
            lblError.Visible = true;

        infoGroupTbl[0].infGroupDetail = txtDetailUpdate.Text;

        if (lblError.Visible == false)
        {
            infoGroupTbl[0].Update();
            Response.Redirect("information-group.aspx");
        }

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblInformationGroupCollection infoGroupTbl = new tblInformationGroupCollection();
        infoGroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, idElement));

        lblTitle.Text = infoGroupTbl[0].infGroupTitle;

        txtTitleUpdate.Text = infoGroupTbl[0].infGroupTitle;
        txtDetailUpdate.Text = infoGroupTbl[0].infGroupDetail;

        ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblInformationGroupCollection infoGroupTbl = new tblInformationGroupCollection();
        infoGroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, idElement));

        infoGroupTbl[0].Delete();

        Response.Redirect("information-group.aspx");
    }
}