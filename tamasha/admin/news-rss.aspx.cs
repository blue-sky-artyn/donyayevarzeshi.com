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

        tblNewsRssCollection newsRssTbl = new tblNewsRssCollection();
        newsRssTbl.ReadList();

        for (int i = 0; i < newsRssTbl.Count; i++)
        {
            //item to be shown
            itemsString += "<div class='popup panel-footer'>";
                if (newsRssTbl[i].sourceName.Length > 3)
                    itemsString += (i + 1) + "- <a id=\"" + newsRssTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + newsRssTbl[i].id + "','')\" Class='clickable'>" + newsRssTbl[i].sourceName + "</a><br />";
                else
                    itemsString += (i + 1) + "- <a id=\"" + newsRssTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + newsRssTbl[i].id + "','')\" Class='clickable'>" + newsRssTbl[i].RssLink + "</a><br />";

            itemsString += "</div";
        }

        itemsHtml.InnerHtml = itemsString;

        #region feed news group ddl
        if (!IsPostBack)
        {
            for (int i = 0; i < newsGroupTbl.Count; i++)
            {
                ddlGroup.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
                ddlNewsGrp.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
            }
        }
        #endregion
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string dateInsert = DateTime.Now.ToString("yyyy/MM/dd");
        string timeInsert = DateTime.Now.ToString("hh:mm:ss");

        tblNewsRss rssTbl = new tblNewsRss();
        lblError.Visible = false;

        if (txtLink.Text.Length > 0)
        {
            rssTbl.allow = "1";
            rssTbl.details = "";
            rssTbl.SourceWebsite = txtLink.Text;

            rssTbl.insertDate = dateInsert;
            rssTbl.insertTime = timeInsert;
            rssTbl.idNewsGroup = Int32.Parse(ddlGroup.SelectedValue);

            rssTbl.sourceName = txtwebsite.Text;
            rssTbl.RssLink = txtLink.Text;
            rssTbl.title = txtTitle.Text;
            
            rssTbl.Create();
            Response.Redirect("news-rss.aspx");
        }
        else
        {
            lblError.Text = "*Please fill out the size dimentions first.";
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

        tblNewsRssCollection rssNewsTbl = new tblNewsRssCollection();
        rssNewsTbl.ReadList(Criteria.NewCriteria(tblNewsRss.Columns.id, CriteriaOperators.Equal, idElement));

        if (txtRssLink.Text.Trim().Length > 0)
            rssNewsTbl[0].RssLink = txtRssLink.Text;
        else
            lblError.Visible = true;

        rssNewsTbl[0].sourceName = txtRssWebsite.Text;
        rssNewsTbl[0].title = txtRssTitle.Text;
        rssNewsTbl[0].idNewsGroup = Int32.Parse(ddlNewsGrp.SelectedValue);


        if (lblError.Visible == false)
        {
            rssNewsTbl[0].Update();
            Response.Redirect("news-rss.aspx");
        }

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblNewsRssCollection newsRssTbl = new tblNewsRssCollection();
        newsRssTbl.ReadList(Criteria.NewCriteria(tblNewsGroup.Columns.id, CriteriaOperators.Equal, idElement));

        tblNewsGroupCollection newsGrpTbl = new tblNewsGroupCollection();
        newsGrpTbl.ReadList(Criteria.NewCriteria(tblNewsGroup.Columns.id, CriteriaOperators.Equal, newsRssTbl[0].idNewsGroup));

        lblTitle.Text = newsRssTbl[0].title + "(Group of:" + newsGrpTbl[0].newsGroupTitle + ")";

        txtRssTitle.Text = newsRssTbl[0].title;
        txtRssLink.Text = newsRssTbl[0].RssLink;
        txtRssWebsite.Text = newsRssTbl[0].sourceName;
        ddlNewsGrp.SelectedValue = newsRssTbl[0].idNewsGroup.ToString();

        ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int idElement = 0;
        if (Request.Cookies["idElement"] != null)
        {
            idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        }

        tblNewsRssCollection newsRssTbl = new tblNewsRssCollection();
        newsRssTbl.ReadList(Criteria.NewCriteria(tblNewsRss.Columns.id, CriteriaOperators.Equal, idElement));

        newsRssTbl[0].Delete();

        Response.Redirect("news-rss.aspx");
    }
}