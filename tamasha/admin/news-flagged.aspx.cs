using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cruder.Core;
using bluesky.artyn;

public partial class admin_news_flagged_sport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string groupTabsSrting = string.Empty , groupContentString = string.Empty;

        if (!IsPostBack)
        {

            tblNewsGroupCollection newsGroupTbl = new tblNewsGroupCollection();
            newsGroupTbl.ReadList();

            tblNewsHitCollection newsHitTbl = new tblNewsHitCollection();

            tblNewsDetailsCollection newsDetTbl = new tblNewsDetailsCollection();

            //isolated 1st item due to actived class to be set for it
            if (newsGroupTbl.Count > 0)
                groupTabsSrting = "<li class='tab-current'><a href='#section-" + newsGroupTbl[0].id + "' class='icon-shop'><span class='farsi-font-tab'>" + newsGroupTbl[0].newsGroupTitle + "</span></a></li>";

            newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.idGroup, CriteriaOperators.Equal, newsGroupTbl[0].id));
            if (newsDetTbl.Count > 0)
            {
                groupContentString += "<section id='section-" + newsGroupTbl[0].id + "' class='content-current'>";
                for (int i = 0; i < newsDetTbl.Count; i++)
                {
                    newsHitTbl.ReadList(Criteria.NewCriteria(tblNewsHit.Columns.newsId, CriteriaOperators.Equal, newsDetTbl[i].id));
                    groupContentString += "<div class='fo-top'><div class='form-group'>" +
                                          "<div class='col-sm-12 ctl'>";
                    if (newsHitTbl.Count > 0)
                        groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[i].id + "' class='top-news' style='display:inline'>(Checked as a top news)</span> <label> <input type='checkbox' class='newsClass' checked id='" + newsDetTbl[i].id + "'> " + newsDetTbl[i].newsDetTitle + " </label> </div>";
                    else
                        groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[i].id + "' class='top-news' style='display:none'>(Checked as a top news)</span> <label> <input type='checkbox' class='newsClass' id='" + newsDetTbl[i].id + "'> " + newsDetTbl[i].newsDetTitle + " </label> </div>";

                    groupContentString += "</div><div class='clearfix'></div></div></div>";
                }
                groupContentString += "</section>";
            }
            else
                groupTabsSrting = "";


            //other elements
            //if in a group there is no news, it will be ignored to put in category
            string tempString = string.Empty;
            for (int i = 1; i < newsGroupTbl.Count; i++)
            {
                tempString = "<li><a href='#section-" + newsGroupTbl[i].id + "' class='icon-cup'><span class='farsi-font-tab'>" + newsGroupTbl[i].newsGroupTitle + "</span></a></li>";

                newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.idGroup, CriteriaOperators.Equal, newsGroupTbl[i].id));
                if (newsDetTbl.Count > 0)
                {
                    groupTabsSrting += tempString;
                    groupContentString += "<section id='section-" + newsGroupTbl[i].id + "' >";
                    for (int j = 0; j < newsDetTbl.Count; j++)
                    {
                        newsHitTbl.ReadList(Criteria.NewCriteria(tblNewsHit.Columns.newsId, CriteriaOperators.Equal, newsDetTbl[j].id));

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
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        var value = "";
        if (Request.Cookies["chkId"] != null)
        {
            value = Request.Cookies["chkId"].Value;
        }

        //delete all before and add new ones
        tblNewsHitCollection hitNewsDelTbl = new tblNewsHitCollection();
        hitNewsDelTbl.ReadList();

        for (int i = 0; i < hitNewsDelTbl.Count; i++)
        {
            hitNewsDelTbl[i].Delete();
        }


        tblNewsHit hitNewsTbl = new tblNewsHit();
        string tempValue = "";
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i].ToString() == ",")
            {
                hitNewsTbl.newsId = Convert.ToInt32(tempValue);
                hitNewsTbl.ExpDate = "";
                hitNewsTbl.ExpTime = "";
                hitNewsTbl.allow = "1";
                hitNewsTbl.Create();
                tempValue = "";
            }
            else
            {
                tempValue += value[i].ToString();
            }
        }

        if (tempValue.Length > 0)
        {
            hitNewsTbl.newsId = Convert.ToInt32(tempValue);
            hitNewsTbl.ExpDate = "";
            hitNewsTbl.ExpTime = "";
            hitNewsTbl.allow = "1";
            hitNewsTbl.Create();
        }
        Response.Redirect("news-flagged.aspx");
    }
}