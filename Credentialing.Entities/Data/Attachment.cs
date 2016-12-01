﻿using Credentialing.Entities.Steps;

namespace Credentialing.Entities.Data
{
    public class Attachment
    {
        public Attachment()
        {
        }

        public int? AttachmentId { get; set; }

        public string FileName { get; set; }

        public byte[] Content { get; set; }

        #region Relationship properties

        public int? EducationId { get; set; }
        public int? MedicalProfessionalEducationId { get; set; }
        public int? InternshipId { get; set; }
        public int? ResidenciesFellowshipId { get; set; }
        public int? OtherCertificationsId { get; set; }
        public int? MedicalProfessionalLicensureRegistrationsId { get; set; }
        public int? OtherStateMedicalProfessionalLicensesId { get; set; }
        public int? WorkHistoryId { get; set; }

        public virtual IdentifyingInformation IdentifyingInformation { get; set; }

        public virtual Education Education { get; set; }

        public virtual MedicalProfessionalEducation MedicalProfessionalEducation { get; set; }

        public virtual Internship Internship { get; set; }

        public virtual ResidenciesFellowship ResidenciesFellowship { get; set; }

        public virtual OtherCertifications OtherCertifications { get; set; }

        public virtual MedicalProfessionalLicensureRegistrations MedicalProfessionalLicensureRegistrations { get; set; }

        public virtual OtherStateMedicalProfessionalLicenses OtherStateMedicalProfessionalLicenses { get; set; }

        public virtual ProfessionalLiability ProfessionalLiability { get; set; }

        public virtual WorkHistory WorkHistories { get; set; }

        #endregion Relationship properties
    }
}