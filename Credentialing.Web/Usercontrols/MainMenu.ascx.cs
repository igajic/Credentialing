using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

namespace Credentialing.Web.Usercontrols
{
    public partial class MainMenu : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var loggedUser = MemberHelper.GetCurrentLoggedUser();

            if (loggedUser == null)
            {
                Visible = false;
            }
            else if (MemberHelper.IsUserAdmin(loggedUser.UserName))
            {
                liAdmin.Visible = true;
                liPhysician.Visible = false;
            }
            else if (MemberHelper.IsUserPhysician(loggedUser.UserName))
            {
                liAdmin.Visible = false;
                liPhysician.Visible = true;
            }
        }
    }
}