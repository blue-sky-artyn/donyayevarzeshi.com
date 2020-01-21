using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //kill cookies
        //if (!IsPostBack)
        //{
        //    ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "killCookie();", true);
        //}
        ////Slider
        //string sliderString = string.Empty;
        //tblSliderCollection sliderTbl = new tblSliderCollection();
        //sliderTbl.ReadList();

        //for (int i = 0; i < sliderTbl.Count; i++)
        //{
        //    sliderString += "<div class='col-md-6 cart-sec simpleCart_shelfItem'><div class='cart-item cyc'>" +
        //                    "<img src='../images/slider/" + sliderTbl[i].SliderPicName + "' class='img-responsive' alt='CP picture'></div>" +
        //                    "<div class='cart-item-info'><ul class='li-slider'>" +
        //                    "<li class='slider-details'>Slider Title:<span>" + sliderTbl[i].SliderTitle + "</span><br /></li>" +
        //                    "<li class='slider-details'>Slider Detail:<span>" + sliderTbl[i].SliderDetail + "</span><br /></li>" +
        //                    "</ul><a id =\"" + sliderTbl[i].id + "\" href=\"javascript:__doPostBack('ctl00$ctl00$ContentPlaceHolder1$ContentPlaceHolder2$LinkButton" + sliderTbl[i].id + "','')\" Class='clickable'>Update</a>" +
        //                    //"<asp:Button ID="btnEdit" runat="server" class="normal-btn" Text="EDIT" style="width: 20%;" OnClick="btnEdit_Click"/>
        //                    "</div><div class='clearfix'></div></div>";




        //}

        //slidersUpdateHtml.InnerHtml = sliderString;

        //if (!IsPostBack)
        //{
        //    if (sliderTbl.Count > 0)
        //    {
        //        txtUpdateTitle.Text = sliderTbl[0].SliderTitle;
        //        txtUpdateDetail.Text = sliderTbl[0].SliderDetail;
        //    }
        //}
        tblGalleryPicturesCollection picsTbl = new tblGalleryPicturesCollection();
        picsTbl.ReadList();

        img1.Src = "../images/" + picsTbl[0].GalleryPicName;
        img2.Src = "../images/" + picsTbl[1].GalleryPicName;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //tblSlider sliderCreateTbl = new tblSlider();

        


        //// file upload start 
        //string filename = string.Empty;
        //if (IsPostBack)
        //{
        //    Boolean fileOK = false;
        //    String path = Server.MapPath("~/images/slider/");
        //    if (fuGallery.HasFile)
        //    {
        //        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
        //        String[] allowedExtensions = { ".jpg" };
        //        for (int i = 0; i < allowedExtensions.Length; i++)
        //        {
        //            if (fileExtension == allowedExtensions[i])
        //            {
        //                fileOK = true;
        //            }
        //        }
        //    }

        //    if (fileOK)
        //    {
        //        try
        //        {
        //            fuGallery.PostedFile.SaveAs(path + fuGallery.FileName);
        //            filename = fuGallery.FileName;
        //        }
        //        catch (Exception ex)
        //        {
        //            lblError.Text = "A problem accurred while uplouding picture";
        //        }
        //    }
        //    else
        //    {
        //        lblError.Text = "Not valid picture file";
        //    }
        //}

        //// file upload end
       
        //    if (filename.Trim().Length > 0)
        //    {
        //        if (txtTitle.Text.Trim().Length > 0)
        //        {
        //            sliderCreateTbl.SliderTitle = txtTitle.Text;
        //            if (txtDetail.Text.Trim().Length > 0)
        //                sliderCreateTbl.SliderDetail = txtDetail.Text;
        //            else
        //                sliderCreateTbl.SliderDetail = "";
        //            sliderCreateTbl.SliderPicAddr = "~/slider/";
        //            sliderCreateTbl.SliderPicName = filename;
        //            sliderCreateTbl.SliderStartDate = "";
        //            sliderCreateTbl.SliderStartTime = "";
        //            sliderCreateTbl.SliderLink = "";
        //            sliderCreateTbl.SliderEndDate = "";
        //            sliderCreateTbl.SliderEndTime = "";

        //            sliderCreateTbl.Create();

        //            Response.Redirect("slider.aspx");
        //        }
        //        else
        //            lblError.Text = "* please enter title of slide.";
        //    }
        //    else
        //        lblError.Text = "* please choose a picture first.";
       
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //int idElement = 0;string filenameUpdate = string.Empty;
        //if (Request.Cookies["idElement"] != null)
        //{
        //    //lblError.Text = Request.Cookies["idElement"].Value;
        //    idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        //}

        //tblSliderCollection sliderTbl = new tblSliderCollection();
        //sliderTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.id, CriteriaOperators.Equal, idElement));

        //filenameUpdate = sliderTbl[0].SliderPicName;

        //if (txtTitleUpdate.Text.Trim().Length > 0)
        //    sliderTbl[0].SliderTitle = txtTitleUpdate.Text;
        //else
        //    lblError.Visible = true;

        //sliderTbl[0].SliderDetail = txtDetailUpdate.Text;

        //// file upload start 
        //string filename = string.Empty;
        //if (IsPostBack)
        //{
        //    Boolean fileOK = false;
        //    String path = Server.MapPath("~/images/slider/");
        //    if (fuUpdate.HasFile)
        //    {
        //        String fileExtension = System.IO.Path.GetExtension(fuUpdate.FileName).ToLower();
        //        String[] allowedExtensions = { ".jpg" };
        //        for (int i = 0; i < allowedExtensions.Length; i++)
        //        {
        //            if (fileExtension == allowedExtensions[i])
        //            {
        //                fileOK = true;
        //            }
        //        }
        //    }

        //    if (fileOK)
        //    {
        //        try
        //        {
        //            fuUpdate.PostedFile.SaveAs(path + fuUpdate.FileName);
        //            filename = fuUpdate.FileName;
        //        }
        //        catch (Exception ex)
        //        {
        //            lblError.Text = "A promblem with uplouding picture";
        //        }
        //    }
        //    else
        //    {
        //        lblError.Text = "Not valid picture";
        //    }
        //}

        ////file upload end
        //if (filename.Length > 0)
        //    sliderTbl[0].SliderPicName = filename;
        //else
        //    sliderTbl[0].SliderPicName = filenameUpdate;

        //if (lblError.Visible == false)
        //{
        //    sliderTbl[0].Update();
        //    Response.Redirect("slider.aspx");
        //}
    }

    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        //int idElement = 0;
        //if (Request.Cookies["idElement"] != null)
        //{
        //    idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        //}

        //tblSliderCollection sliderTbl = new tblSliderCollection();
        //sliderTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.id, CriteriaOperators.Equal, idElement));

        //lblTitle.Text = sliderTbl[0].SliderTitle;

        //txtTitleUpdate.Text = sliderTbl[0].SliderTitle;
        //txtDetailUpdate.Text = sliderTbl[0].SliderDetail;

        //ScriptManager.RegisterStartupScript(this, GetType(), "myfunction", "open();", true);

    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        //int idElement = 0;
        //if (Request.Cookies["idElement"] != null)
        //{
        //    idElement = Int32.Parse(Request.Cookies["idElement"].Value);
        //}

        //tblSliderCollection sliderTbl = new tblSliderCollection();
        //sliderTbl.ReadList(Criteria.NewCriteria(tblSlider.Columns.id, CriteriaOperators.Equal, idElement));

        //sliderTbl[0].Delete();

        //Response.Redirect("slider.aspx");
    }

    protected void btnSave1_Click(object sender, EventArgs e)
    {
        tblGalleryPicturesCollection picsTbl = new tblGalleryPicturesCollection();
        picsTbl.ReadList();

        // file upload start 
        string filename = string.Empty;
        String fileExtension = "";
        if (IsPostBack)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/");
            if (fuFile1.HasFile)
            {
                fileExtension = System.IO.Path.GetExtension(fuFile1.FileName).ToLower();
                String[] allowedExtensions = { ".jpg" , ".bmp" , ".png" , ".git" , ".tiff" , ".tif" };
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
                    fuFile1.PostedFile.SaveAs(path + fuFile1.FileName);
                    filename = fuFile1.FileName;
                    picsTbl[0].GalleryPicName = filename;
                    picsTbl[0].Update();
                    Response.Redirect("main-bg.aspx");
                }
                catch (Exception ex)
                {
                    //lblError.Text = "A promblem with uplouding picture";
                }
            }
            else
            {
                //lblError.Text = "Not valid picture";
            }
        }

        //file upload end
    }

    protected void btnSave2_Click(object sender, EventArgs e)
    {
        tblGalleryPicturesCollection picsTbl = new tblGalleryPicturesCollection();
        picsTbl.ReadList();

        // file upload start 
        string filename = string.Empty;
        String fileExtension = "";
        if (IsPostBack)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/");
            if (fuFile2.HasFile)
            {
                fileExtension = System.IO.Path.GetExtension(fuFile2.FileName).ToLower();
                String[] allowedExtensions = { ".jpg", ".bmp", ".png", ".git", ".tiff", ".tif" };
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
                    fuFile2.PostedFile.SaveAs(path + fuFile2.FileName);
                    filename = fuFile2.FileName;
                    picsTbl[1].GalleryPicName = filename;
                    picsTbl[1].Update();
                    Response.Redirect("main-bg.aspx");
                }
                catch (Exception ex)
                {
                    //lblError.Text = "A promblem with uplouding picture";
                }
            }
            else
            {
                //lblError.Text = "Not valid picture";
            }
        }

        //file upload end
    }
}