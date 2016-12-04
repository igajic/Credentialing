using Credentialing.Business.DataAccess;
using System.Web;

namespace Credentialing.Web.Handlers
{
    /// <summary>
    /// Summary description for DownloadAttachment
    /// </summary>
    public class DownloadAttachment : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            int attachmentId;

            if (int.TryParse(context.Request["attachmentId"], out attachmentId))
            {
                var attachment = AttachmentHandler.Instance.GetById(attachmentId);

                if (attachment != null)
                {
                    // TODO: Add security checks
                    context.Response.ContentType = "application/octet-stream";
                    context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + attachment.FileName);
                    context.Response.AddHeader("Content-Length", attachment.Content.Length.ToString());
                    context.Response.BinaryWrite(attachment.Content);
                    context.Response.End();
                }
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