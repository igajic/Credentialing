using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Credentialing.Entities.Data
{
    public class MedicalProfessionalEducation
    {
        public MedicalProfessionalEducation()
        {
            Attachments = new List<Attachment>();
        }

        public int MedicalProfessionalEducationId { get; set; }

        public string PrimaryMedicalProfessionalSchool { get; set; }

        public string PrimaryDegreeReceived { get; set; }

        public DateTime? PrimaryDateOfGraduation { get; set; }

        public string PrimaryMailingAddress { get; set; }

        public string PrimaryCity { get; set; }

        public string PrimaryStateCountry { get; set; }

        public string PrimaryZip { get; set; }

        public string SecondaryMedicalProfessionalSchool { get; set; }

        public string SecondaryDegreeReceived { get; set; }

        public DateTime? SecondaryDateOfGraduation { get; set; }

        public string SecondaryMailingAddress { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryStateCountry { get; set; }

        public string SecondaryZip { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public int PercentComplete 
        {
            get
            {
                var tmp = PrimaryMedicalProfessionalSchool.IsCompleted();
                tmp += PrimaryDegreeReceived.IsCompleted();
                tmp += PrimaryDateOfGraduation.HasValue ? 1 : 0;
                tmp += PrimaryMailingAddress.IsCompleted();
                tmp += PrimaryCity.IsCompleted();
                tmp += PrimaryStateCountry.IsCompleted();
                tmp += PrimaryZip.IsCompleted();
                tmp += SecondaryMedicalProfessionalSchool.IsCompleted();
                tmp += SecondaryDateOfGraduation.HasValue ? 1 : 0;
                tmp += SecondaryDegreeReceived.IsCompleted();
                tmp += SecondaryMailingAddress.IsCompleted();
                tmp += SecondaryCity.IsCompleted();
                tmp += SecondaryStateCountry.IsCompleted();
                tmp += SecondaryZip.IsCompleted();

                return 100*tmp/14;
            }
        }
    }
}