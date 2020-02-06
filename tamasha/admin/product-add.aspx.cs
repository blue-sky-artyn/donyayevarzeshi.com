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
        tblProductGroupCollection GroupTbl = new tblProductGroupCollection();
        GroupTbl.ReadList();

        //tblNewsPicArtCollection newsPicTbl = new tblNewsPicArtCollection();

        if (!IsPostBack)
        {
            for (int i = 0; i < GroupTbl.Count; i++)
            {
                ddlNewsGroup.Items.Add(new ListItem(GroupTbl[i].groupName, GroupTbl[i].id.ToString()));
            }
        }
        //place data
        string infoString = string.Empty;
        tblProductCollection detTbl = new tblProductCollection();
        detTbl.ReadList();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < detTbl.Count; i++)
        {
            GroupTbl.ReadList(Criteria.NewCriteria(tblInformationGroup.Columns.id, CriteriaOperators.Equal, detTbl[i].productGrpId));
            //newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicArt.Columns.newsId, CriteriaOperators.Equal, newsTbl[i].id));

            if (countSteps == 0)
            {
                infoString += addRow;
            }

            infoString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>Information " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + detTbl[i].productName + "(" + GroupTbl[0].groupName + ")" + "</div><div class='panel-body ont two'>" +
                          "<div><img src='" + detTbl[i].productCoverPicAdd + detTbl[i].productCoverPicName + "' alt='" + detTbl[i].productCoverPicName + "' style='width: 100%;' /></div>" +
                          "<p>" + detTbl[i].productDet + "</p></div>" +
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
        tblProduct detTbl = new tblProduct();
        tblProductCollection checkLastIdTbl = new tblProductCollection();
        
        tblProductDeal productDealPriodTbl = new tblProductDeal();

        if (txtTitle.Text.Trim().Length > 0)
        {
            #region Add product

            detTbl.productName = txtTitle.Text;
            
            string str = ckDetails.Text;
            detTbl.productDet = Server.HtmlDecode(str);
            
            detTbl.productPrice = Convert.ToInt32(txtPrice.Text);
            detTbl.productGrpId = Int32.Parse(ddlNewsGroup.SelectedValue);

            detTbl.allow = "1";

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/product/");

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
                if (filename.Trim().Length > 0) detTbl.productCoverPicName = filename;
                else detTbl.productCoverPicName = "default.jpg";

            detTbl.productCoverPicAdd = "../images/product/";
            detTbl.Create();

            #endregion

            #region Add deal priod
            checkLastIdTbl.ReadList();
            productDealPriodTbl.productId = checkLastIdTbl[checkLastIdTbl.Count - 1].id;
            productDealPriodTbl.startDate = txtStartDeal.Text;
            productDealPriodTbl.endDate = txtEndDeal.Text;
            productDealPriodTbl.allow = "1";
            if (txtStartDeal.Text.Length > 0 || txtEndDeal.Text.Length > 0)
                productDealPriodTbl.Create();

            #endregion


            Response.Redirect("product-add.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}