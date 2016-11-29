using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

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
                Response.Redirect("/Steps/Instructions.aspx", true);
                Response.End();
            }
        }

        #endregion [Private methods]
    }
}