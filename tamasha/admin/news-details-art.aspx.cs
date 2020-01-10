using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using BlueSky.Artin;


public partial class admin_gallery_normal_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-add-art.aspx");

        //fill data 

        tblNewsDetailsArtCollection newsDetailsTbl = new tblNewsDetailsArtCollection();
        newsDetailsTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsArt.Columns.id, CriteriaOperators.Equal, itemGet));

        tblNewsPicArtCollection newsPicTbl = new tblNewsPicArtCollection();
        newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicArt.Columns.newsId, CriteriaOperators.Equal, newsDetailsTbl[0].id));


        if (newsPicTbl.Count > 0)
        {
            setPicHtml.InnerHtml = "<img src='../images/news/art/" + newsPicTbl[0].picName + "' class='img-responsive' draggable='false'>";
        }

        string writerStr = string.Empty;
        tblStaffCollection NewsCreatorTbl = new tblStaffCollection();
        NewsCreatorTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, newsDetailsTbl[0].idStaffCreator));

        if (NewsCreatorTbl.Count > 0)
            writerStr = NewsCreatorTbl[0].StaffName + " " + NewsCreatorTbl[0].StaffFamily;

        string addDataString = string.Empty;
        addDataString += "<h3>" + newsDetailsTbl[0].newsDetTitle + "</h3><br>" +
                         "<span class='code'>Writer: <a>" + writerStr + "</a></span>" +
                         "<p>News Details: " + newsDetailsTbl[0].newsDetDetails + "</p>" +
                        "<div class='price'>" +
                        "<span class='text'></span>";
       
        addDataString += "<span class='price-new'></span>";
       

        addDataString += "<span class='price-tax'><label class='checkbox'></label></span><br>";

        
            addDataString += "<span class='points'><small>Insert Date: " + newsDetailsTbl[0].newsDetInsertDate + "</small></span><br>";

        addDataString += "</div>";

        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups
        tblNewsGroupArtCollection newsGroupTbl = new tblNewsGroupArtCollection();
        newsGroupTbl.ReadList();


        //Select old items
        if (!IsPostBack)
        {
            if (newsDetailsTbl[0].newsDetTitle.Length > 0)
                txtTitle.Text = newsDetailsTbl[0].newsDetTitle;

            if (newsDetailsTbl[0].newsDetDetails.Length > 0)
                txtDetail.Text = newsDetailsTbl[0].newsDetDetails;

            for (int i = 0; i < newsGroupTbl.Count; i++)
                ddlNewsGroup.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
            ddlNewsGroup.SelectedValue = newsDetailsTbl[0].idGroup.ToString();
        }

        
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-details-art.aspx");

        tblNewsDetailsArtCollection newsTbl = new tblNewsDetailsArtCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, itemGet));

        newsTbl[0].Delete();

        Response.Redirect("news-add-art.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-add-art.aspx");

        tblNewsDetailsArtCollection newsTbl = new tblNewsDetailsArtCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsArt.Columns.id, CriteriaOperators.Equal, itemGet));

        tblNewsPicArtCollection newsPicTbl = new tblNewsPicArtCollection();
        newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicArt.Columns.newsId, CriteriaOperators.Equal, itemGet));

        string writerStr = string.Empty;
        tblStaffCollection infWriterTbl = new tblStaffCollection();
        infWriterTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, newsTbl[0].idStaffCreator));

        if (infWriterTbl.Count > 0)
            writerStr = infWriterTbl[0].StaffName + " " + infWriterTbl[0].StaffFamily;
        else
            writerStr = "Unknown";



        if (newsPicTbl.Count > 0)
            fileNameUpdate = newsPicTbl[0].picName;


        if (txtTitle.Text.Trim().Length > 0 && txtDetail.Text.Trim().Length > 0)
        {
            newsTbl[0].newsDetTitle = txtTitle.Text;
            newsTbl[0].newsDetDetails = txtDetail.Text;

            newsTbl[0].idGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            newsTbl[0].Update();

            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/news/art/");
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
                        lblError.Text = "A problem accurred while uplouding picture";
                    }
                }
                else
                {
                    lblError.Text = "Not valid picture file";
                }
            }

            // file upload end
            if (filename.Trim().Length > 0)
                 newsPicTbl[0].picName = filename;
            else
                newsPicTbl[0].picName = fileNameUpdate;

            newsPicTbl.UpdateList(true);
        }

        Response.Redirect("news-details-art.aspx?item=" + itemGet);
    }
}