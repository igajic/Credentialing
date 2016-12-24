using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class PeerReferences : Page
    {
        private const int CurrentStep = 13;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;
            lbReview.Click += lbReview_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                //LoadFormData(data);
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep - 1].Url, true);
            Response.End();

            if (!IsPostBack)
            {
                var data = LoadUserData();

                //LoadFormData(data);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //SaveFormData();
            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
            Response.End();
        }

        private Entities.Data.PeerReferences LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.Education != null)
                {
                    return physicianFormData.PeerReferences;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.PeerReferences data)
        {
            if (data == null) return;

            tboxPrimaryNameReference.Text = data.PrimaryNameReference;
            tboxPrimarySpecialty.Text = data.PrimarySpecialty;
            tboxPrimaryTelephoneNumber.Text = data.PrimaryTelephoneNumber;
            tboxPrimaryMailingAddress.Text = data.PrimaryMailingAddress;
            tboxPrimaryCity.Text = data.PrimaryCity;
            tboxPrimaryState.Text = data.PrimaryState;
            tboxPrimaryZip.Text = data.PrimaryZip;

            tboxSecondaryNameReference.Text = data.SecondaryNameReference;
            tboxSecondarySpecialty.Text = data.SecondarySpecialty;
            tboxSecondaryTelephoneNumber.Text = data.SecondaryTelephoneNumber;
            tboxSecondaryMailingAddress.Text = data.SecondaryMailingAddress;
            tboxSecondaryCity.Text = data.SecondaryCity;
            tboxSecondaryState.Text = data.SecondaryState;
            tboxSecondaryZip.Text = data.SecondaryZip;

            tboxTertiaryNameReference.Text = data.TertiaryNameReference;
            tboxTertiarySpecialty.Text = data.TertiarySpecialty;
            tboxTertiaryTelephoneNumber.Text = data.TertiaryTelephoneNumber;
            tboxTertiaryMailingAddress.Text = data.TertiaryMailingAddress;
            tboxTertiaryCity.Text = data.TertiaryCity;
            tboxTertiaryState.Text = data.TertiaryState;
            tboxTertiaryZip.Text = data.TertiaryZip;
        }

        private void SaveFormData()
        {
            var data = LoadUserData() ?? new Entities.Data.PeerReferences();

            data.PrimaryNameReference = tboxPrimaryNameReference.Text;
            data.PrimarySpecialty = tboxPrimarySpecialty.Text;
            data.PrimaryTelephoneNumber = tboxPrimaryTelephoneNumber.Text;
            data.PrimaryMailingAddress = tboxPrimaryMailingAddress.Text;
            data.PrimaryCity = tboxPrimaryCity.Text;
            data.PrimaryState = tboxPrimaryState.Text;
            data.PrimaryZip = tboxPrimaryZip.Text;

            data.SecondaryNameReference = tboxSecondaryNameReference.Text;
            data.SecondarySpecialty = tboxSecondarySpecialty.Text;
            data.SecondaryTelephoneNumber = tboxSecondaryTelephoneNumber.Text;
            data.SecondaryMailingAddress = tboxSecondaryMailingAddress.Text;
            data.SecondaryCity = tboxSecondaryCity.Text;
            data.SecondaryState = tboxSecondaryState.Text;
            data.SecondaryZip = tboxSecondaryZip.Text;

            data.TertiaryNameReference = tboxTertiaryNameReference.Text;
            data.TertiarySpecialty = tboxTertiarySpecialty.Text;
            data.TertiaryTelephoneNumber = tboxTertiaryTelephoneNumber.Text;
            data.TertiaryMailingAddress = tboxTertiaryMailingAddress.Text;
            data.TertiaryCity = tboxTertiaryCity.Text;
            data.TertiaryState = tboxTertiaryState.Text;
            data.TertiaryZip = tboxTertiaryZip.Text;

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertPeerReferences(data, userId);
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.PeerReferences();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertPeerReferences(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}