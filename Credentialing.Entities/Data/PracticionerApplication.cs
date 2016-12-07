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

        public int? IdentifyingInformationId { get; set; }

        public int? PracticeInformationId { get; set; }

        public int? EducationId { get; set; }

        public int? MedicalProfessionalEducationId { get; set; }

        public int? InternshipId { get; set; }

        public int? ResidenciesFellowshipId { get; set; }

        public int? BoardCertificationId { get; set; }

        public int? OtherCertificationId { get; set; }

        public int? MedicalProfessionalLicensureRegistrationId { get; set; }

        public int? OtherStateMedicalProfessionalLicenseId { get; set; }

        public int? ProfessionalLiabilityId { get; set; }

        public int? CurrentHospitalInstitutionalAffiliationId { get; set; }

        public int? PeerReferenceId { get; set; }

        public int? WorkHistoryId { get; set; }

        public int? AttestationQuestionId { get; set; }

        // references
        public virtual IdentifyingInformation IdentifyingInformation { get; set; }

        public virtual PracticeInformation PracticeInformation { get; set; }

        public virtual Education Education { get; set; }

        public virtual MedicalProfessionalEducation MedicalProfessionalEducation { get; set; }

        public virtual Internship Internship { get; set; }

        public virtual ResidenciesFellowship ResidenciesFellowship { get; set; }

        public virtual BoardCertification BoardCertification { get; set; }

        public virtual OtherCertifications OtherCertification { get; set; }

        public virtual MedicalProfessionalLicensureRegistrations MedicalProfessionalLicensureRegistration { get; set; }

        public virtual ProfessionalLiability ProfessionalLiability { get; set; }

        public virtual OtherStateMedicalProfessionalLicenses OtherStateMedicalProfessionalLicense { get; set; }

        public virtual CurrentHospitalInstitutionalAffiliations CurrentHospitalInstitutionalAffiliations { get; set; }

        public virtual PeerReferences PeerReferences { get; set; }

        public virtual WorkHistory WorkHistory { get; set; }

        public virtual AttestationQuestions AttestationQuestions { get; set; }
    }
}