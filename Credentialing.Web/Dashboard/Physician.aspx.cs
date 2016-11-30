using System;
using System.Web.UI;

namespace Credentialing.Web.Dashboard
{
    public partial class Physician : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnStartForm.Click += btnStartForm_Click;
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Steps/Instructions.aspx", true);
            Response.End();
        }

        #endregion [Private methods]
    }
}