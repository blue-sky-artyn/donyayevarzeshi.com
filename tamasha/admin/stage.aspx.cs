using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;
public partial class admin_gallery_normal : System.Web.UI.Page
{
    public bool addFlag = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        //place pictures
        string addStage = string.Empty;
        tblStagesCollection stageTbl = new tblStagesCollection();
        stageTbl.ReadList();
        tblStagesPicsCollection stagePicTbl = new tblStagesPicsCollection();

        addStage += "<div class='grids_of_4'>";
        for (int i = 0; i < stageTbl.Count; i++)
        {
            stagePicTbl.ReadList(Criteria.NewCriteria(tblStagesPics.Columns.stageId, CriteriaOperators.Equal, stageTbl[i].id));
            addStage += "<div class='grid1_of_4'><div class='content_box'><a href='stage-details.aspx?item=" + stageTbl[i].id + "'>" +
                            "<img src='.." + stagePicTbl[0].picAddr + stagePicTbl[0].picName + "' class='img-responsive' alt='" + stagePicTbl[0].id + "' /></a>" +
                            "<h4><a> " + stageTbl[i].stageName + " </a></h4>" +
                            "<p>" + stageTbl[i].stagePhone + "</p>" +
                            "<div class='grid_1 simpleCart_shelfItem'>" +
                            "<div class='item_add'><span class='item_price'><h6>" + stageTbl[i].stageRowTotal + "</h6></span></div>" +
                            "<div class='item_add'><span class='item_price'><a href='stage-details.aspx?item=" + stageTbl[i].id + "'>EDIT</a></span></div>" +
                            "</div></div></div>";
            if ((i - 1) % 4 == 0)
            {
                addStage += "<div class='clearfix'></div></div>";
                addStage += "<div class='grids_of_4'>";
            }
        }

        addStaffHtml.InnerHtml = addStage;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string errorString = string.Empty;
        lblError.Visible = false;
        tblStages stageTbl = new tblStages();
        tblStagesPics stagesPicTbl = new tblStagesPics();
        tblStagesSeats stagesSeatStatusTbl = new tblStagesSeats();
        tblStagesSeats stagesSeatTbl = new tblStagesSeats();

        tblStagesCollection stagesReadIdTbl = new tblStagesCollection();
        int idStage = 0;

        int rowNo = Convert.ToInt32(ddlStageRow.SelectedValue);


        try
        {

            if (txtStageName.Text.Trim().Length > 0)
            {

                #region tblStage 

                stageTbl.stageName = txtStageName.Text;
                stageTbl.stageAddress = txtAddress.Text;
                stageTbl.stagePhone = txtPhone.Text;
                stageTbl.stageDetails = txtDetail.Text;
                stageTbl.stageRowTotal = Convert.ToInt32(ddlStageRow.SelectedValue);
                stageTbl.allow = "1";

                //stageTbl.Create();

                #endregion

                //Read the last id for other related tables
                stagesReadIdTbl.ReadList();
                if (stagesReadIdTbl.Count > 0)
                    idStage = stagesReadIdTbl[stagesReadIdTbl.Count - 1].id;
            
                #region tblStagePic

                // file upload start 
                string filename = string.Empty;
                if (IsPostBack)
                {
                    Boolean fileOK = false;
                    String path = Server.MapPath("~/images/stage/");
                    if (fuGallery.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                        String[] allowedExtensions = { ".jpg", ".png", ".bmp", ".tif" };
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
                            lblError.Text = "A promblem with uplouding picture";
                        }
                    }
                    else
                    {
                        lblError.Text = "Not valid picture";
                    }
                }

                // file upload end

                stagesPicTbl.picAddr = "images/stage/";
                stagesPicTbl.stageId = idStage;
                stagesPicTbl.allow = "1";
                

                if (filename.Length > 0)
                    stagesPicTbl.picName = filename;
                else
                    stagesPicTbl.picName = "default.jpg";

                
                //if (lblError.Visible == false)
                    //stagesPicTbl.Create();
                #endregion

                #region tblStagesSeats
                int lengthOfReadingRow = Convert.ToInt32(ddlStageRow.SelectedValue);
                //read cookie
                string cookieVal = "";
                if (Request.Cookies["rowsNo"] != null)
                {
                    cookieVal = Request.Cookies["rowsNo"].Value;
                }

                //reading values in splited text
                string[] rowItem;string[] seperator = { "-" };
                rowItem = cookieVal.Split(seperator, lengthOfReadingRow + 1, StringSplitOptions.RemoveEmptyEntries);
                
                for (int i = 1; i <= lengthOfReadingRow; i++)
                {
                    stagesSeatStatusTbl.StagesId = idStage;
                    stagesSeatStatusTbl.rowNo = i;
                    stagesSeatStatusTbl.seatsForRow = Convert.ToInt32(rowItem[i]);
                    stagesSeatStatusTbl.allow = "1";
                    //stagesSeatStatusTbl.Create();
                }
                
                #endregion

                #region tblStagesSeatsStatus

                #endregion




                //Response.Redirect("staff.aspx");
            }
            else
            {
                lblError.Text = "* Please fill nesessary items";
                lblError.Visible = true;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            throw;
        }
    }

    protected void btnTst_Click(object sender, EventArgs e)
    {
       

        //txtStageName.Text = "out of range";
    }
    protected void btnAddRows_Click(object sender, EventArgs e)
    {
        string rowNoStr = string.Empty;
        int rowNo = Convert.ToInt32(ddlStageRow.SelectedValue);

        //for (int i = 0; i < 42; i++)
        //{
        //    rowNoStr += "<div class='mainseat' style='float: left;'><span class='rowNumber'>" + i + "</span></div>";
        //}
        //rowNoStr += "<div class='clearfix'></div>";
        for (int i = 0; i < rowNo; i++)
        {
            rowNoStr += "<div class='mainseat' style='float: left;'><span class='rowNumber'>" + (i+1).ToString() + "</span></div>" +
                        "<label class='seat-no-font'>Seats:</label><select class='seat-no-font seats-row' id='row" + i + "'>";
            for (int j = 43; j >= 0; j--)
            {
                rowNoStr += "<option value='" + j + "'>" + j + "</option>";
            }
            rowNoStr += "</select><div id='" + i + "' class='row-in-line'>";
            for (int j = 0; j < 43; j++)
            {
                rowNoStr += "<div id='" + (i + 1).ToString() + "-" + (j + 1).ToString() + "' class='mainseat' style=';'><a href='#' class='tool-tip-seat icon-sofa is-clone'><i class='fa fa-user-o' aria-hidden='true'></i></a>" +
                    "<div class='popup-items'>" +
                    "<input type='radio' name='" + (i + 1).ToString() + "-" + (j + 1).ToString() + "' value='normal' checked='true' > Normal   <br>" +
                    "<input type='radio' name='" + (i + 1).ToString() + "-" + (j + 1).ToString() + "' value='Disables'> Disables<br>" +
                    "<input type='radio' name='" + (i + 1).ToString() + "-" + (j + 1).ToString() + "' value='Unavailable'> Unavailable<br>" +
                    "<input type='radio' name='" + (i + 1).ToString() + "-" + (j + 1).ToString() + "' value='VIP'> VIP<br>" +
                    "<input type='button' id='" + (i + 1).ToString() + "-" + (j + 1).ToString() + "' class='btn-update' value='update' /><br /></div></div>";
            }
            rowNoStr += "</div><div class='mainseat' style='float: left;'><span class='rowNumber'>" + (i+1).ToString() + "</span></div>" +
                        "<div class='clearfix'></div>";

        }

        rowNoHtml.InnerHtml = rowNoStr;

        //to check any row has been added or no
        addFlag = true;
    }
}