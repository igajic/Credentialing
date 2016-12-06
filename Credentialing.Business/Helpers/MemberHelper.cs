using System;
using System.Linq;
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

        public static MembershipUser GetUserByName(string name)
        {
            return Membership.GetUser(name);
        }

        public static void LogoutUser()
        {
            FormsAuthentication.SignOut();
        }

        public static string[] GetUserRoles(string userName)
        {
            return Roles.GetRolesForUser(userName);
        }

        public static bool IsUserAdmin(string userName)
        {
            return GetUserRoles(userName).Contains("Admin");
        }

        public static bool IsUserPhysician(string userName)
        {
            return GetUserRoles(userName).Contains("Physician");
        }

        public static Guid? CreateUser(string userName, string password, string email, string role, out string errorMessage)
        {
            Guid? retVal = null;
            errorMessage = null;

            try
            {
                MembershipUser newUser = Membership.CreateUser(userName, password, email);
                Roles.AddUserToRole(userName, role);

                retVal = (Guid?)newUser.ProviderUserKey;
            }
            catch (MembershipCreateUserException e)
            {
                errorMessage = GetErrorMessage(e.StatusCode);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            return retVal;
        }

        public static string GetErrorMessage(MembershipCreateStatus status)
        {
            switch (status)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return
                        "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return
                        "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return
                        "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
    }
}