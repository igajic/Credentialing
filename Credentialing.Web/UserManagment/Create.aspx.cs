using System;
using System.Data.SqlTypes;
using System.Web.UI;
using Credentialing.Business.Helpers;

namespace Credentialing.Web.UserManagment
{
    public partial class Create : Page
    {
        #region [Protected methods]
        protected void Page_Load(object sender, EventArgs e)
        {
            btnCreate.Click += btnCreate_Click;
        }
        #endregion

        #region [Private methods]
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private bool Validate()
        {
            var retVal = ValidationHelper.ValidateTextbox(tboxUsername);
            retVal = ValidationHelper.ValidateTextbox(tboxUsername) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPassword) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxRepeatPassword) && retVal;
            

            return retVal;
        }
        #endregion
    }
}