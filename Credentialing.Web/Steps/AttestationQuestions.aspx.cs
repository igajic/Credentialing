using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Credentialing.Web.Steps
{
    public partial class AttestationQuestions : Page
    {
        private const int CurrentStep = 14;

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
                SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private Entities.Data.AttestationQuestions LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.AttestationQuestions != null)
                {
                    return physicianFormData.AttestationQuestions;
                }
            }

            return null;
        }

        private void SaveFormData()
        {
            var formData = new Entities.Data.AttestationQuestions();

            formData.QuestionA = ReadQuestion(rbtnQuestionAYes, rbtnQuestionANo);
            formData.QuestionB = ReadQuestion(rbtnQuestionBYes, rbtnQuestionBNo);
            formData.QuestionC = ReadQuestion(rbtnQuestionCYes, rbtnQuestionCNo);
            formData.QuestionD = ReadQuestion(rbtnQuestionDYes, rbtnQuestionDNo);
            formData.QuestionE = ReadQuestion(rbtnQuestionEYes, rbtnQuestionENo);
            formData.QuestionF = ReadQuestion(rbtnQuestionFYes, rbtnQuestionFNo);
            formData.QuestionG = ReadQuestion(rbtnQuestionGYes, rbtnQuestionGNo);
            formData.QuestionH = ReadQuestion(rbtnQuestionHYes, rbtnQuestionHNo);
            formData.QuestionI = ReadQuestion(rbtnQuestionIYes, rbtnQuestionINo);
            formData.QuestionJ = ReadQuestion(rbtnQuestionJYes, rbtnQuestionJNo);
            formData.QuestionK = ReadQuestion(rbtnQuestionKYes, rbtnQuestionKNo);
            formData.QuestionL = ReadQuestion(rbtnQuestionLYes, rbtnQuestionLNo);
            formData.QuestionM = ReadQuestion(rbtnQuestionMYes, rbtnQuestionMNo);

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertAttestationQuestions(formData, userId);
        }

        private void LoadFormData(Entities.Data.AttestationQuestions formData)
        {
            if (formData == null) return;

            SetQuestion(rbtnQuestionAYes, rbtnQuestionANo, formData.QuestionA);
            SetQuestion(rbtnQuestionBYes, rbtnQuestionBNo, formData.QuestionB);
            SetQuestion(rbtnQuestionCYes, rbtnQuestionCNo, formData.QuestionC);
            SetQuestion(rbtnQuestionDYes, rbtnQuestionDNo, formData.QuestionD);
            SetQuestion(rbtnQuestionEYes, rbtnQuestionENo, formData.QuestionE);
            SetQuestion(rbtnQuestionFYes, rbtnQuestionFNo, formData.QuestionF);
            SetQuestion(rbtnQuestionGYes, rbtnQuestionGNo, formData.QuestionG);
            SetQuestion(rbtnQuestionHYes, rbtnQuestionHNo, formData.QuestionH);
            SetQuestion(rbtnQuestionIYes, rbtnQuestionINo, formData.QuestionI);
            SetQuestion(rbtnQuestionJYes, rbtnQuestionJNo, formData.QuestionJ);
            SetQuestion(rbtnQuestionKYes, rbtnQuestionKNo, formData.QuestionK);
            SetQuestion(rbtnQuestionLYes, rbtnQuestionLNo, formData.QuestionL);
            SetQuestion(rbtnQuestionMYes, rbtnQuestionMNo, formData.QuestionM);
        }

        private bool ValidateFields()
        {
            return true; // TODO: Implement this
        }

        private bool? ReadQuestion(RadioButton rbtnYes, RadioButton rbtnNo)
        {
            if (rbtnYes.Checked)
            {
                return true;
            }

            if (rbtnNo.Checked)
            {
                return false;
            }

            return null;
        }

        private void SetQuestion(RadioButton rbtnYes, RadioButton rbtnNo, bool? value)
        {
            rbtnNo.Checked = false;
            rbtnYes.Checked = false;

            if (value.HasValue)
            {
                if (value.Value)
                {
                    rbtnYes.Checked = true;
                }
                else
                {
                    rbtnNo.Checked = true;
                }
            }
        }
        #endregion [Private methods]
    }
}