using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class Instructions : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Steps/IdentifyingInformation.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}