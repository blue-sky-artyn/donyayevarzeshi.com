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
            Response.Redirect("services-add.aspx");

        //fill data 

        tblServicesCollection DetailsTbl = new tblServicesCollection();
        DetailsTbl.ReadList(Criteria.NewCriteria(tblServices.Columns.id, CriteriaOperators.Equal, itemGet));

        tblServicePicCollection DetailsPicTbl = new tblServicePicCollection();
        DetailsPicTbl.ReadList(Criteria.NewCriteria(tblServicePic.Columns.idService, CriteriaOperators.Equal, itemGet));

        if (DetailsPicTbl.Count > 0)
        {
            setPicHtml.InnerHtml = "<img src='../images/service/" + DetailsPicTbl[0].picName + "' class='img-responsive' draggable='false'>";
        }

        //----- Add writer of review -------
        //string writerStr = string.Empty;
        //tblStaffCollection NewsCreatorTbl = new tblStaffCollection();
        //NewsCreatorTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, DetailsTbl[0].infWriter));

        //if (NewsCreatorTbl.Count > 0)
        //    writerStr = NewsCreatorTbl[0].StaffName + " " + NewsCreatorTbl[0].StaffFamily;

        string addDataString = string.Empty;
        addDataString += "<h3>" + DetailsTbl[0].ServiceTitle + "</h3><br>" +
                         //"<span class='code'>Writer: <a>" + writerStr + "</a></span>" +
                         "<p>Information Details: " + DetailsTbl[0].ServiceDetail + "</p>" +
                        "<div class='price'>" +
                        "<span class='text'></span>";

        addDataString += "<span class='price-new'></span>";


        addDataString += "<span class='price-tax'><label class='checkbox'></label></span><br>";


        //addDataString += "<span class='points'><small>Insert Date: " + DetailsTbl[0].infDetailInsertDate + "</small></span><br>";

        addDataString += "</div>";

        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups
        tblServiceGroupCollection GroupTbl = new tblServiceGroupCollection();
        GroupTbl.ReadList();


        //Select old items
        if (!IsPostBack)
        {
            if (DetailsTbl[0].ServiceTitle.Length > 0)
                txtTitle.Text = DetailsTbl[0].ServiceTitle;

            if (DetailsTbl[0].ServiceDetail.Length > 0)
                txtDetail.Text = DetailsTbl[0].ServiceDetail;

            for (int i = 0; i < GroupTbl.Count; i++)
                ddlNewsGroup.Items.Add(new ListItem(GroupTbl[i].ServiceGroupTitle, GroupTbl[i].id.ToString()));
            ddlNewsGroup.SelectedValue = DetailsTbl[0].idServiceGroup.ToString();
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
            Response.Redirect("service-details.aspx");

        tblServicesCollection detTbl = new tblServicesCollection();
        detTbl.ReadList(Criteria.NewCriteria(tblServices.Columns.id, CriteriaOperators.Equal, itemGet));

        detTbl[0].Delete();

        Response.Redirect("services-add.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("service-add.aspx");

        tblServicesCollection detTbl = new tblServicesCollection();
        detTbl.ReadList(Criteria.NewCriteria(tblServices.Columns.id, CriteriaOperators.Equal, itemGet));

        //tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        //newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));

        //------- Add writer of review  -------
        //string writerStr = string.Empty;
        //tblStaffCollection infWriterTbl = new tblStaffCollection();
        //infWriterTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, detTbl[0].infWriter));

        //if (infWriterTbl.Count > 0)
        //    writerStr = infWriterTbl[0].StaffName + " " + infWriterTbl[0].StaffFamily;
        //else
        //    writerStr = "Unknown";



        //if (newsPicTbl.Count > 0)
        //    fileNameUpdate = newsPicTbl[0].picName;


        if (txtTitle.Text.Trim().Length > 0)
        {
            detTbl[0].ServiceTitle = txtTitle.Text;
            detTbl[0].ServiceDetail = txtDetail.Text;

            detTbl[0].idServiceGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            detTbl[0].Update();

            tblServicePicCollection detPicTbl = new tblServicePicCollection();
            detPicTbl.ReadList(Criteria.NewCriteria(tblServicePic.Columns.idService, CriteriaOperators.Equal, itemGet));

            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/service/");
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
                detPicTbl[0].picName = filename;
            else
                detPicTbl[0].picName = fileNameUpdate;

            detPicTbl[0].picAddr = "~/images/service/";
            detTbl[0].Update();
            
        }

        Response.Redirect("service-details.aspx?item=" + itemGet);
    }
}