using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class MedicalProfessionalEducation : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();
                LoadFormData(data);
            }
        }

        #region [Private methods]

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveFormData();
                Response.Redirect("/Steps/MedicalProfessionalEducation.aspx");
                Response.End();
            }
        }

        private void SaveFormData()
        {
            var formData = new Entities.Data.MedicalProfessionalEducation();

            formData.PrimaryMedicalProfessionalSchool = tboxMedicalProfessionalSchoolFirst.Text;
            formData.PrimaryDegreeReceived = tboxDegreeReceivedFirst.Text;
            formData.PrimaryDateOfGraduation = DateHelper.ParseDate(tboxDateGraduationFirst.Text);
            formData.PrimaryMailingAddress = tboxMailingAdrressFirst.Text;
            formData.PrimaryCity = tboxMailingCityFirst.Text;
            formData.PrimaryStateCountry = tboxMailingStateFirst.Text;
            formData.PrimaryZip = tboxMailingZipFirst.Text;

            formData.SecondaryMedicalProfessionalSchool = tboxMedicalProfessionalSchoolSecond.Text;
            formData.SecondaryDegreeReceived = tboxDegreeReceivedSecond.Text;
            formData.SecondaryDateOfGraduation = DateHelper.ParseDate(tboxDateGraduationSecond.Text);
            formData.SecondaryMailingAddress = tboxMailingAdrressSecond.Text;
            formData.SecondaryCity = tboxMailingCitySecond.Text;
            formData.SecondaryStateCountry = tboxMailingStateSecond.Text;
            formData.SecondaryZip = tboxMailingZipSecond.Text;


            var user = MemberHelper.GetCurrentLoggedUser();
            var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey);

            if (physicianFormData.MedicalProfessionalEducationId.HasValue)
            {
                formData.MedicalProfessionalEducationId = physicianFormData.MedicalProfessionalEducationId.Value;
                MedicalProfessionalEducationHandler.Instance.Update(formData);
            }
            else
            {
                var id = MedicalProfessionalEducationHandler.Instance.Insert(formData);
                physicianFormData.MedicalProfessionalEducationId = id;

                PracticionersApplicationHandler.Instance.Update(physicianFormData);
            }

            if (fuAttachments.HasFiles)
            {
                var existingAttachments = AttachmentHandler.Instance.GetReferencedAttachments("MedicalProfessionalEducationId", formData.MedicalProfessionalEducationId);
                foreach (var attachment in existingAttachments)
                {
                    AttachmentHandler.Instance.Delete(attachment.AttachmentId);
                }

                foreach (var file in fuAttachments.PostedFiles)
                {
                    var attachment = new Attachment
                    {
                        FileName = file.FileName,
                        EducationId = formData.MedicalProfessionalEducationId
                    };

                    using (MemoryStream ms = new MemoryStream())
                    {
                        file.InputStream.CopyTo(ms);
                        attachment.Content = ms.ToArray();
                    }
                    AttachmentHandler.Instance.Insert(attachment);
                }
            }
        }

        private bool ValidateFields()
        {
            var retVal = ValidationHelper.ValidateTextbox(tboxMedicalProfessionalSchoolFirst);

            retVal = ValidationHelper.ValidateTextbox(tboxDegreeReceivedFirst) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxDateGraduationFirst) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingAdrressFirst) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingCityFirst) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingStateFirst) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingZipFirst) && retVal;

            retVal = ValidationHelper.ValidateTextbox(tboxMedicalProfessionalSchoolSecond) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxDegreeReceivedSecond) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxDateGraduationSecond) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingAdrressSecond) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingCitySecond) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingStateSecond) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingZipSecond) && retVal;

            return retVal;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Steps/Education.aspx", true);
            Response.End();
        }

        private Entities.Data.MedicalProfessionalEducation LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey);

                if (physicianFormData != null && physicianFormData.MedicalProfessionalEducationId.HasValue)
                {
                    var data = MedicalProfessionalEducationHandler.Instance.GetById(physicianFormData.MedicalProfessionalEducationId.Value);

                    return data;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.MedicalProfessionalEducation data)
        {
            if (data == null) return;

            tboxMedicalProfessionalSchoolFirst.Text = data.PrimaryMedicalProfessionalSchool;
            tboxDegreeReceivedFirst.Text = data.PrimaryDegreeReceived;
            tboxDateGraduationFirst.Text = data.PrimaryDateOfGraduation.ToString("MM/yy");
            tboxMailingAdrressFirst.Text = data.PrimaryMailingAddress;
            tboxMailingCityFirst.Text = data.PrimaryCity;
            tboxMailingStateFirst.Text = data.PrimaryStateCountry;
            tboxMailingZipFirst.Text = data.PrimaryZip;

            tboxMedicalProfessionalSchoolSecond.Text = data.SecondaryMedicalProfessionalSchool;
            tboxDegreeReceivedSecond.Text = data.SecondaryDegreeReceived;
            tboxDateGraduationSecond.Text = data.SecondaryDateOfGraduation.ToString("MM/yy");
            tboxMailingAdrressSecond.Text = data.SecondaryMailingAddress;
            tboxMailingCitySecond.Text = data.SecondaryCity;
            tboxMailingStateSecond.Text = data.SecondaryStateCountry;
            tboxMailingZipSecond.Text = data.SecondaryZip;
        }

        #endregion [Private methods]
    }
}