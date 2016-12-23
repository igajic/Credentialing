using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class BoardCertification : Page
    {
        private const int CurrentStep = 7;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                //   LoadFormData(data);
            }
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
                // SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private Entities.Data.BoardCertification LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.OtherCertification != null)
                {
                    return physicianFormData.BoardCertification;
                }
            }

            return null;
        }

        private void SaveFormData()
        {
            var formData = new Entities.Data.BoardCertification();

            formData.PrimaryNameIssuingBoard = tboxPrimaryNameIssuingBoard.Text;
            formData.PrimarySpecialty = tboxPrimarySpecialty.Text;

            formData.PrimaryDateCertifiedRecertified = string.IsNullOrWhiteSpace(tboxPrimaryDateCertifiedRecertified.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxPrimaryDateCertifiedRecertified.Text);
            formData.PrimaryExpirationDate = string.IsNullOrWhiteSpace(tboxPrimaryExpirationDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxPrimaryExpirationDate.Text);

            formData.SecondaryNameIssuingBoard = tboxSecondaryNameIssuingBoard.Text;
            formData.SecondarySpecialty = tboxSecondarySpecialty.Text;
            formData.SecondaryDateCertifiedRecertified = string.IsNullOrWhiteSpace(tboxSecondaryDateCertifiedRecertified.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxSecondaryDateCertifiedRecertified.Text);
            formData.SecondaryExpirationDate = string.IsNullOrWhiteSpace(tboxSecondaryExpirationDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxSecondaryExpirationDate.Text);

            formData.TertiaryNameIssuingBoard = tboxTertiaryNameIssuingBoard.Text;
            formData.TertiarySpecialty = tboxTertiarySpecialty.Text;
            formData.TertiaryDateCertifiedRecertified = string.IsNullOrWhiteSpace(tboxTertiaryDateCertifiedRecertified.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxTertiaryDateCertifiedRecertified.Text);
            formData.TertiaryExpirationDate = string.IsNullOrWhiteSpace(tboxTertiaryExpirationDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxTertiaryExpirationDate.Text);

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertBoardCertification(formData, userId);
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxPrimaryDateCertifiedRecertified.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPrimaryDateCertifiedRecertified) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPrimaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPrimaryExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondaryDateCertifiedRecertified.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxSecondaryDateCertifiedRecertified) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxSecondaryExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxTertiaryDateCertifiedRecertified.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxTertiaryDateCertifiedRecertified) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxTertiaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxTertiaryExpirationDate) && retVal;
            }

            return retVal;
        }

        private void LoadFormData(Entities.Data.BoardCertification formData)
        {
            if (formData == null) return;

            tboxPrimaryNameIssuingBoard.Text = formData.PrimaryNameIssuingBoard;
            tboxPrimarySpecialty.Text = formData.PrimarySpecialty;
            tboxPrimaryDateCertifiedRecertified.Text = formData.PrimaryDateCertifiedRecertified.HasValue ? formData.PrimaryDateCertifiedRecertified.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPrimaryExpirationDate.Text = formData.PrimaryExpirationDate.HasValue ? formData.PrimaryExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxSecondaryNameIssuingBoard.Text = formData.SecondaryNameIssuingBoard;
            tboxSecondarySpecialty.Text = formData.SecondarySpecialty;
            tboxSecondaryDateCertifiedRecertified.Text = formData.SecondaryDateCertifiedRecertified.HasValue ? formData.SecondaryDateCertifiedRecertified.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxSecondaryExpirationDate.Text = formData.SecondaryExpirationDate.HasValue ? formData.SecondaryExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxTertiaryNameIssuingBoard.Text = formData.TertiaryNameIssuingBoard;
            tboxTertiarySpecialty.Text = formData.TertiarySpecialty;
            tboxTertiaryDateCertifiedRecertified.Text = formData.TertiaryDateCertifiedRecertified.HasValue ? formData.TertiaryDateCertifiedRecertified.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxTertiaryExpirationDate.Text = formData.TertiaryExpirationDate.HasValue ? formData.TertiaryExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
        }

        #endregion [Private methods]
    }
}