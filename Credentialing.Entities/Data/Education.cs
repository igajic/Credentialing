using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class Education
    {
        public Education()
        {
            Attachments = new List<Attachment>();
        }

        public int EducationId { get; set; }

        public string CollegeUniverityName { get; set; }

        public string DegreeReceived { get; set; }

        public DateTime? DateGraduation { get; set; }

        public string MailingAddress { get; set; }

        public string MailingCity { get; set; }

        public string MailingState { get; set; }

        public string MailingZip { get; set; }

        public bool? Completed { get; set; }

        public List<Attachment> Attachments { get; set; }

        public int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = CollegeUniverityName.IsCompleted();
                tmp += DegreeReceived.IsCompleted();
                tmp += DateGraduation.HasValue ? 1 : 0;
                tmp += MailingAddress.IsCompleted();
                tmp += MailingCity.IsCompleted();
                tmp += MailingState.IsCompleted();
                tmp += MailingZip.IsCompleted();

                return 100*tmp/7;
            }
        }
    }
}