namespace Credentialing.Entities.Data
{
    public class Attachment
    {
        public Attachment()
        {
        }

        public int AttachmentId { get; set; }

        public string FileName { get; set; }

        public byte[] Content { get; set; }

        public int? EducationId { get; set; }
        public int? MedicalProfessionalEducationId { get; set; }
        public int? InternshipId { get; set; }
        public int? ResidenciesFellowshipId { get; set; }
        public int? OtherCertificationsId { get; set; }
        public int? MedicalProfessionalLicensureRegistrationsId { get; set; }
        public int? OtherStateMedicalProfessionalLicensesId { get; set; }
        public int? WorkHistoryId { get; set; }
        public int? AttestationQuestionsId { get; set; }
        public int? CurrentHospitalInstitutionalAffiliationsId { get; set; }
    }
}