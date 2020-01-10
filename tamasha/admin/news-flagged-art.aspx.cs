using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cruder.Core;
using BlueSky.Artin;

public partial class admin_news_flagged_sport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string groupTabsSrting = string.Empty , groupContentString = string.Empty;

        tblNewsGroupArtCollection newsGroupTbl = new tblNewsGroupArtCollection();
        newsGroupTbl.ReadList();

        tblNewsHitArtCollection newsHitTbl = new tblNewsHitArtCollection();

        tblNewsDetailsArtCollection newsDetTbl = new tblNewsDetailsArtCollection();

        //isolated 1st item due to active class to be set for it
        if (newsGroupTbl.Count > 0)
            groupTabsSrting = "<li class='tab-current'><a href='#section-" + newsGroupTbl[0].id + "' class='icon-shop'><span class='farsi-font-tab'>" + newsGroupTbl[0].newsGroupTitle + "</span></a></li>";

        newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsArt.Columns.idGroup, CriteriaOperators.Equal, newsGroupTbl[0].id));
        if (newsDetTbl.Count > 0)
        {
            newsHitTbl.ReadList(Criteria.NewCriteria(tblNewsHitArt.Columns.newsId, CriteriaOperators.Equal, newsDetTbl[0].id));
            groupContentString += "<section id='section-" + newsGroupTbl[0].id + "' class='content-current'>";
            for (int i = 0; i < newsDetTbl.Count; i++)
            {
                groupContentString += "<div class='fo-top'><div class='form-group'>" +
                                      "<div class='col-sm-12 ctl'>";
                if (newsHitTbl.Count > 0)
                    groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[0].id + "' class='top-news' style='display:inline'>(Checked as a top news)</span> <label> <input type='checkbox' class='newsClass' checked id='" + newsDetTbl[0].id + "'> " + newsDetTbl[0].newsDetTitle + " </label> </div>";
                else
                    groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[0].id + "' class='top-news' style='display:none'>(Checked as a top news)</span> <label> <input type='checkbox' class='newsClass' id='" + newsDetTbl[0].id + "'> " + newsDetTbl[0].newsDetTitle + " </label> </div>";

                groupContentString += "</div><div class='clearfix'></div></div></div>";
            }
            groupContentString += "</section>";
        }
        else
            groupTabsSrting = "";






        //other elements
        string tempString = string.Empty;
        for (int i = 1; i < newsGroupTbl.Count; i++)
        {
            tempString = "<li><a href='#section-" + newsGroupTbl[i].id + "' class='icon-cup'><span class='farsi-font-tab'>" + newsGroupTbl[i].newsGroupTitle + "</span></a></li>";

            newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsArt.Columns.idGroup, CriteriaOperators.Equal, newsGroupTbl[i].id));
            if (newsDetTbl.Count > 0)
            {
                groupTabsSrting += tempString;
                groupContentString += "<section id='section-" + newsGroupTbl[i].id + "' >";
                for (int j = 0; j < newsDetTbl.Count; j++)
                {
                    newsHitTbl.ReadList(Criteria.NewCriteria(tblNewsHitArt.Columns.newsId, CriteriaOperators.Equal, newsDetTbl[j].id));
                    groupContentString += "<div class='fo-top'><div class='form-group'>" +
                                                "<div class='col-sm-12 ctl'>";
                    if (newsHitTbl.Count > 0)
                        groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[j].id + "' class='top-news' style='display:inline'>(Checked as a top news)</span> <label> <input type='checkbox' class='newsClass' checked id='" + newsDetTbl[j].id + "'> " + newsDetTbl[j].newsDetTitle + " </label> </div>";
                    else
                        groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[j].id + "' class='top-news' style='display:none'>(Checked as a top news)</span> <label> <input type='checkbox' class='newsClass' id='" + newsDetTbl[j].id + "'> " + newsDetTbl[j].newsDetTitle + " </label> </div>";

                    groupContentString += "</div><div class='clearfix'></div></div></div>";
                }
                groupContentString += "</section>";
            }
        }

        //---tabsheets
        newsGroupTabHtml.InnerHtml = groupTabsSrting;

        //---contents
        newsTitleHtml.InnerHtml = groupContentString;

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        var value = "";
        if (Request.Cookies["chkId"] != null)
        {
            value = Request.Cookies["chkId"].Value;
        }
        //delete all before and add new ones
        tblNewsHitArtCollection hitNewsDelTbl = new tblNewsHitArtCollection();
        hitNewsDelTbl.ReadList();

        for (int i = 0; i < hitNewsDelTbl.Count; i++)
        {
            hitNewsDelTbl[i].Delete();
        }

        tblNewsHitArt hitNewsTbl = new tblNewsHitArt();

        for (int i = 0; i < value.Length; i++)
        {
            byte[] pass_byte = System.Text.Encoding.ASCII.GetBytes(value[i].ToString());
            if (pass_byte[0] <= 57 && pass_byte[0] >= 48)
            {
                hitNewsTbl.newsId = Convert.ToInt32(value[i].ToString());
                hitNewsTbl.ExpDate = "";
                hitNewsTbl.ExpTime = "";
                hitNewsTbl.allow = "1";

                hitNewsTbl.Create();
            }
        }    
        Response.Redirect("news-flagged-art.aspx");
    }
}