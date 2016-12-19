using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Credentialing.Web.Dashboard
{
    public partial class Administrator : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            var data = GetPhysicianStatistics();
            var chartData = GetChartData(data);

            this.Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "data", string.Format("var chartData = {0};", chartData), true);

            rptUsers.DataSource = data;
            rptUsers.ItemDataBound += rptUsers_ItemDataBound;
            rptUsers.DataBind();
        }

        #endregion [Protected methods]

        #region [Private methods]

        private string GetChartData(List<Tuple<string, int>> data)
        {
            var retVal = new List<object[]>();

            retVal.Add(new object[] { "Status", "Percentage" });
            retVal.Add(new object[] { "Completed", data.Count(s => s.Item2 == 100) });
            retVal.Add(new object[] { "Incomplete", data.Count(s => s.Item2 < 100 && s.Item2 > 0) });
            retVal.Add(new object[] { "Not started", data.Count(s => s.Item2 == 0) });

            var json = new JavaScriptSerializer().Serialize(retVal);
            return json;
        }

        private void rptUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var data = (Tuple<string, int>)e.Item.DataItem;
                var ltrPercentage = (Literal)e.Item.FindControl("ltrPercentage");
				var ltrProgressBar = (Literal)e.Item.FindControl("ltrProgressBar");
                var ltrUserName = (Literal)e.Item.FindControl("ltrUser");

                ltrPercentage.Text = data.Item2 + "%";
				ltrProgressBar.Text = data.Item2 + "%";
                ltrUserName.Text = data.Item1;
            }
        }

        private List<Tuple<string, int>> GetPhysicianStatistics()
        {
            var allUsers = Membership.GetAllUsers();
            var data = new List<Tuple<string, int>>();
            foreach (MembershipUser user in allUsers)
            {
                if (MemberHelper.IsUserPhysician(user.UserName))
                {
                    var userData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);
                    data.Add(new Tuple<string, int>(user.UserName, userData != null ? userData.PercentComplete : 0));
                }
            }

            return data;
        }

        #endregion [Private methods]
    }
}