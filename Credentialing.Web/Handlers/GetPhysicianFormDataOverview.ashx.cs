using System;
using System.Web;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using System.Web.Script.Serialization;
using Credentialing.Business.DataAccess;

namespace Credentialing.Web.Handlers
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPhysicianFormDataOverview : IHttpHandler
    {

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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}