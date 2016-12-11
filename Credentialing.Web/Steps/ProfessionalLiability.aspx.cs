using System;
using System.Web.UI;
using Credentialing.Business.Helpers;

namespace Credentialing.Web.Steps
{
    public partial class ProfessionalLiability : Page
    {
        private const int CurrentStep = 11;

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

        private void SaveFormData()
        {
            // TODO: Implement this
        }

        private bool ValidateFields()
        {
            return true; // TODO: Implement this
        }

        #endregion [Private methods]
    }
}