using Credentialing.Business.Helpers;
using System;
using System.Linq;
using System.Web.UI;

namespace Credentialing.Web
{
    public partial class _default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var currentUser = MemberHelper.GetCurrentLoggedUser();

            if (currentUser != null)
            {
                var userRoles = MemberHelper.GetUserRoles(currentUser.UserName);
                Response.Redirect(userRoles.Contains("Admin") ? "/Dashboard/Administrator.aspx" : "/Dashboard/Physician.aspx", true);
            }
        }
    }
}