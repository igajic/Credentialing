using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Credentialing.Web.Usercontrols
{
    public partial class SidebarProgress : UserControl
    {
        private static readonly Dictionary<int, Tuple<string, string>> ApplicationSteps = new Dictionary<int, Tuple<string, string>>
        {
            {1, new Tuple<string, string>("Instructions", "/Steps/Instructions.aspx")},
            {2, new Tuple<string, string>("Identifying Information", "/Steps/IdentifyingInformation.aspx")},
            {3, new Tuple<string, string>("Practice Information", "/Steps/PracticeInformation.aspx")},
            {4, new Tuple<string, string>("Education", "/Steps/Education.aspx")},
            {5, new Tuple<string, string>("Medical Professional Education", "/Steps/MedicalProfessionalEducation.aspx")},
            {6, new Tuple<string, string>("Internship/PGYI", "/Steps/Internship.aspx")},
            {7, new Tuple<string, string>("Residencies Fellowships", "/Steps/ResidenciesFellowships.aspx")},
            {8, new Tuple<string, string>("Board Certification", "/Steps/BoardCertification.aspx")},
            {9, new Tuple<string, string>("Other Certifications", "/Steps/OtherCertifications.aspx")},
            {10, new Tuple<string, string>("Medical Professional Licensure Registrations", "/Steps/MedicalProfessionalLicensureRegistrations.aspx")},
            {11, new Tuple<string, string>("Other State Medical Professional Licenses", "/Steps/OtherStateMedicalProfessionalLicenses.aspx")},
            {12, new Tuple<string, string>("Professional Liability", "/Steps/ProfessionalLiability.aspx")},
            {13, new Tuple<string, string>("Current Affiliations", "/Steps/CurrentAffiliations.aspx")},
            {14, new Tuple<string, string>("Peer References", "/Steps/PeerReferences.aspx")},
            {15, new Tuple<string, string>("Work History", "/Steps/WorkHistory.aspx")},
            {16, new Tuple<string, string>("Attestation Questions", "/Steps/AttestationQuestions.aspx")}
        };

        public int CurrentStep { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            rptSidebarProgress.DataSource = ApplicationSteps;
            rptSidebarProgress.ItemDataBound += rptSidebarProgress_ItemDataBound;
            rptSidebarProgress.DataBind();
        }

        private void rptSidebarProgress_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var data = (KeyValuePair<int, Tuple<string, string>>)e.Item.DataItem;
                var hlStep = (HyperLink)e.Item.FindControl("hlStep");
                var lbStep = (Label)e.Item.FindControl("lblStep");

                hlStep.Text = data.Value.Item1;
                hlStep.NavigateUrl = data.Value.Item2;
                lbStep.Text = data.Key.ToString();

                if (data.Key < CurrentStep)
                {
                    lbStep.CssClass += " completed";
                }
                else if (data.Key == CurrentStep)
                {
                    lbStep.CssClass += " current";
                }
            }
        }
    }
}