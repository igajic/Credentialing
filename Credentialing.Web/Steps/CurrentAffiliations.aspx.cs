using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class CurrentAffiliations : Page
    {
        private const int CurrentStep = 12;

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

        private CurrentHospitalInstitutionalAffiliations LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.CurrentHospitalInstitutionalAffiliations != null)
                {
                    return physicianFormData.CurrentHospitalInstitutionalAffiliations;
                }
            }

            return null;
        }

        private void LoadFormData(CurrentHospitalInstitutionalAffiliations data)
        {
            if (data == null) return;

            tboxCurrentPrimaryAdmittingHospital.Text = data.CurrentPrimaryAdmittingHospital;
            tboxCurrentPrimaryDepartmentStatus.Text = data.CurrentPrimaryDepartmentStatus;
            tboxCurrentPrimaryAppointmentDate.Text = data.CurrentPrimaryAppointmentDate.HasValue ? data.CurrentPrimaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxCurrentPrimaryCity.Text = data.CurrentPrimaryCity;
            tboxCurrentPrimaryState.Text = data.CurrentPrimaryState;
            tboxCurrentPrimaryZip.Text = data.CurrentPrimaryZip;

            tboxCurrentSecondaryAdmittingHospital.Text = data.CurrentSecondaryAdmittingHospital;
            tboxCurrentSecondaryDepartmentStatus.Text = data.CurrentSecondaryDepartmentStatus;
            tboxCurrentSecondaryAppointmentDate.Text = data.CurrentSecondaryAppointmentDate.HasValue ? data.CurrentSecondaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxCurrentSecondaryCity.Text = data.CurrentSecondaryCity;
            tboxCurrentSecondaryState.Text = data.CurrentSecondaryState;
            tboxCurrentSecondaryZip.Text = data.CurrentSecondaryZip;

            tboxCurrentTertiaryAdmittingHospital.Text = data.CurrentTertiaryAdmittingHospital;
            tboxCurrentTertiaryDepartmentStatus.Text = data.CurrentTertiaryDepartmentStatus;
            tboxCurrentTertiaryAppointmentDate.Text = data.CurrentTertiaryAppointmentDate.HasValue ? data.CurrentTertiaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxCurrentTertiaryCity.Text = data.CurrentTertiaryCity;
            tboxCurrentTertiaryState.Text = data.CurrentTertiaryState;
            tboxCurrentTertiaryZip.Text = data.CurrentTertiaryZip;

            tboxPreviousPrimaryAdmittingHospital.Text = data.PreviousPrimaryAdmittingHospital;
            tboxPreviousPrimaryReasonLeaving.Text = data.PreviousPrimaryDepartmentStatus;
            tboxPreviousPrimaryFrom.Text = data.PreviousPrimaryAppointmentDate.HasValue ? data.PreviousPrimaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousPrimaryTo.Text = data.PreviousPrimaryAppointmentDateTo.HasValue ? data.PreviousPrimaryAppointmentDateTo.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousPrimaryCity.Text = data.PreviousPrimaryCity;
            tboxPreviousPrimaryState.Text = data.PreviousPrimaryState;
            tboxPreviousPrimaryZip.Text = data.PreviousPrimaryZip;

            tboxPreviousSecondaryAdmittingHospital.Text = data.PreviousSecondaryAdmittingHospital;
            tboxPreviousSecondaryReasonLeaving.Text = data.PreviousSecondaryDepartmentStatus;
            tboxPreviousSecondaryFrom.Text = data.PreviousSecondaryAppointmentDate.HasValue ? data.PreviousSecondaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousSecondaryTo.Text = data.PreviousSecondaryAppointmentDateTo.HasValue ? data.PreviousSecondaryAppointmentDateTo.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousSecondaryCity.Text = data.PreviousSecondaryCity;
            tboxPreviousSecondaryState.Text = data.PreviousSecondaryState;
            tboxPreviousSecondaryZip.Text = data.PreviousSecondaryZip;

            tboxPreviousTertiaryAdmittingHospital.Text = data.PreviousTertiaryAdmittingHospital;
            tboxPreviousTertiaryReasonLeaving.Text = data.PreviousTertiaryDepartmentStatus;
            tboxPreviousTertiaryFrom.Text = data.PreviousTertiaryAppointmentDate.HasValue ? data.PreviousTertiaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousTertiaryTo.Text = data.PreviousTertiaryAppointmentDateTo.HasValue ? data.PreviousTertiaryAppointmentDateTo.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousTertiaryCity.Text = data.PreviousTertiaryCity;
            tboxPreviousTertiaryState.Text = data.PreviousTertiaryState;
            tboxPreviousTertiaryZip.Text = data.PreviousTertiaryZip;

            ucAttachments.Attachments = data.Attachments;
        }

        private void SaveFormData()
        {
            var data = LoadUserData() ?? new CurrentHospitalInstitutionalAffiliations();

            data.CurrentPrimaryAdmittingHospital = tboxCurrentPrimaryAdmittingHospital.Text;
            data.CurrentPrimaryDepartmentStatus = tboxCurrentPrimaryDepartmentStatus.Text;
            data.CurrentPrimaryAppointmentDate = DateHelper.ParseFullDate(tboxCurrentPrimaryAppointmentDate.Text);
            data.CurrentPrimaryCity = tboxCurrentPrimaryCity.Text;
            data.CurrentPrimaryState = tboxCurrentPrimaryState.Text;
            data.CurrentPrimaryZip = tboxCurrentPrimaryZip.Text;

            data.CurrentSecondaryAdmittingHospital = tboxCurrentSecondaryAdmittingHospital.Text;
            data.CurrentSecondaryDepartmentStatus = tboxCurrentSecondaryDepartmentStatus.Text;
            data.CurrentSecondaryAppointmentDate = DateHelper.ParseFullDate(tboxCurrentSecondaryAppointmentDate.Text);
            data.CurrentSecondaryCity = tboxCurrentSecondaryCity.Text;
            data.CurrentSecondaryState = tboxCurrentSecondaryState.Text;
            data.CurrentSecondaryZip = tboxCurrentSecondaryZip.Text;

            data.CurrentTertiaryAdmittingHospital = tboxCurrentTertiaryAdmittingHospital.Text;
            data.CurrentTertiaryDepartmentStatus = tboxCurrentTertiaryDepartmentStatus.Text;
            data.CurrentTertiaryAppointmentDate = DateHelper.ParseFullDate(tboxCurrentTertiaryAppointmentDate.Text);
            data.CurrentTertiaryCity = tboxCurrentTertiaryCity.Text;
            data.CurrentTertiaryState = tboxCurrentTertiaryState.Text;
            data.CurrentTertiaryZip = tboxCurrentTertiaryZip.Text;

            data.PreviousPrimaryAdmittingHospital = tboxPreviousPrimaryAdmittingHospital.Text;
            data.PreviousPrimaryDepartmentStatus = tboxPreviousPrimaryReasonLeaving.Text;
            data.PreviousPrimaryAppointmentDate = DateHelper.ParseFullDate(tboxPreviousPrimaryFrom.Text);
            data.PreviousPrimaryAppointmentDateTo = DateHelper.ParseFullDate(tboxPreviousPrimaryTo.Text);
            data.PreviousPrimaryCity = tboxPreviousPrimaryCity.Text;
            data.PreviousPrimaryState = tboxPreviousPrimaryState.Text;
            data.PreviousPrimaryZip = tboxPreviousPrimaryZip.Text;

            data.PreviousSecondaryAdmittingHospital = tboxPreviousSecondaryAdmittingHospital.Text;
            data.PreviousSecondaryDepartmentStatus = tboxPreviousSecondaryReasonLeaving.Text;
            data.PreviousSecondaryAppointmentDate = DateHelper.ParseFullDate(tboxPreviousSecondaryFrom.Text);
            data.PreviousSecondaryAppointmentDateTo = DateHelper.ParseFullDate(tboxPreviousSecondaryTo.Text);
            data.PreviousSecondaryCity = tboxPreviousSecondaryCity.Text;
            data.PreviousSecondaryState = tboxPreviousSecondaryState.Text;
            data.PreviousSecondaryZip = tboxPreviousSecondaryZip.Text;

            data.PreviousTertiaryAdmittingHospital = tboxPreviousTertiaryAdmittingHospital.Text;
            data.PreviousTertiaryDepartmentStatus = tboxPreviousTertiaryReasonLeaving.Text;
            data.PreviousTertiaryAppointmentDate = DateHelper.ParseFullDate(tboxPreviousTertiaryFrom.Text);
            data.PreviousTertiaryAppointmentDateTo = DateHelper.ParseFullDate(tboxPreviousTertiaryTo.Text);
            data.PreviousTertiaryCity = tboxPreviousTertiaryCity.Text;
            data.PreviousTertiaryState = tboxPreviousTertiaryState.Text;
            data.PreviousTertiaryZip = tboxPreviousTertiaryZip.Text;

            if (fuAttachments.HasFiles)
            {
                foreach (var file in fuAttachments.PostedFiles)
                {
                    var attachment = new Attachment
                    {
                        FileName = file.FileName
                    };

                    using (MemoryStream ms = new MemoryStream())
                    {
                        file.InputStream.CopyTo(ms);
                        attachment.Content = ms.ToArray();
                    }

                    data.Attachments.Add(attachment);
                }
            }

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertCurrentHospitalInstitutionalAffiliations(data, userId);
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxCurrentPrimaryAppointmentDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxCurrentPrimaryAppointmentDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxCurrentSecondaryAppointmentDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxCurrentSecondaryAppointmentDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxCurrentTertiaryAppointmentDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxCurrentTertiaryAppointmentDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPreviousPrimaryFrom.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousPrimaryFrom) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPreviousPrimaryTo.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousPrimaryTo) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPreviousSecondaryFrom.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousSecondaryFrom) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPreviousSecondaryTo.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousSecondaryTo) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPreviousTertiaryFrom.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousTertiaryFrom) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxPreviousTertiaryTo.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousTertiaryTo) && retVal;
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new CurrentHospitalInstitutionalAffiliations();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertCurrentHospitalInstitutionalAffiliations(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}