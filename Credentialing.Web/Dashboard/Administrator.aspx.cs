using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.Collections.Generic;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Credentialing.Web.Dashboard
{
    public partial class Administrator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var allUsers = Membership.GetAllUsers();
            var data = new List<Tuple<string,int>>();
            foreach (MembershipUser user in allUsers)
            {
                if (MemberHelper.IsUserPhysician(user.UserName))
                {
                    var tmp = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                    if (tmp != null) data.Add(new Tuple<string, int>(user.UserName, tmp.PercentComplete));
                    else data.Add(new Tuple<string, int>(user.UserName, 0));
                }
            }

            rptUsers.DataSource = data;
            rptUsers.ItemDataBound +=rptUsers_ItemDataBound;
            rptUsers.DataBind();
        }

        void rptUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var data = (Tuple<string, int>) e.Item.DataItem;
                var ltrPercentage = (Literal)e.Item.FindControl("ltrPercentage");
                var ltrUserName = (Literal)e.Item.FindControl("ltrUser");

                ltrPercentage.Text = data.Item2 + "%";
                ltrUserName.Text = data.Item1;

            }
        }
    }
}