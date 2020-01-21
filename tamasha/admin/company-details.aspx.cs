using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_company_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tblCompanyCollection coDetails = new tblCompanyCollection();
        coDetails.ReadList();

        if (!IsPostBack)
        {
            if (coDetails.Count > 0)
            {
                txtCoName.Text = coDetails[0].CoName;
                txtCoOwner.Text = coDetails[0].CoOwner;
                txtCoOwnerWords.Text = coDetails[0].CoOwnerWord;

                txtLat.Text = coDetails[0].CoLocA;
                txtLong.Text = coDetails[0].CoLocB;

                txtAddr.Text = coDetails[0].CoAddr;
                txtPhone.Text = coDetails[0].Tel;
                txtFax.Text = coDetails[0].Phone;

                txtInstagram.Text = coDetails[0].Instagram;
                txtTwitter.Text = coDetails[0].Twitter;
                txtLinkedin.Text = coDetails[0].Linkedin;
                txtFabook.Text = coDetails[0].Facebook;
                txtYoutube.Text = coDetails[0].youtube;

                txtEmail.Text = coDetails[0].Email;
                txtWebsite.Text = coDetails[0].website;
                txtDetails.Text = coDetails[0].CoDetail;
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string errorMsg = string.Empty;

        tblCompany companyNewTbl = new tblCompany();

        tblCompanyCollection compDetailsTbl = new tblCompanyCollection();
        compDetailsTbl.ReadList();

        try
        {
            if (compDetailsTbl.Count > 0)
            {
                if (txtCoName.Text.Length > 0)
                    compDetailsTbl[0].CoName = txtCoName.Text;
                else
                    errorMsg = "* Please fill out the company name <br />";

                if (txtAddr.Text.Length > 0)
                    compDetailsTbl[0].CoAddr = txtAddr.Text;
                else
                    errorMsg += "* Please fill out the address <br />";

                compDetailsTbl[0].CoOwner = txtCoOwner.Text;
                compDetailsTbl[0].CoOwnerWord = txtCoOwnerWords.Text;
                compDetailsTbl[0].CoLocA = txtLat.Text;
                compDetailsTbl[0].CoLocB = txtLong.Text;

                compDetailsTbl[0].Tel = txtPhone.Text;
                compDetailsTbl[0].Phone = txtFax.Text;
                compDetailsTbl[0].SocialNumber = txtSocialNo.Text;
                compDetailsTbl[0].Email = txtEmail.Text;
                compDetailsTbl[0].Instagram = txtInstagram.Text;
                compDetailsTbl[0].youtube = txtYoutube.Text;
                compDetailsTbl[0].Twitter = txtTwitter.Text;
                compDetailsTbl[0].Linkedin = txtLinkedin.Text;
                compDetailsTbl[0].Facebook = txtFabook.Text;
                compDetailsTbl[0].GooglePlus = txtGoogle.Text;
                compDetailsTbl[0].website = txtWebsite.Text;
                compDetailsTbl[0].CoDetail = txtDetails.Text;

                //compDetailsTbl.UpdateList(true);
                if (errorMsg.Length <= 0)
                    compDetailsTbl[0].Update();
                else
                    errorMsg = "Please fill out requred filds";
            }
            else
            {
                if (txtCoName.Text.Length > 0)
                    companyNewTbl.CoName = txtCoName.Text;
                else
                    errorMsg = "* Please fill out the company name <br />";

                if (txtAddr.Text.Length > 0)
                    companyNewTbl.CoAddr = txtAddr.Text;
                else
                    errorMsg += "* Please fill out the address <br />";
                    
                companyNewTbl.CoOwner = txtCoOwner.Text;
                companyNewTbl.CoLocA = txtLat.Text;
                companyNewTbl.CoLocB = txtLong.Text;

                companyNewTbl.Tel = txtPhone.Text;
                companyNewTbl.Phone = txtFax.Text;
                companyNewTbl.SocialNumber = txtSocialNo.Text;
                companyNewTbl.Email = txtEmail.Text;
                companyNewTbl.Instagram = txtInstagram.Text;
                companyNewTbl.youtube = txtYoutube.Text;
                companyNewTbl.Twitter = txtTwitter.Text;
                companyNewTbl.Linkedin = txtLinkedin.Text;
                companyNewTbl.Facebook = txtFabook.Text;
                companyNewTbl.GooglePlus = txtGoogle.Text;
                companyNewTbl.website = txtWebsite.Text;
                companyNewTbl.CoDetail = txtDetails.Text;

                //compDetailsTbl.UpdateList(true);
                if (errorMsg.Length <= 0)
                    companyNewTbl.Create();
                else
                    errorMsg = "Please fill out requred filds";
            }
            ErrorMassage.InnerHtml = "Update is successfully done";

        }
        catch (Exception ex)
        {
            ErrorMassage.InnerHtml = errorMsg + " (" + ex + " )";
            //throw;
        }

    }
}