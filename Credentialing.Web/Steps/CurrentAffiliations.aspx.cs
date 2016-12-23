using System;
using System.Web.UI;
using Credentialing.Business.Helpers;
using Credentialing.Business.DataAccess;
using Credentialing.Entities.Data;
using System.IO;
using Credentialing.Entities;

namespace Credentialing.Web.Steps
{
    public partial class CurrentAffiliations : Page
    {
        private const int CurrentStep = 11;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;

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
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private Entities.Data.CurrentHospitalInstitutionalAffiliations LoadUserData()
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

        private void LoadFormData(Entities.Data.CurrentHospitalInstitutionalAffiliations data)
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

            tboxCurrentTertiaryAdmittingHospital.Text= data.CurrentTertiaryAdmittingHospital;
            tboxCurrentTertiaryDepartmentStatus.Text = data.CurrentTertiaryDepartmentStatus;
            tboxCurrentTertiaryAppointmentDate.Text = data.CurrentTertiaryAppointmentDate.HasValue ? data.CurrentTertiaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxCurrentTertiaryCity.Text = data.CurrentTertiaryCity;
            tboxCurrentTertiaryState.Text = data.CurrentTertiaryState;
            tboxCurrentTertiaryZip.Text = data.CurrentTertiaryZip;

            tboxPreviousPrimaryAdmittingHospital.Text = data.PreviousPrimaryAdmittingHospital;
            tboxPreviousPrimaryReasonLeaving.Text = data.PreviousPrimaryDepartmentStatus;
            tboxPreviousPrimaryFrom.Text = data.PreviousPrimaryAppointmentDate.HasValue ? data.PreviousPrimaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousPrimaryCity.Text = data.PreviousPrimaryCity;
            tboxPreviousPrimaryState.Text = data.PreviousPrimaryState;
            tboxPreviousPrimaryZip.Text = data.PreviousPrimaryZip;

            tboxPreviousSecondaryAdmittingHospital.Text = data.PreviousSecondaryAdmittingHospital;
            tboxPreviousSecondaryReasonLeaving.Text = data.PreviousSecondaryDepartmentStatus;
            tboxPreviousSecondaryFrom.Text = data.PreviousSecondaryAppointmentDate.HasValue ? data.PreviousSecondaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousSecondaryCity.Text = data.PreviousSecondaryCity;
            tboxPreviousSecondaryState.Text= data.PreviousSecondaryState;
            tboxPreviousSecondaryZip.Text = data.PreviousSecondaryZip;

            tboxPreviousTertiaryAdmittingHospital.Text = data.PreviousTertiaryAdmittingHospital;
            tboxPreviousTertiaryReasonLeaving.Text = data.PreviousTertiaryDepartmentStatus;
            tboxPreviousTertiaryFrom.Text = data.PreviousTertiaryAppointmentDate.HasValue ? data.PreviousTertiaryAppointmentDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPreviousTertiaryCity.Text = data.PreviousTertiaryCity;
            tboxPreviousTertiaryState.Text = data.PreviousTertiaryState;
            tboxPreviousTertiaryZip.Text = data.PreviousTertiaryZip;

        }

        private void SaveFormData()
        {

            var data = LoadUserData() ?? new Entities.Data.CurrentHospitalInstitutionalAffiliations();

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
            data.PreviousPrimaryCity = tboxPreviousPrimaryCity.Text;
            data.PreviousPrimaryState = tboxPreviousPrimaryState.Text;
            data.PreviousPrimaryZip = tboxPreviousPrimaryZip.Text;

            data.PreviousSecondaryAdmittingHospital = tboxPreviousSecondaryAdmittingHospital.Text;
            data.PreviousSecondaryDepartmentStatus = tboxPreviousSecondaryReasonLeaving.Text;
            data.PreviousSecondaryAppointmentDate = DateHelper.ParseFullDate(tboxPreviousSecondaryFrom.Text);
            data.PreviousSecondaryCity = tboxPreviousSecondaryCity.Text;
            data.PreviousSecondaryState = tboxPreviousSecondaryState.Text;
            data.PreviousSecondaryZip = tboxPreviousSecondaryZip.Text;

            data.PreviousTertiaryAdmittingHospital = tboxPreviousTertiaryAdmittingHospital.Text;
            data.PreviousTertiaryDepartmentStatus = tboxPreviousTertiaryReasonLeaving.Text;
            data.PreviousTertiaryAppointmentDate = DateHelper.ParseFullDate(tboxPreviousTertiaryFrom.Text);
            data.PreviousTertiaryCity = tboxPreviousTertiaryCity.Text;
            data.PreviousTertiaryState = tboxPreviousTertiaryState.Text;
            data.PreviousTertiaryZip = tboxPreviousTertiaryZip.Text;

            // TODO: Check if this is needed
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

                    //data.AttachedDocuments.Add(attachment);
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
                retVal = ValidationHelper.ValidateShortDate(tboxCurrentPrimaryAppointmentDate);
            }
            
            if (!string.IsNullOrWhiteSpace(tboxCurrentSecondaryAppointmentDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxCurrentSecondaryAppointmentDate);
            }
            
            if (!string.IsNullOrWhiteSpace(tboxCurrentTertiaryAppointmentDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxCurrentTertiaryAppointmentDate);
            }
            
            if (!string.IsNullOrWhiteSpace(tboxPreviousPrimaryFrom.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousPrimaryFrom);
            }
            
            if (!string.IsNullOrWhiteSpace(tboxPreviousSecondaryFrom.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousSecondaryFrom);
            }
            
            if (!string.IsNullOrWhiteSpace(tboxPreviousTertiaryFrom.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPreviousTertiaryFrom);
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.CurrentHospitalInstitutionalAffiliations();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertCurrentHospitalInstitutionalAffiliations(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}