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

        public DateTime PrimaryDate { get; set; }

        // secondary

        public string SecondaryType { get; set; }

        public string SecondaryNumber { get; set; }

        public DateTime SecondaryDate { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}