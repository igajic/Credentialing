using System.Web.UI.WebControls;

namespace Credentialing.Business.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateTextbox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.CssClass = "error";
                return false;
            }
            else
            {
                textBox.CssClass = "";
                return true;
            }
        }
    }
}