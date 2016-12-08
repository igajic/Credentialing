using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credentialing.Entities.Data
{
    public class ResidenciesFellowship
    {
        public ResidenciesFellowship()
        {
            
        }

        public int ResidenciesFellowshipId { get; set; }


        //primary
        public string PrimaryInstitution { get; set; }

        public string PrimaryProgramDirector { get; set; }

        public string PrimaryMailingAddress { get; set; }

        public string PrimaryCity { get; set; }

        public string PrimaryState { get; set; }

        public string PrimaryZip { get; set; }

        public string PrimaryTypeTraining { get; set; }

        public string PrimarySpecialty { get; set; }

        public DateTime PrimaryFrom { get; set; }

        public DateTime PrimaryTo { get; set; }

        public bool PrimaryCompleted { get; set; }


        // secondary
        public string SecondaryInstitution { get; set; }

        public string SecondaryProgramDirector { get; set; }

        public string SecondaryMailingAddress { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryState { get; set; }

        public string SecondaryZip { get; set; }

        public string SecondaryTypeTraining { get; set; }

        public string SecondarySpecialty { get; set; }

        public DateTime SecondaryFrom { get; set; }

        public DateTime SecondaryTo { get; set; }

        public bool SecondaryCompleted { get; set; }


        // tertiary
        public string TertiaryInstitution { get; set; }

        public string TertiaryProgramDirector { get; set; }

        public string TertiaryMailingAddress { get; set; }

        public string TertiaryCity { get; set; }

        public string TertiaryState { get; set; }

        public string TertiaryZip { get; set; }

        public string TertiaryTypeTraining { get; set; }

        public string TertiarySpecialty { get; set; }

        public DateTime TertiaryFrom { get; set; }

        public DateTime TertiaryTo { get; set; }

        public bool TertiaryCompleted { get; set; }

        public virtual ICollection<Attachment>  Attachments { get; set; }
    }
}
