using System;
using System.Web.UI;
using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using System.Web.UI.WebControls;
using Credentialing.Entities;

namespace Credentialing.Web.Dashboard
{
    public partial class Physician : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnStartForm.Click += btnStartForm_Click;

            if (!IsPostBack)
            {
                LoadData();
            }
        }

        #endregion [Protected methods]

        #region [Private methods]


        private void LoadData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid) user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                rptSteps.DataSource = StepsHelper.Instance.AppSteps;
                rptSteps.ItemDataBound += rptSteps_ItemDataBound;
                rptSteps.DataBind();
            }
        }

        private void rptSteps_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var data = (Step) e.Item.DataItem;
                var ltrPercentage = (Literal)e.Item.FindControl("ltrPercentage");
                var hlStep = (HyperLink)e.Item.FindControl("hlStep");

                ltrPercentage.Text = data.PercentComplete + "%";
                hlStep.Text = data.Name;
                hlStep.NavigateUrl = data.Url;
            }
        }

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Steps/Instructions.aspx", true);
            Response.End();
        }

        #endregion [Private methods]
    }
}