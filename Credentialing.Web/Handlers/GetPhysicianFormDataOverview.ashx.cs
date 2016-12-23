using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using System;
using System.Web;
using System.Web.Script.Serialization;

namespace Credentialing.Web.Handlers
{
    public class GetPhysicianFormDataOverview : IHttpHandler
    {
        #region [Properties]

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        #endregion [Properties]

        #region [Public methods]

        public void ProcessRequest(HttpContext context)
        {
            var username = context.Request[Constants.RequestParameters.UserName];
            var currentUser = MemberHelper.GetCurrentLoggedUser();

            if (MemberHelper.IsUserPhysician(username) && MemberHelper.IsUserAdmin(currentUser.UserName))
            {
                var user = MemberHelper.GetUserByName(username);
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);
                var data = new JavaScriptSerializer().Serialize(StepsHelper.Instance.AppSteps);

                context.Response.ContentType = "application/json";
                context.Response.Write(data);
                context.Response.End();
            }
        }

        #endregion [Public methods]
    }
}