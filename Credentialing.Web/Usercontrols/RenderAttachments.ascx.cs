using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Credentialing.Web.Usercontrols
{
    public partial class RenderAttachments : UserControl
    {
        public List<Attachment> Attachments { get; set; }

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Attachments == null || Attachments.Count == 0)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                rptAttachments.DataSource = Attachments;
                rptAttachments.ItemDataBound += rptAttachments_ItemDataBound;
                rptAttachments.DataBind();
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void rptAttachments_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var data = (Attachment)e.Item.DataItem;
                var hlAttachment = (HyperLink)e.Item.FindControl("hlAttachment");

                hlAttachment.Text = data.FileName;
                hlAttachment.NavigateUrl = string.Format("/Handlers/DownloadAttachment.ashx?{0}={1}", Constants.RequestParameters.AttachmentId, data.AttachmentId);
            }
        }

        #endregion [Private methods]
    }
}