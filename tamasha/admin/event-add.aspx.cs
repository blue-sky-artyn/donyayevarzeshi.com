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
        //place data
        string eventString = string.Empty;
        tblOccasionCollection eventTbl = new tblOccasionCollection();
        eventTbl.ReadList();

        tblOccasionDetailsCollection eventDetTbl = new tblOccasionDetailsCollection();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < eventTbl.Count; i++)
        {
            eventDetTbl.ReadList(Criteria.NewCriteria(tblOccasionDetails.Columns.OccasionId, CriteriaOperators.Equal, eventTbl[i].id));

            if (countSteps == 0)
            {
                eventString += addRow;
            }

            eventString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>Event " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + eventTbl[i].OccasionTitle + "(" + eventTbl[i].StartDate + " TO " + eventTbl[i].EndDate + ")" + "</div><div class='panel-body ont two'>" +
                          "<div><img src='" + eventTbl[i].picAddr + eventTbl[i].picName + "' alt='" + eventTbl[i].picName + "' style='width: 100%;' /></div>" +
                          "<p>" + eventTbl[i].OccasionDetails + "</p></div>" +
                          "<div class='panel-footer'><a href='event-details.aspx?item=" + eventTbl[i].id + "'>edit</a></div></div></div>";
            countSteps++;
            if (countSteps == 2)
            {
                countSteps = 0;
                eventString += "</div>";
            }
        }

        eventsHtml.InnerHtml = eventString;



    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string dateInsert = DateTime.Now.ToString("yyyyMMdd");
        string timeInsert = DateTime.Now.ToString("hh:mm:ss");


        tblOccasion eventsTbl = new tblOccasion();

        if (txtTitle.Text.Trim().Length > 0)
        {
            eventsTbl.OccasionTitle = txtTitle.Text;
            eventsTbl.OccasionDetails = txtDetail.Text;
            eventsTbl.MakeDate = dateInsert;
            eventsTbl.StartDate = Convert.ToInt32(txtStartDeal.Text);
            eventsTbl.EndDate = Convert.ToInt32(txtEndDeal.Text);
            eventsTbl.price = Convert.ToInt32(txtPrice.Text);
            eventsTbl.allow = "1";

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/event/");

            // if picture
                if (IsPostBack)
                {
                    if (fuGallery.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                        String[] allowedExtensions = { ".jpg", ".png", ".bmp", ".gif" };
                        for (int i = 0; i < allowedExtensions.Length; i++)
                        {
                            if (fileExtension == allowedExtensions[i])
                            {
                                fileOK = true;
                            }
                        }
                    }

                    if (fileOK)
                    {
                        try
                        {
                            fuGallery.PostedFile.SaveAs(path + fuGallery.FileName);
                            filename = fuGallery.FileName;
                        }
                        catch (Exception ex)
                        {
                            lblError.Text = "A problem with uplouding picture";
                        }
                    }
                    else
                    {
                        lblError.Text = "Not valid picture";
                    }
                }

                //file upload end
                if (filename.Trim().Length > 0) eventsTbl.picName = filename;
                else eventsTbl.picName = "default.jpg";

            eventsTbl.picAddr = "images/events/";

            eventsTbl.Create();

            Response.Redirect("event-add.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}