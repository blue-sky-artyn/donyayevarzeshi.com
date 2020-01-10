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

        tblNewsGroupSportCollection newsGroupTbl = new tblNewsGroupSportCollection();
        newsGroupTbl.ReadList();

        tblSliderCollection sliderTbl = new tblSliderCollection();
        sliderTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.SliderLink, CriteriaOperators.IsNotNull));

        tblNewsDetailsSportCollection newsDetTbl = new tblNewsDetailsSportCollection();

        //isolated 1st item due to active class to be set for it
        if (newsGroupTbl.Count > 0)
            groupTabsSrting = "<li class='tab-current'><a href='#section-" + newsGroupTbl[0].id + "' class='icon-shop'><span class='farsi-font-tab'>" + newsGroupTbl[0].newsGroupTitle + "</span></a></li>";

        newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsSport.Columns.idGroup, CriteriaOperators.Equal, newsGroupTbl[0].id));

        int lowRange = 0;
        switch (newsDetTbl.Count)
        {
            case 1: lowRange = 0; break;
            case 2: lowRange = 0; break;
            case 3: lowRange = 0; break;
            case 4: lowRange = 0; break;
            case 5: lowRange = 0; break;
            default:
                lowRange = 5;
                break;
        }

        if (newsDetTbl.Count > 0)
        {
            groupContentString += "<section id='section-" + newsGroupTbl[0].id + "' class='content-current'>";

            for (int i = newsDetTbl.Count -1; i >= lowRange; i--)
            {
                sliderTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.SliderLink, CriteriaOperators.Like, newsDetTbl[i].id.ToString()));


                if (newsDetTbl[i].topPageFileType == 0)
                {
                    groupContentString += "<div class='fo-top'><div class='form-group'>" +
                                          "<div class='col-sm-12 ctl'>";
                    if (sliderTbl.Count > 0)
                        groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[i].id + "' class='top-news' style='display:inline'>(Do not show)</span> <label> <input type='checkbox' class='newsClass' checked id='" + newsDetTbl[i].id + "'> " + newsDetTbl[i].newsDetTitle + " </label> </div>";
                    else
                        groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[i].id + "' class='top-news' style='display:none'>(Do not show)</span> <label> <input type='checkbox' class='newsClass' id='" + newsDetTbl[i].id + "'> " + newsDetTbl[i].newsDetTitle + " </label> </div>";

                    groupContentString += "</div><div class='clearfix'></div></div></div>";
                }
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

            newsDetTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsSport.Columns.idGroup, CriteriaOperators.Equal, newsGroupTbl[i].id));
            switch (newsDetTbl.Count)
            {
                case 1: lowRange = 0; break;
                case 2: lowRange = 0; break;
                case 3: lowRange = 0; break;
                case 4: lowRange = 0; break;
                case 5: lowRange = 0; break;
                default:
                    lowRange = 5;
                    break;
            }
            if (newsDetTbl.Count > 0)
            {
                groupTabsSrting += tempString;
                groupContentString += "<section id='section-" + newsGroupTbl[i].id + "' >";
                for (int j = newsDetTbl.Count - 1; j >= lowRange; j--)
                {
                    sliderTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.SliderLink, CriteriaOperators.Like, newsDetTbl[j].id.ToString()));

                    if (newsDetTbl[j].topPageFileType == 0)
                    {
                        groupContentString += "<div class='fo-top'><div class='form-group'>" +
                                                "<div class='col-sm-12 ctl'>";
                        if (sliderTbl.Count > 0)
                            groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[j].id + "' class='top-news' style='display:inline'>(Do not show)</span> <label> <input type='checkbox' class='newsClass' checked id='" + newsDetTbl[j].id + "'> " + newsDetTbl[j].newsDetTitle + " </label> </div>";
                        else
                            groupContentString += "<div class='checkbox'><span id='text" + newsDetTbl[j].id + "' class='top-news' style='display:none'>(Do not show)</span> <label> <input type='checkbox' class='newsClass' id='" + newsDetTbl[j].id + "'> " + newsDetTbl[j].newsDetTitle + " </label> </div>";

                        groupContentString += "</div><div class='clearfix'></div></div></div>";
                    }
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
        tblSliderCollection sliderOldTbl = new tblSliderCollection();
        sliderOldTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.SliderLink, CriteriaOperators.IsNotNull));

        for (int i = 0; i < sliderOldTbl.Count; i++)
        {
            sliderOldTbl[i].Delete();
        }


        tblSlider sliderAddTbl = new tblSlider();

        for (int i = 0; i < value.Length; i++)
        {
            byte[] pass_byte = System.Text.Encoding.ASCII.GetBytes(value[i].ToString());
            if (pass_byte[0] <= 57 && pass_byte[0] >= 48)
            {
                sliderAddTbl.SliderLink = value[i].ToString();
                sliderAddTbl.SliderTitle = "";
                sliderAddTbl.SliderDetail = "";
                sliderAddTbl.SliderPicName = "";
                sliderAddTbl.SliderPicAddr= "";
                sliderAddTbl.SliderStartDate= "";
                sliderAddTbl.SliderStartTime= "";
                sliderAddTbl.SliderEndDate= "";
                sliderAddTbl.SliderEndTime= "";
                
                sliderAddTbl.Create();
            }
        }
        Response.Redirect("news-slider-sport.aspx");
    }
}