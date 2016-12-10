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

        public DateTime? PrimaryExpirationDate { get; set; }

        public DateTime? PrimaryLastExpirationDate { get; set; }

        // secondary
        public string SecondaryState { get; set; }

        public string SecondaryLicenseNumber { get; set; }

        public DateTime? SecondaryExpirationDate { get; set; }

        public DateTime? SecondaryLastExpirationDate { get; set; }

        // tertiary

        public string TertiaryState { get; set; }

        public string TertiaryLicenseNumber { get; set; }

        public DateTime? TertiaryExpirationDate { get; set; }

        public DateTime? TertiaryLastExpirationDate { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                // primary
                var tmp = PrimaryState.IsCompleted();
                tmp += PrimaryLicenseNumber.IsCompleted();
                tmp += PrimaryExpirationDate.HasValue ? 1 : 0;
                tmp += PrimaryLastExpirationDate.HasValue ? 1 : 0;
                
                // secondary
                tmp += SecondaryState.IsCompleted();
                tmp += SecondaryLicenseNumber.IsCompleted();
                tmp += SecondaryExpirationDate.HasValue ? 1 : 0;
                tmp += SecondaryLastExpirationDate.HasValue ? 1 : 0;

                // tertiary
                tmp += TertiaryState.IsCompleted();
                tmp += TertiaryLicenseNumber.IsCompleted();
                tmp += TertiaryExpirationDate.HasValue ? 1 : 0;
                tmp += TertiaryLastExpirationDate.HasValue ? 1 : 0;

                return 100*tmp/12;
            }
        }
    }
}