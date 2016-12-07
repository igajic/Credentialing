using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Credentialing.Web.Usercontrols
{
    public partial class SidebarProgress : UserControl
    {
        private static readonly Dictionary<int, Tuple<string, string, string>> ApplicationSteps = new Dictionary<int, Tuple<string, string, string>>
        {
            {1, new Tuple<string, string, string>("Instructions", "/Steps/Instructions.aspx", "Lorem ipsum dolor sit amet")},
            {2, new Tuple<string, string, string>("Identifying Information", "/Steps/IdentifyingInformation.aspx", "Consectetur adipiscing elit")},
            {3, new Tuple<string, string, string>("Practice Information", "/Steps/PracticeInformation.aspx", "Integer vulputate")},
            {4, new Tuple<string, string, string>("Education", "/Steps/Education.aspx", "Quis tristique arcu tincidunt")},
            {5, new Tuple<string, string, string>("Medical Professional Education", "/Steps/MedicalProfessionalEducation.aspx", "Pellentesque eget ornare sapien")},
            {6, new Tuple<string, string, string>("Internship/PGYI", "/Steps/InternshipPGYI.aspx", "Curabitur et nunc nisl")},
            {7, new Tuple<string, string, string>("Residencies Fellowships", "/Steps/ResidenciesFellowships.aspx", "Aliquam erat volutpat")},
            {8, new Tuple<string, string, string>("Board Certification", "/Steps/BoardCertification.aspx", "Praesent quis felis posuere")},
            {9, new Tuple<string, string, string>("Other Certifications", "/Steps/OtherCertifications.aspx", "Quisque eget tincidunt nulla")},
            {10, new Tuple<string, string, string>("Medical Professional Licensure Registrations", "/Steps/MedicalProfessionalLicensureRegistrations.aspx", "Nullam porta sem sit amet")},
            {11, new Tuple<string, string, string>("Other State Medical Professional Licenses", "/Steps/OtherStateMedicalProfessionalLicenses.aspx", "Donec felis neque")},
            {12, new Tuple<string, string, string>("Professional Liability", "/Steps/ProfessionalLiability.aspx", "Suspendisse potenti")},
            {13, new Tuple<string, string, string>("Current Affiliations", "/Steps/CurrentAffiliations.aspx", "Donec molestie aliquam nisi")},
            {14, new Tuple<string, string, string>("Peer References", "/Steps/PeerReferences.aspx", "Mauris eget ipsum scelerisque")},
            {15, new Tuple<string, string, string>("Work History", "/Steps/WorkHistory.aspx", "Nam cursus euismod")},
            {16, new Tuple<string, string, string>("Attestation Questions", "/Steps/AttestationQuestions.aspx", "Mauris gravida sagittis")}
        };

        public int CurrentStep { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ltrCurrentStep.Text = ApplicationSteps[CurrentStep].Item1;
            ltrProgress.Text = string.Format("{0}/{1}", CurrentStep, ApplicationSteps.Count);

            rptSidebarProgress.DataSource = ApplicationSteps;
            rptSidebarProgress.ItemDataBound += rptSidebarProgress_ItemDataBound;
            rptSidebarProgress.DataBind();
        }

        private void rptSidebarProgress_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var data = (KeyValuePair<int, Tuple<string, string, string>>)e.Item.DataItem;
                var hlStep = (HyperLink)e.Item.FindControl("hlStep");
                var lbStep = (Label)e.Item.FindControl("lblStep");
                var liStep = (HtmlGenericControl) e.Item.FindControl("liStep");
                var ltrShortDesc = (Literal) e.Item.FindControl("ltrShortDesc");

                hlStep.Text = data.Value.Item1;
                hlStep.NavigateUrl = data.Value.Item2;
                lbStep.Text = data.Key.ToString();
                ltrShortDesc.Text = data.Value.Item3;

                if (data.Key < CurrentStep)
                {
                    liStep.Attributes["class"] += " completed";
                }
                else if (data.Key == CurrentStep)
                {
                    liStep.Attributes["class"] += " current";
                }
            }
        }
    }
}