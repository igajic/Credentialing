using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class OtherStateMedicalProfessionalLicenses : Page
    {
        private const int CurrentStep = 10;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep - 1].Url, true);
            Response.End();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private Entities.Data.OtherStateMedicalProfessionalLicenses LoadUserData()
        {
            return null; // TODO: Implement this
        }

        private void SaveFormData()
        {
            // TODO: Implement
        }

        private bool ValidateFields()
        {
            return true; // TODO: Implement
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.OtherStateMedicalProfessionalLicenses();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertOtherStateMedicalProfessionalLicenses(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}