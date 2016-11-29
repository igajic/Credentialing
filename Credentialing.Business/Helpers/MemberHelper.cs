using System.Web.Security;

namespace Credentialing.Business.Helpers
{
    public class MemberHelper
    {
        public static bool LoginUser(string username, string password)
        {
            bool retVal = false;
            if (Membership.ValidateUser(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, true);

                retVal = true;
            }

            return retVal;
        }

        public static MembershipUser GetCurrentLoggedUser()
        {
            return Membership.GetUser();
        }

        public static void LogoutUser()
        {
            FormsAuthentication.SignOut();
        }
    }
}