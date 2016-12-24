using System;
using System.Web.UI.WebControls;

namespace Credentialing.Business.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateTextbox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.CssClass += " error";
                return false;
            }
            else
            {
                textBox.CssClass = textBox.CssClass.Replace("error", string.Empty);
                return true;
            }
        }

        public static bool ValidateFullDate(TextBox textBox)
        {
            try
            {
                var date = DateTime.Parse(textBox.Text);
                textBox.CssClass = textBox.CssClass.Replace("error", string.Empty);
                return true;
            }
            catch
            {
                textBox.CssClass += " error";
                return false;
            }
        }

        public static bool ValidateShortDate(TextBox textBox)
        {
            try
            {
                var date = DateHelper.ParseDate(textBox.Text);
                textBox.CssClass = textBox.CssClass.Replace("error", string.Empty);
                return true;
            }
            catch
            {
                textBox.CssClass += " error";
                return false;
            }
        }

        public static bool ValidateDecimal(TextBox textBox)
        {
            try
            {
                decimal tmp;

                if (Decimal.TryParse(textBox.Text, out tmp))
                {
                    textBox.CssClass = textBox.CssClass.Replace("error", string.Empty);
                    return true;
                }
                else
                {
                    textBox.CssClass += " error";
                    return false;
                }
            }
            catch
            {
                textBox.CssClass += " error";
                return false;
            }
        }
    }
}