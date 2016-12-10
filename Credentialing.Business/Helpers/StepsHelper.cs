using System;
using Credentialing.Entities;
using Credentialing.Entities.Data;
using System.Collections.Generic;
using System.Linq;

namespace Credentialing.Business.Helpers
{
    public class StepsHelper
    {
        private static StepsHelper _instance;

        public static StepsHelper Instance
        {
            get { return _instance ?? (_instance = new StepsHelper()); }
        }

        private StepsHelper()
        {
        }

        public readonly List<Step> AppSteps = new List<Step>
        {
            new Step{StepId = 1, Name = "Instructions", Url = "/Steps/Instructions.aspx", Description = "Lorem ipsum dolor sit amet", PercentComplete = 100},
            new Step{StepId = 2, Name = "Identifying Information", Url = "/Steps/IdentifyingInformation.aspx", Description = "Consectetur adipiscing elit"},
            new Step{StepId = 3, Name = "Practice Information", Url = "/Steps/PracticeInformation.aspx", Description = "Integer vulputate"},
            new Step{StepId = 4, Name = "Education", Url = "/Steps/Education.aspx", Description = "Quis tristique arcu tincidunt"},
            new Step{StepId = 5, Name = "Medical Professional Education", Url = "/Steps/MedicalProfessionalEducation.aspx", Description = "Pellentesque eget ornare sapien"},
            new Step{StepId = 6, Name = "Internship/PGYI", Url = "/Steps/InternshipPGYI.aspx", Description = "Curabitur et nunc nisl"},
            new Step{StepId = 7, Name = "Residencies Fellowships", Url = "/Steps/ResidenciesFellowships.aspx", Description = "Aliquam erat volutpat"},
            new Step{StepId = 8, Name = "Board Certification", Url = "/Steps/BoardCertification.aspx", Description = "Praesent quis felis posuere"},
            new Step{StepId = 9, Name = "Other Certifications", Url = "/Steps/OtherCertifications.aspx", Description = "Quisque eget tincidunt nulla"},
            new Step{StepId = 10, Name = "Medical Professional Licensure Registrations", Url = "/Steps/MedicalProfessionalLicensureRegistrations.aspx", Description = "Nullam porta sem sit amet"},
            new Step{StepId = 11, Name = "Other State Medical Professional Licenses", Url = "/Steps/OtherStateMedicalProfessionalLicenses.aspx", Description = "Donec felis neque"},
            new Step{StepId = 12, Name = "Professional Liability", Url = "/Steps/ProfessionalLiability.aspx", Description = "Suspendisse potenti"},
            new Step{StepId = 13, Name = "Current Affiliations", Url = "/Steps/CurrentAffiliations.aspx", Description = "Donec molestie aliquam nisi"},
            new Step{StepId = 14, Name = "Peer References", Url = "/Steps/PeerReferences.aspx", Description = "Mauris eget ipsum scelerisque"},
            new Step{StepId = 15, Name = "Work History", Url = "/Steps/WorkHistory.aspx", Description = "Nam cursus euismod"},
            new Step{StepId = 16, Name = "Attestation Questions", Url = "/Steps/AttestationQuestions.aspx", Description = "Mauris gravida sagittis"}
        };

        public void UpdateSteps(PracticionerApplication application)
        {
            if (application != null)
            {
                AppSteps[1].PercentComplete = application.IdentifyingInformation == null ? 0 : application.IdentifyingInformation.PercentComplete;
                AppSteps[2].PercentComplete = application.PracticeInformation == null ? 0 : application.PracticeInformation.PercentComplete;
                AppSteps[3].PercentComplete = application.Education == null ? 0 : application.Education.PercentComplete;
                AppSteps[4].PercentComplete = application.MedicalProfessionalEducation == null ? 0 : application.MedicalProfessionalEducation.PercentComplete;
                AppSteps[5].PercentComplete = application.Internship == null ? 0 : application.Internship.PercentComplete;
                AppSteps[6].PercentComplete = application.ResidenciesFellowship == null ? 0 : application.ResidenciesFellowship.PercentComplete;
                AppSteps[7].PercentComplete = application.BoardCertification == null ? 0 : application.BoardCertification.PercentComplete;
                AppSteps[8].PercentComplete = application.OtherCertification == null ? 0 : application.OtherCertification.PercentComplete;
                AppSteps[9].PercentComplete = application.MedicalProfessionalLicensureRegistration == null ? 0 : application.MedicalProfessionalLicensureRegistration.PercentComplete;
                AppSteps[10].PercentComplete = application.OtherStateMedicalProfessionalLicense == null ? 0 : application.OtherStateMedicalProfessionalLicense.PercentComplete;
                AppSteps[11].PercentComplete = application.ProfessionalLiability == null ? 0 : application.ProfessionalLiability.PercentComplete;
                AppSteps[12].PercentComplete = application.CurrentHospitalInstitutionalAffiliations == null ? 0 : application.CurrentHospitalInstitutionalAffiliations.PercentComplete;
                AppSteps[13].PercentComplete = application.PeerReferences == null ? 0 : application.PeerReferences.PercentComplete;
                AppSteps[14].PercentComplete = application.WorkHistory == null ? 0 : application.WorkHistory.PercentComplete;
                AppSteps[15].PercentComplete = application.AttestationQuestions == null ? 0 : application.AttestationQuestions.PercentComplete;
            }
            else
            {
                AppSteps.Where(s => s.StepId > 1).ToList().ForEach(s => s.PercentComplete = 0);
            }
        }
    }
}