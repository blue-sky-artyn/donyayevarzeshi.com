using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;

public partial class admin_gallery_groups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string socialString = string.Empty;
        //tblSocialsCollection socialTbl = new tblSocialsCollection();
        //tblAdminsCollection usersTbl = new tblAdminsCollection();
        //usersTbl.ReadList();

        //if (!IsPostBack)
        //{
        //    for (int i = 0; i < usersTbl.Count; i++)
        //    {
        //        ddlUser.Items.Add(new ListItem(usersTbl[i].Name + usersTbl[i].Family, usersTbl[i].id.ToString()));
        //    }
        //}

        //for (int i = 0; i < usersTbl.Count; i++)
        //{
        //    socialString += "<h3 class='title1'>" + usersTbl[i].Name + " " + usersTbl[i].Family + "</h3>";
        //    socialTbl.ReadList(Criteria.NewCriteria(tblSocials.Columns.AdminId, CriteriaOperators.Equal, usersTbl[i].id));
        //    if (socialTbl.Count > 0)
        //        for (int j = 0; j < socialTbl.Count; j++)
        //        {

        //            socialString += "<div class='form-three widget-shadow'><div class='form-horizontal'><div class='form-group'>" +
        //                               "<label for='focusedinput' class='col-sm-2 control-label'>" + socialTbl[0].socialName + "</label><div class='col-sm-8'>" +
        //                               "<div class='col-sm-11'><p class='help-block'>" + socialTbl[0].socialLink + "</p></div>" +
        //                               "<a href='social-delete.aspx?socialId=" + socialTbl[0].id + "'>DEL</a></div></div></div></div>";
        //        }
               

        //}

        socialHtml.InnerHtml = socialString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //tblSocials socialTbl = new tblSocials();
        //if (txtSocialName.Text.Trim().Length > 0)
        //{
        //    socialTbl.AdminId = int.Parse(ddlUser.SelectedValue);
        //    socialTbl.socialName = txtSocialName.Text;
        //    socialTbl.socialLink = txtSocialLink.Text;
        //    socialTbl.socialiconAddr = "";

        //    socialTbl.Create();

        //    Response.Redirect("social.aspx");
        //}
        //else
        //    lblError.Text = "* Please fill out link title first";
    }
}