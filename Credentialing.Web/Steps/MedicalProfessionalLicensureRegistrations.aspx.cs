using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class MedicalProfessionalLicensureRegistrations : Page
    {
        private const int CurrentStep = 9;

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

        private void SaveFormData()
        {
            var data = new Entities.Data.MedicalProfessionalLicensureRegistrations();

            data.PrimaryStateMedicalLicenseNumber = tboxPrimaryStateMedicalLicenseNumber.Text;
            data.PrimaryStateMedicalLicenseIssueDate = DateHelper.ParseFullDate(tboxIssueDate.Text);
            data.PrimaryStateMedicalLicenseExpirationDate = DateHelper.ParseFullDate(tboxPrimaryStateMedicalLicenseExpirationDate.Text);

            data.DrugAdministrationNumber = tboxDrugAdministrationNumber.Text;
            data.DrugAdministrationExpirationDate = DateHelper.ParseFullDate(tboxDrugAdministrationExpirationDate.Text);

            data.StateControlledSubstancesCertificate = tboxStateControlledSubstancesCertificate.Text;
            data.StateControlledSubstancesCertificateExpirationDate = DateHelper.ParseFullDate(tboxStateControlledSubstancesCertificateExpirationDate.Text);

            data.ECFMGNumber = tboxECFMGNumber.Text;
            data.ECFMGNumberIssueDate = DateHelper.ParseFullDate(tboxECFMGNumberIssueDate.Text);

            data.MedicareNationalPhysicianIdentifier = tboxMedicareNationalPhysicianIdentifier.Text;
            data.MedicaidNumber = tboxMedicaidNumber.Text;

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

            PracticionersApplicationHandler.Instance.UpsertMedicalProfessionalLicensureRegistrations(data, userId);
        }

        private void LoadFormData(Entities.Data.MedicalProfessionalLicensureRegistrations data)
        {
            tboxPrimaryStateMedicalLicenseNumber.Text = data.PrimaryStateMedicalLicenseNumber;
            tboxIssueDate.Text = data.PrimaryStateMedicalLicenseIssueDate == null ? string.Empty : data.PrimaryStateMedicalLicenseIssueDate.Value.ToString(Constants.DateFormats.FullDateFormat);
            tboxPrimaryStateMedicalLicenseExpirationDate.Text = data.PrimaryStateMedicalLicenseExpirationDate == null ? string.Empty : data.PrimaryStateMedicalLicenseExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat);

            tboxDrugAdministrationNumber.Text = data.DrugAdministrationNumber;
            tboxDrugAdministrationExpirationDate.Text = data.DrugAdministrationExpirationDate == null ? string.Empty : data.DrugAdministrationExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat);

            tboxStateControlledSubstancesCertificate.Text = data.StateControlledSubstancesCertificate;
            tboxStateControlledSubstancesCertificateExpirationDate.Text = data.StateControlledSubstancesCertificateExpirationDate == null ? string.Empty : data.StateControlledSubstancesCertificateExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat);

            tboxECFMGNumber.Text = data.ECFMGNumber;
            tboxECFMGNumberIssueDate.Text = data.ECFMGNumberIssueDate == null ? string.Empty : data.ECFMGNumberIssueDate.Value.ToString(Constants.DateFormats.FullDateFormat);

            tboxMedicareNationalPhysicianIdentifier.Text = data.MedicareNationalPhysicianIdentifier;
            tboxMedicaidNumber.Text = data.MedicaidNumber;
            ucAttachments.Attachments = data.Attachments;
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxIssueDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxIssueDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxPrimaryStateMedicalLicenseExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxPrimaryStateMedicalLicenseExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxDrugAdministrationExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxDrugAdministrationExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxStateControlledSubstancesCertificateExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxStateControlledSubstancesCertificateExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxECFMGNumberIssueDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxECFMGNumberIssueDate) && retVal;
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.MedicalProfessionalLicensureRegistrations();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertMedicalProfessionalLicensureRegistrations(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        private Entities.Data.MedicalProfessionalLicensureRegistrations LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.MedicalProfessionalLicensureRegistration != null)
                {
                    return physicianFormData.MedicalProfessionalLicensureRegistration;
                }
            }

            return null;
        }

        #endregion [Private methods]
    }
}