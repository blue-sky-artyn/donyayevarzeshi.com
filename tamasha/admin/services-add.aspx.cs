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
        tblServiceGroupCollection GroupTbl = new tblServiceGroupCollection();
        GroupTbl.ReadList();

        tblServicePicCollection detPicTbl = new tblServicePicCollection();

        if (!IsPostBack)
        {
            for (int i = 0; i < GroupTbl.Count; i++)
            {
                ddlNewsGroup.Items.Add(new ListItem(GroupTbl[i].ServiceGroupTitle, GroupTbl[i].id.ToString()));
            }
        }
        //place data
        string detString = string.Empty;
        tblServicesCollection detTbl = new tblServicesCollection();
        detTbl.ReadList();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < detTbl.Count; i++)
        {
            GroupTbl.ReadList(Criteria.NewCriteria(tblServiceGroup.Columns.id, CriteriaOperators.Equal, detTbl[i].idServiceGroup));
            detPicTbl.ReadList(Criteria.NewCriteria(tblServicePic.Columns.idService, CriteriaOperators.Equal, detTbl[i].id));

            if (countSteps == 0)
            {
                detString += addRow;
            }

            detString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>Service " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + detTbl[i].ServiceTitle + "(" + GroupTbl[0].ServiceGroupTitle + ")" + "</div><div class='panel-body ont two'>";

            if (detPicTbl.Count > 0)
                detString += "<div><img src='../images/service/" + detPicTbl[0].picName + "' alt='" + detPicTbl[0].picName + "' style='width: 100%;' /></div>";


            detString += "<p>" + detTbl[i].ServiceDetail + "</p></div>" +
                          "<div class='panel-footer'><a href='service-details.aspx?item=" + detTbl[i].id + "'>edit</a></div></div></div>";
            countSteps++;
            if (countSteps == 2)
            {
                countSteps = 0;
                detString += "</div>";
            }
        }

        infHtml.InnerHtml = detString;



    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string dateInsert = DateTime.Now.ToString("yyyy/MM/dd");
        string timeInsert = DateTime.Now.ToString("hh:mm:ss");


        tblServicesCollection detReadTbl = new tblServicesCollection();
        tblServices detTbl = new tblServices();
        tblServicePic detPicTbl = new tblServicePic();

        if (txtTitle.Text.Trim().Length > 0)
        {
            detTbl.ServiceTitle = txtTitle.Text;

            if (txtDetail.Text.Trim().Length > 0)
                detTbl.ServiceDetail = txtDetail.Text;
            else
                detTbl.ServiceDetail = "";

            detTbl.idAgeGroup = 1;
            detTbl.Gender = 0;

            detTbl.idServiceGroup = Int32.Parse(ddlNewsGroup.SelectedValue);
            detTbl.Create();

            detReadTbl.ReadList();

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/service/");

            // if picture
            detPicTbl.idService = detReadTbl[detReadTbl.Count - 1].id;

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
            if (filename.Trim().Length > 0) detPicTbl.picName = filename;
            else detPicTbl.picName = "default.jpg";

            detPicTbl.picAddr = "~/images/service/";
            detPicTbl.picDetails = "";
            detPicTbl.allow = "1";

            detPicTbl.Create();

            Response.Redirect("services-add.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}