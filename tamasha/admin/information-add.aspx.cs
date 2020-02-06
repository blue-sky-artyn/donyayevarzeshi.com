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
        //Add ddl
        tblInformationGroupCollection GroupTbl = new tblInformationGroupCollection();
        GroupTbl.ReadList();

        //tblNewsPicArtCollection newsPicTbl = new tblNewsPicArtCollection();

        if (!IsPostBack)
        {
            for (int i = 0; i < GroupTbl.Count; i++)
            {
                ddlNewsGroup.Items.Add(new ListItem(GroupTbl[i].infGroupTitle, GroupTbl[i].id.ToString()));
            }
        }
        //place data
        string infoString = string.Empty;
        tblInformationDetailCollection detTbl = new tblInformationDetailCollection();
        detTbl.ReadList();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < detTbl.Count; i++)
        {
            GroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, detTbl[i].idInfoGroup));
            //newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicArt.Columns.newsId, CriteriaOperators.Equal, newsTbl[i].id));

            if (countSteps == 0)
            {
                infoString += addRow;
            }

            infoString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>Information " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + detTbl[i].infDetailTitle + "(" + GroupTbl[0].infGroupTitle + ")" + "</div><div class='panel-body ont two'>";
            if (detTbl[i].frontFileType == 0)
                infoString += "<div><img src='../images/inf/" + detTbl[i].frontFile + "' alt='" + detTbl[i].frontFile + "' style='width: 100%;' /></div>";
            else if (detTbl[i].frontFileType == 1)
                infoString += "<div><video id='video1'><source src='../movie/inf/" + detTbl[i].frontFile + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
            else
                infoString += "<div>" + detTbl[i].frontFile + "</div>";

            infoString += "<p>" + detTbl[i].infDetailDescription + "</p></div>" +
                          "<div class='panel-footer'><a href='information-details.aspx?item=" + detTbl[i].id + "'>edit</a></div></div></div>";
            countSteps++;
            if (countSteps == 2)
            {
                countSteps = 0;
                infoString += "</div>";
            }
        }

        infHtml.InnerHtml = infoString;



    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string dateInsert = DateTime.Now.ToString("yyyy/MM/dd");
        string timeInsert = DateTime.Now.ToString("hh:mm:ss");


        tblInformationDetail detTbl = new tblInformationDetail();

        if (txtTitle.Text.Trim().Length > 0)
        {
            detTbl.infDetailTitle = txtTitle.Text;
            
            string str = ckDetails.Text;
            detTbl.infDetailDescription = Server.HtmlDecode(str);
            
            detTbl.infWriter = 2;
            detTbl.infDetailInsertDate = dateInsert;
            
            detTbl.idInfoGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            detTbl.allow = "1";

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/inf/");
            String pathMovie = Server.MapPath("~/movie/inf/");

            // if picture
            if (rb1.Value == "0")
            {
                detTbl.frontFileType = 0;

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
                if (filename.Trim().Length > 0) detTbl.frontFile = filename;
                else detTbl.frontFile = "default.jpg";
            }
            else if (rb2.Value == "1")
            {
                detTbl.frontFileType = 1;

                if (IsPostBack)
                {
                    if (fuGallery.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                        String[] allowedExtensions = { ".mov", ".mp4", ".ogv" };
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
                            fuGallery.PostedFile.SaveAs(pathMovie + fuGallery.FileName);
                            filename = fuGallery.FileName;
                        }
                        catch (Exception ex)
                        {
                            lblError.Text = "A problem with uplouding movie";
                        }
                    }
                    else
                    {
                        lblError.Text = "Not valid picture";
                    }
                }

                //file upload end
                if (filename.Trim().Length > 0) detTbl.frontFile = filename;
                else
                {
                    detTbl.frontFile = "default.jpg";
                    detTbl.frontFileType = 0;
                }
            }
            else if (rb3.Value == "2")
            {
                detTbl.frontFileType = 2;
                detTbl.frontFile = txtLink.Text;



            }

            detTbl.Create();

            Response.Redirect("information-add.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}