using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class OtherStateMedicalProfessionalLicenses
    {
        public OtherStateMedicalProfessionalLicenses()
        {
        }

        public int OtherStateMedicalProfessionalLicensesId { get; set; }

        // primary
        public string PrimaryState { get; set; }

        public string PrimaryLicenseNumber { get; set; }

        public DateTime PrimaryExpirationDate { get; set; }

        public DateTime PrimaryLastExpirationDate { get; set; }

        // secondary
        public string SecondaryState { get; set; }

        public string SecondaryLicenseNumber { get; set; }

        public DateTime SecondaryExpirationDate { get; set; }

        public DateTime SecondaryLastExpirationDate { get; set; }

        // tertiary

        public string TertiaryState { get; set; }

        public string TertiaryLicenseNumber { get; set; }

        public DateTime TertiaryExpirationDate { get; set; }

        public DateTime TertiaryLastExpirationDate { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}