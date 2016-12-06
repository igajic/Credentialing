using System;
using Credentialing.Business.DataAccess;
using System.Web;
using Credentialing.Business.Helpers;

namespace Credentialing.Web.Handlers
{
    /// <summary>
    /// Summary description for DownloadAttachment
    /// </summary>
    public class DownloadAttachment : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            int attachmentId;

            if (int.TryParse(context.Request["attachmentId"], out attachmentId))
            {
                if (CheckUserAccess())
                {
                    var attachment = AttachmentHandler.Instance.GetById(attachmentId);

                    if (attachment != null)
                    {
                        context.Response.ContentType = "application/octet-stream";
                        context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + attachment.FileName);
                        context.Response.AddHeader("Content-Length", attachment.Content.Length.ToString());
                        context.Response.BinaryWrite(attachment.Content);
                        context.Response.End();
                    }
                }
            }
        }

        private bool CheckUserAccess()
        {
            var retVal = false;
            
            var currentUser = MemberHelper.GetCurrentLoggedUser();

            if (currentUser != null)
            {
                if (MemberHelper.IsUserAdmin(currentUser.UserName))
                {
                    retVal = true;
                }
                else if (MemberHelper.IsUserPhysician(currentUser.UserName))
                {
                    var application = PracticionersApplicationHandler.Instance.GetByUserId((Guid)currentUser.ProviderUserKey, true);

                    // TODO: Add security checks, check all attachment in physicians application attachments



                }
            }

            return retVal;
        }
    }
}