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
    }
}