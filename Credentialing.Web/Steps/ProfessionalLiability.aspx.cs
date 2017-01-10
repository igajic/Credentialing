using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using System;
using System.Globalization;
using System.Web.UI;

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
            lbReview.Click += lbReview_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                LoadFormData(data);
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
                SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private Entities.Data.ProfessionalLiability LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.ProfessionalLiability != null)
                {
                    return physicianFormData.ProfessionalLiability;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.ProfessionalLiability data)
        {
            if (data == null) return;

            tboxCurrentInsuranceCarrier.Text = data.CurrentInsuranceCarrier;
            tboxCurrentPolicyNumber.Text = data.CurrentPolicyNumber;
            tboxCurrentMailingNumber.Text = data.CurrentMailingAddress;
            tboxCurrentCity.Text = data.CurrentCity;
            tboxCurrentState.Text = data.CurrentState;
            tboxCurrentZip.Text = data.CurrentZip;

            tboxCurrentExpirationDate.Text = data.InitialEffectiverDate.HasValue ? data.InitialEffectiverDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxCurrentExpirationDate.Text = data.CurrentExpirationDate.HasValue ? data.CurrentExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxCurrentPerClaimAmount.Text = data.CurrentPerClaimAmount.HasValue ? data.CurrentPerClaimAmount.Value.ToString(new CultureInfo("en-US")) : string.Empty;
            tboxCurrentAggregateAmount.Text = data.CurrentAggregateAmount.HasValue ? data.CurrentAggregateAmount.Value.ToString(new CultureInfo("en-US")) : string.Empty;

            tboxFirstPolicyCarrierName.Text = data.FirstPolicyCarrierName;
            tboxFirstPolicyNumber.Text = data.FirstPolicyNumber;
            tboxFirstMailingAddress.Text = data.FirstMailingAddress;
            tboxFirstCity.Text = data.FirstCity;
            tboxFirstState.Text = data.FirstState;
            tboxFirstZip.Text = data.FirstZip;
            tboxFirstFromDate.Text = data.FirstFromDate.HasValue ? data.FirstFromDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxFirstToDate.Text = data.FirstToDate.HasValue ? data.FirstToDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxSecondPolicyCarrierName.Text = data.SecondPolicyCarrierName;
            tboxSecondPolicyNumber.Text = data.SecondPolicyNumber;
            tboxSecondMailingAddress.Text = data.SecondMailingAddress;
            tboxSecondCity.Text = data.SecondCity;
            tboxSecondState.Text = data.SecondState;
            tboxSecondZip.Text = data.SecondZip;
            tboxSecondFromDate.Text = data.SecondFromDate.HasValue ? data.SecondFromDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxSecondToDate.Text = data.SecondToDate.HasValue ? data.SecondToDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxThirdPolicyCarrierName.Text = data.ThirdPolicyCarrierName;
            tboxThirdPolicyNumber.Text = data.ThirdPolicyNumber;
            tboxThirdMailingAddress.Text = data.ThirdMailingAddress;
            tboxThirdCity.Text = data.ThirdCity;
            tboxThirdState.Text = data.ThirdState;
            tboxThirdZip.Text = data.ThirdZip;
            tboxThirdFromDate.Text = data.ThirdFromDate.HasValue ? data.ThirdFromDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxThirdToDate.Text = data.ThirdToDate.HasValue ? data.ThirdToDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxFourthPolicyCarrierName.Text = data.FourthPolicyCarrierName;
            tboxFourthPolicyNumber.Text = data.FourthPolicyNumber;
            tboxFourthMailingAddress.Text = data.FourthMailingAddress;
            tboxFourthCity.Text = data.FourthCity;
            tboxFourthState.Text = data.FourthState;
            tboxFourthZip.Text = data.FourthZip;
            tboxFourthFromDate.Text = data.FourthFromDate.HasValue ? data.FourthFromDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxFourthToDate.Text = data.FourthToDate.HasValue ? data.FourthToDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
        }

        private void SaveFormData()
        {
            var data = LoadUserData() ?? new Entities.Data.ProfessionalLiability();

            data.CurrentInsuranceCarrier = tboxCurrentInsuranceCarrier.Text;
            data.CurrentPolicyNumber = tboxCurrentPolicyNumber.Text;
            data.InitialEffectiverDate = DateHelper.ParseFullDate(tboxCurrentExpirationDate.Text);
            data.CurrentMailingAddress = tboxCurrentMailingNumber.Text;
            data.CurrentCity = tboxCurrentCity.Text;
            data.CurrentState = tboxCurrentState.Text;
            data.CurrentZip = tboxCurrentZip.Text;
            data.CurrentPerClaimAmount = NumberHelper.ParseDecimal(tboxCurrentPerClaimAmount.Text);
            data.CurrentAggregateAmount = NumberHelper.ParseDecimal(tboxCurrentAggregateAmount.Text);
            data.CurrentExpirationDate = DateHelper.ParseFullDate(tboxCurrentExpirationDate.Text);

            data.FirstPolicyCarrierName = tboxFirstPolicyCarrierName.Text;
            data.FirstPolicyNumber = tboxFirstPolicyNumber.Text;
            data.FirstMailingAddress = tboxFirstMailingAddress.Text;
            data.FirstCity = tboxFirstCity.Text;
            data.FirstState = tboxFirstState.Text;
            data.FirstZip = tboxFirstZip.Text;
            data.FirstFromDate = DateHelper.ParseFullDate(tboxFirstFromDate.Text);
            data.FirstToDate = DateHelper.ParseFullDate(tboxFirstToDate.Text);

            data.SecondPolicyCarrierName = tboxSecondPolicyCarrierName.Text;
            data.SecondPolicyNumber = tboxSecondPolicyNumber.Text;
            data.SecondMailingAddress = tboxSecondMailingAddress.Text;
            data.SecondCity = tboxSecondCity.Text;
            data.SecondState = tboxSecondState.Text;
            data.SecondZip = tboxSecondZip.Text;
            data.SecondFromDate = DateHelper.ParseFullDate(tboxSecondFromDate.Text);
            data.SecondToDate = DateHelper.ParseFullDate(tboxSecondToDate.Text);

            data.ThirdPolicyCarrierName = tboxThirdPolicyCarrierName.Text;
            data.ThirdPolicyNumber = tboxThirdPolicyNumber.Text;
            data.ThirdMailingAddress = tboxThirdMailingAddress.Text;
            data.ThirdCity = tboxThirdCity.Text;
            data.ThirdState = tboxThirdState.Text;
            data.ThirdZip = tboxThirdZip.Text;
            data.ThirdFromDate = DateHelper.ParseFullDate(tboxThirdFromDate.Text);
            data.ThirdToDate = DateHelper.ParseFullDate(tboxThirdToDate.Text);

            data.FourthPolicyCarrierName = tboxFourthPolicyCarrierName.Text;
            data.FourthPolicyNumber = tboxFourthPolicyNumber.Text;
            data.FourthMailingAddress = tboxFourthMailingAddress.Text;
            data.FourthCity = tboxFourthCity.Text;
            data.FourthState = tboxFourthState.Text;
            data.FourthZip = tboxFourthZip.Text;
            data.FourthFromDate = DateHelper.ParseFullDate(tboxFourthFromDate.Text);
            data.FourthToDate = DateHelper.ParseFullDate(tboxFourthToDate.Text);

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertProfessionalLiability(data, userId);
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxCurrentPerClaimAmount.Text))
            {
                retVal = ValidationHelper.ValidateDecimal(tboxCurrentPerClaimAmount);
            }

            if (!string.IsNullOrWhiteSpace(tboxCurrentPerClaimAmount.Text))
            {
                retVal = ValidationHelper.ValidateDecimal(tboxCurrentPerClaimAmount);
            }

            if (!string.IsNullOrWhiteSpace(tboxCurrentAggregateAmount.Text))
            {
                retVal = ValidationHelper.ValidateDecimal(tboxCurrentAggregateAmount);
            }

            if (!string.IsNullOrWhiteSpace(tboxCurrentExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxCurrentExpirationDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxFirstFromDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxFirstFromDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxFirstToDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxFirstToDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondFromDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxSecondFromDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondToDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxSecondToDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxThirdFromDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxThirdFromDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxThirdToDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxThirdToDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxFourthFromDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxFourthFromDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxFourthToDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxFourthToDate);
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.ProfessionalLiability();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertProfessionalLiability(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}