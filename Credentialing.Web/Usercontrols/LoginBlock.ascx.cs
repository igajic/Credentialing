using Credentialing.Business.Helpers;
using System;
using System.Web.Security;
using System.Web.UI;

namespace Credentialing.Web.Usercontrols
{
    public partial class LoginBlock : UserControl
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            //var loggedInUser = MemberHelper.GetCurrentLoggedUser();

            MembershipUser loggedInUser = null;

            if (loggedInUser == null)
            {
                pnlLogin.Visible = true;
                pnlLoggedIn.Visible = false;
            }
            else
            {
                pnlLogin.Visible = false;
                pnlLoggedIn.Visible = true;

                ltrUsername.Text = loggedInUser.UserName;
                lbLogout.Click += lbLogout_Click;
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void lbLogout_Click(object sender, EventArgs e)
        {
            MemberHelper.LogoutUser();
            Response.Redirect("/", true);
            Response.End();
        }

        #endregion [Private methods]
    }
}