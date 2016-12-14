using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class OtherCertifications
    {
        public OtherCertifications()
        {
        }

        public int OtherCertificationsId { get; set; }

        // primary
        public string PrimaryType { get; set; }

        public string PrimaryNumber { get; set; }

        public DateTime? PrimaryDate { get; set; }

        // secondary

        public string SecondaryType { get; set; }

        public string SecondaryNumber { get; set; }

        public DateTime? SecondaryDate { get; set; }

        public bool? Completed { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = PrimaryType.IsCompleted();
                tmp += PrimaryNumber.IsCompleted();
                tmp += PrimaryDate.HasValue ? 1 : 0;

                tmp += SecondaryType.IsCompleted();
                tmp += SecondaryNumber.IsCompleted();
                tmp += SecondaryDate.HasValue ? 1 : 0;

                return 100*tmp/6;
            }
        }
    }
}