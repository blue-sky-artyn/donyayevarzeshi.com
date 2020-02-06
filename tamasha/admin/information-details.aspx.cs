using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


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
            Response.Redirect("information-add.aspx");

        //fill data 

        tblInformationDetailCollection DetailsTbl = new tblInformationDetailCollection();
        DetailsTbl.ReadList(Criteria.NewCriteria(tblInformationDetail.Columns.id, CriteriaOperators.Equal, itemGet));

        if (DetailsTbl.Count > 0)
        {
            setPicHtml.InnerHtml = "<img src='../images/inf/" + DetailsTbl[0].frontFile + "' class='img-responsive' draggable='false'>";
        }

        string writerStr = string.Empty;
        tblStaffCollection NewsCreatorTbl = new tblStaffCollection();
        NewsCreatorTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, DetailsTbl[0].infWriter));

        if (NewsCreatorTbl.Count > 0)
            writerStr = NewsCreatorTbl[0].StaffName + " " + NewsCreatorTbl[0].StaffFamily;

        string addDataString = string.Empty;
        addDataString += "<h3>" + DetailsTbl[0].infDetailTitle + "</h3><br>" +
                         "<span class='code'>Writer: <a>" + writerStr + "</a></span>" +
                         "<p>Information Details: " + DetailsTbl[0].infDetailDescription + "</p>" +
                        "<div class='price'>" +
                        "<span class='text'></span>";

        addDataString += "<span class='price-new'></span>";


        addDataString += "<span class='price-tax'><label class='checkbox'></label></span><br>";


        addDataString += "<span class='points'><small>Insert Date: " + DetailsTbl[0].infDetailInsertDate + "</small></span><br>";

        addDataString += "</div>";

        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups
        tblInformationGroupCollection GroupTbl = new tblInformationGroupCollection();
        GroupTbl.ReadList();


        //Select old items
        if (!IsPostBack)
        {
            if (DetailsTbl[0].infDetailTitle.Length > 0)
                txtTitle.Text = DetailsTbl[0].infDetailTitle;

            if (DetailsTbl[0].infDetailDescription.Length > 0)
                ckDetails.Text = DetailsTbl[0].infDetailDescription;

            for (int i = 0; i < GroupTbl.Count; i++)
                ddlNewsGroup.Items.Add(new ListItem(GroupTbl[i].infGroupTitle, GroupTbl[i].id.ToString()));
            ddlNewsGroup.SelectedValue = DetailsTbl[0].idInfoGroup.ToString();
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
            Response.Redirect("information-details.aspx");

        tblInformationDetailCollection detTbl = new tblInformationDetailCollection();
        detTbl.ReadList(Criteria.NewCriteria(tblInformationDetail.Columns.id, CriteriaOperators.Equal, itemGet));

        detTbl[0].Delete();

        Response.Redirect("information-add.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("information-add.aspx");

        tblInformationDetailCollection detTbl = new tblInformationDetailCollection();
        detTbl.ReadList(Criteria.NewCriteria(tblInformationDetail.Columns.id, CriteriaOperators.Equal, itemGet));

        //tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        //newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));

        string writerStr = string.Empty;
        tblStaffCollection infWriterTbl = new tblStaffCollection();
        infWriterTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, detTbl[0].infWriter));

        if (infWriterTbl.Count > 0)
            writerStr = infWriterTbl[0].StaffName + " " + infWriterTbl[0].StaffFamily;
        else
            writerStr = "Unknown";



        //if (newsPicTbl.Count > 0)
        //    fileNameUpdate = newsPicTbl[0].picName;


        if (txtTitle.Text.Trim().Length > 0 && ckDetails.Text.Trim().Length > 0)
        {
            detTbl[0].infDetailTitle = txtTitle.Text;

            string str = ckDetails.Text;
            detTbl[0].infDetailDescription = Server.HtmlDecode(str);

            detTbl[0].idInfoGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            

            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/inf/");
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
                detTbl[0].frontFile = filename;
            else
                detTbl[0].frontFile = fileNameUpdate;

            detTbl[0].Update();
            
        }

        Response.Redirect("information-details.aspx?item=" + itemGet);
    }
}