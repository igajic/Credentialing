﻿using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.Web.UI;

namespace Credentialing.Web.Usercontrols
{
    public partial class CreateUser : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnCreate.Click += btnCreate_Click;
            ltrErrorMessage.Visible = true;
        }

        #region [Private methods]

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string errorText;
                var newUserId = MemberHelper.CreateUser(tboxUsername.Text, tboxPassword.Text, tboxEmail.Text,
                    ddlRole.SelectedValue, out errorText);

                if (newUserId.HasValue)
                {
                    MemberHelper.LoginUser(tboxUsername.Text, tboxPassword.Text);

                    var newApplication = new PracticionerApplication { UserId = newUserId.Value };
                    PracticionersApplicationHandler.Instance.Insert(newApplication);

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

        private bool ValidateFields()
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