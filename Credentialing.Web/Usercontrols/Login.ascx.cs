using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.Linq;
using System.Web.UI;
using Credentialing.Entities;

namespace Credentialing.Web.Usercontrols
{
    public partial class Login : UserControl
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnLogin.Click += btnLogin_Click;
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MemberHelper.LoginUser(tboxUsername.Text, tboxPassword.Text))
            {
                var userRoles = MemberHelper.GetUserRoles(tboxUsername.Text);
                var user = MemberHelper.GetUserByName(tboxUsername.Text);

                var existingApplication = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey);

                if (existingApplication == null)
                {
                    var newApplication = new PracticionerApplication { UserId = (Guid)user.ProviderUserKey };
                    PracticionersApplicationHandler.Instance.Insert(newApplication);
                }

                var returnUrl = Request[Constants.RequestParameters.ReturnUrl];

                if (!string.IsNullOrWhiteSpace(returnUrl))
                {
                    Response.Redirect(returnUrl, true);
                }
                else
                {
                    Response.Redirect(userRoles.Contains("Admin") ? "/Dashboard/Administrator.aspx" : "/Dashboard/Physician.aspx", true);
                }

                Response.End();
            }
        }

        #endregion [Private methods]
    }
}