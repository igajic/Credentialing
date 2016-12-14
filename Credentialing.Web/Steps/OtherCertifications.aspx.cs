using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class OtherCertifications : Page
    {
        private const int CurrentStep = 8;

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

        private Entities.Data.OtherCertifications LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.OtherCertification != null)
                {
                    return physicianFormData.OtherCertification;
                }
            }

            return null;
        }

        private void SaveFormData()
        {
            var data = new Entities.Data.OtherCertifications();

            data.PrimaryType = tboxPrimaryType.Text;
            data.PrimaryNumber = tboxPrimaryNumber.Text;
            data.PrimaryDate = string.IsNullOrWhiteSpace(tboxPrimaryExpirationDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxPrimaryExpirationDate.Text);

            data.SecondaryType = tboxSecondryType.Text;
            data.SecondaryNumber = tboxSecondaryNumber.Text;
            data.SecondaryDate = string.IsNullOrWhiteSpace(tboxSecondaryExpirationDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxSecondaryExpirationDate.Text);
            
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

            PracticionersApplicationHandler.Instance.UpsertOtherCertifications(data, userId);
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxSecondaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxSecondaryExpirationDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxPrimaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPrimaryExpirationDate) && retVal;
            }

            return retVal;
        }

        private void LoadFormData(Entities.Data.OtherCertifications data)
        {
            tboxPrimaryType.Text = data.PrimaryType;
            tboxPrimaryNumber.Text = data.PrimaryNumber;
            tboxPrimaryExpirationDate.Text = data.PrimaryDate.HasValue ? data.PrimaryDate.Value.ToString("MM/dd/yyyy") : string.Empty;

            tboxSecondryType.Text = data.SecondaryType;
            tboxSecondaryNumber.Text = data.SecondaryNumber;
            tboxSecondaryExpirationDate.Text = data.SecondaryDate.HasValue ? data.SecondaryDate.Value.ToString("MM/dd/yyyy") : string.Empty;
        }

        #endregion [Private methods]
    }
}