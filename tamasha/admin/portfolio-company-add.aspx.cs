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
        tblPortfolioGroupCollection GroupTbl = new tblPortfolioGroupCollection();
        GroupTbl.ReadList();

        if (!IsPostBack)
        {
            for (int i = 0; i < GroupTbl.Count; i++)
            {
                ddlPortfolioGroup.Items.Add(new ListItem(GroupTbl[i].groupTitle, GroupTbl[i].id.ToString()));
            }
        }
        //place data
        string infoString = string.Empty;
        tblPortfolioCompanyCollection detTbl = new tblPortfolioCompanyCollection();
        detTbl.ReadList();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < detTbl.Count; i++)
        {
            GroupTbl.ReadList(Criteria.NewCriteria(tblPortfolioGroup.Columns.id, CriteriaOperators.Equal, detTbl[i].idGroup));

            if (countSteps == 0)
            {
                infoString += addRow;
            }

            infoString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>Information " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + detTbl[i].title + "(" + GroupTbl[0].groupTitle + ")" + "</div><div class='panel-body ont two'>"+
                          "<div><img src='" + detTbl[i].picAddr + detTbl[i].picName + "' alt='" + detTbl[i].picName + "' style='width: 100%;' /></div>" +
                          "<p>" + detTbl[i].details + "</p><h5>Date: " + detTbl[i].implimentationDate + "</h5></div>" +
                          "<div class='panel-footer'><a href='portfolio-company-details.aspx?item=" + detTbl[i].id + "'>edit</a></div></div></div>";
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
        int dateInsert = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

        tblCompanyCollection idCompanyTbl = new tblCompanyCollection();
        idCompanyTbl.ReadList();

        tblPortfolioCompany detTbl = new tblPortfolioCompany();

        if (txtTitle.Text.Trim().Length > 0)
        {
            detTbl.title = txtTitle.Text;
            detTbl.details = txtDetail.Text;
            detTbl.idCompany = idCompanyTbl[0].id;
            detTbl.implimentationDate = Convert.ToInt32(txtImplementDate.Text);
            
            detTbl.idGroup = Int32.Parse(ddlPortfolioGroup.SelectedValue);

            detTbl.allow = "1";

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/portfolio/");


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
                if (filename.Trim().Length > 0) detTbl.picName = filename;
                else detTbl.picName = "default.jpg";
            detTbl.picAddr = "images/portfolio/";


            detTbl.Create();

            Response.Redirect("portfolio-company-add.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}