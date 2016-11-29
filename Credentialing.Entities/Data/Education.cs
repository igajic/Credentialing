using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class Education
    {
        public Education()
        {
            
        }
        public int EducationId { get; set; }

        public string CollegeUniverityName { get; set; }

        public string DegreeReceived { get; set; }

        public DateTime DateGraduation { get; set; }

        public string MailingAddress { get; set; }

        public string MailingCity { get; set; }

        public string MailingState { get; set; }

        public string MailingZip { get; set; }

        //public ICollection<Attachment> AttachedDocuments { get; set; }
    }
}