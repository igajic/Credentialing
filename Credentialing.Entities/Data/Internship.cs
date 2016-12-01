using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class Internship
    {
        public Internship()
        {
        }

        public int InternshipId { get; set; }

        public string Institution { get; set; }

        public string ProgramDirector { get; set; }

        public string MailingAddress { get; set; }

        public string City { get; set; }

        public string StateCountry { get; set; }

        public string Zip { get; set; }

        public string TypeOfInternship { get; set; }

        public string Specialty { get; set; }

        public DateTime SpecialtyFrom { get; set; }

        public DateTime SpecialtyTo { get; set; }

        //public virtual ICollection<Attachment> Attachments { get; set; }
    }
}