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

        public DateTime? SpecialtyFrom { get; set; }

        public DateTime? SpecialtyTo { get; set; }

        public bool? Completed { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = Institution.IsCompleted();
                tmp += ProgramDirector.IsCompleted();
                tmp += MailingAddress.IsCompleted();
                tmp += City.IsCompleted();
                tmp += StateCountry.IsCompleted();
                tmp += Zip.IsCompleted();
                tmp += TypeOfInternship.IsCompleted();
                tmp += Specialty.IsCompleted();
                tmp += SpecialtyTo.HasValue ? 1 : 0;
                tmp += SpecialtyFrom.HasValue ? 1 : 0;

                return 100*tmp/10;
            }
        }
    }
}