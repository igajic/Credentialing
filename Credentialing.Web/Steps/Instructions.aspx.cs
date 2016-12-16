using System;
using System.Web.UI;
using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;

namespace Credentialing.Web.Steps
{
    public partial class Instructions : Page
    {
        private int CurrentStep = 0;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;

            PracticionerApplication physicianFormData = null;
            
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid) user.ProviderUserKey);

                StepsHelper.Instance.UpdateSteps(physicianFormData);
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
            Response.End();
        }

        #endregion [Private methods]
    }
}