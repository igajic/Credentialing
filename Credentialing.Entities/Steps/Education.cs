using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Steps
{
    public class Education
    {
        public string CollegeUniverityName { get; set; }

        public string DegreeReceived { get; set; }

        public DateTime DateGraduation { get; set; }

        public string MailingAddress { get; set; }

        public string MailingCity { get; set; }

        public string MailingState { get; set; }

        public string MailingZip { get; set; }

        public List<string> AttachedDocuments { get; set; }
    }
}