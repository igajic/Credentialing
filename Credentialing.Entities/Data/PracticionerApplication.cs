using Credentialing.Entities.Steps;
using System;

namespace Credentialing.Entities.Data
{
    public class PracticionerApplication
    {
        public PracticionerApplication()
        {
        }

        public int PracticionerApplicationId { get; set; }

        public Guid UserId { get; set; }

        public virtual IdentifyingInformation IdentifyingInformation { get; set; }

        public virtual PracticeInformation PracticeInformation { get; set; }

        public virtual Education Education { get; set; }

        public virtual MedicalProfessionalEducation MedicalProfessionalEducation { get; set; }

        public virtual Internship Internship { get; set; }

        public virtual ResidenciesFellowship ResidenciesFellowship { get; set; }

        public virtual BoardCertification BoardCertification { get; set; }

        public virtual OtherCertifications OtherCertifications { get; set; }

        public virtual MedicalProfessionalLicensureRegistrations MedicalProfessionalLicensureRegistrations { get; set; }

        public virtual OtherStateMedicalProfessionalLicenses OtherStateMedicalProfessionalLicenses { get; set; }

        public virtual ProfessionalLiability ProfessionalLiability { get; set; }

        public virtual CurrentHospitalInstitutionalAffiliations CurrentHospitalInstitutionalAffiliations { get; set; }

        public virtual PeerReferences PeerReferences { get; set; }

        public virtual WorkHistory WorkHistory { get; set; }

        public virtual AttestationQuestions AttestationQuestions { get; set; }
    }
}