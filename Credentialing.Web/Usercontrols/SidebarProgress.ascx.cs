using Credentialing.Entities;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Credentialing.Business.Helpers;

namespace Credentialing.Web.Usercontrols
{
    public partial class SidebarProgress : UserControl
    {
        public int CurrentStep { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ltrCurrentStep.Text = StepsHelper.Instance.AppSteps[CurrentStep - 1].Name;
            ltrProgress.Text = string.Format("{0}/{1}", CurrentStep, StepsHelper.Instance.AppSteps.Count);

            rptSidebarProgress.DataSource = StepsHelper.Instance.AppSteps;
            rptSidebarProgress.ItemDataBound += rptSidebarProgress_ItemDataBound;
            rptSidebarProgress.DataBind();
        }

        private void rptSidebarProgress_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var data = (Step)e.Item.DataItem;
                var hlStep = (Literal)e.Item.FindControl("hlStep");
				var hlStepLink = (HyperLink)e.Item.FindControl("hlStepLink");
                var lbStep = (Label)e.Item.FindControl("lblStep");
                var liStep = (HtmlGenericControl)e.Item.FindControl("liStep");
                var ltrShortDesc = (Literal)e.Item.FindControl("ltrShortDesc");

                hlStep.Text = data.Name;
				hlStepLink.NavigateUrl = data.Url;
                lbStep.Text = data.StepId.ToString();
                ltrShortDesc.Text = data.Description;

                if (data.PercentComplete == 100)
                {
                    liStep.Attributes["class"] += " completed";
                }
                else if (data.StepId == CurrentStep)
                {
                    liStep.Attributes["class"] += " current";
                }
                else
                {
                    liStep.Attributes["class"] += " incomplete";
                }
            }
        }
    }
}