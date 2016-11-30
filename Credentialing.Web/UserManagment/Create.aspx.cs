﻿using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

namespace Credentialing.Web.UserManagment
{
    public partial class Create : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnCreate.Click += btnCreate_Click;
            ltrErrorMessage.Visible = true;
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string errorText;

                if (MemberHelper.CreateUser(tboxUsername.Text, tboxPassword.Text, tboxEmail.Text, ddlRole.SelectedValue,
                    out errorText))
                {
                    MemberHelper.LoginUser(tboxUsername.Text, tboxPassword.Text);

                    Response.Redirect(
                        ddlRole.SelectedValue.Contains("Admin")
                            ? "/Dashboard/Administrator.aspx"
                            : "/Dashboard/Physician.aspx", true);
                    Response.End();
                }
                else
                {
                    ltrErrorMessage.Text = errorText;
                    ltrErrorMessage.Visible = true;
                }
            }
        }

        private bool Validate()
        {
            var retVal = ValidationHelper.ValidateTextbox(tboxUsername);
            retVal = ValidationHelper.ValidateTextbox(tboxUsername) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPassword) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxRepeatPassword) && retVal;

            if (tboxPassword.Text != tboxRepeatPassword.Text)
            {
                tboxPassword.CssClass += " error";
                tboxRepeatPassword.CssClass += " error";
                retVal = false;
            }

            return retVal;
        }

        #endregion [Private methods]
    }
}