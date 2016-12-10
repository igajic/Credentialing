using System;
using System.Collections.Generic;

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

        public DateTime? PrimaryFrom { get; set; }

        public DateTime? PrimaryTo { get; set; }

        public bool? PrimaryCompleted { get; set; }

        // secondary
        public string SecondaryInstitution { get; set; }

        public string SecondaryProgramDirector { get; set; }

        public string SecondaryMailingAddress { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryState { get; set; }

        public string SecondaryZip { get; set; }

        public string SecondaryTypeTraining { get; set; }

        public string SecondarySpecialty { get; set; }

        public DateTime? SecondaryFrom { get; set; }

        public DateTime? SecondaryTo { get; set; }

        public bool? SecondaryCompleted { get; set; }

        // tertiary
        public string TertiaryInstitution { get; set; }

        public string TertiaryProgramDirector { get; set; }

        public string TertiaryMailingAddress { get; set; }

        public string TertiaryCity { get; set; }

        public string TertiaryState { get; set; }

        public string TertiaryZip { get; set; }

        public string TertiaryTypeTraining { get; set; }

        public string TertiarySpecialty { get; set; }

        public DateTime? TertiaryFrom { get; set; }

        public DateTime? TertiaryTo { get; set; }

        public bool? TertiaryCompleted { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                var tmp = PrimaryInstitution.IsCompleted();
                tmp += PrimaryProgramDirector.IsCompleted();
                tmp += PrimaryMailingAddress.IsCompleted();
                tmp += PrimaryCity.IsCompleted();
                tmp += PrimaryState.IsCompleted();
                tmp += PrimaryZip.IsCompleted();
                tmp += PrimaryTypeTraining.IsCompleted();
                tmp += PrimarySpecialty.IsCompleted();
                tmp += PrimaryFrom.HasValue ? 1 : 0;
                tmp += PrimaryTo.HasValue ? 1 : 0;
                tmp += PrimaryCompleted.HasValue ? 1 : 0;

                // secondary
                tmp += SecondaryInstitution.IsCompleted();
                tmp += SecondaryProgramDirector.IsCompleted();
                tmp += SecondaryMailingAddress.IsCompleted();
                tmp += SecondaryCity.IsCompleted();
                tmp += SecondaryState.IsCompleted();
                tmp += SecondaryZip.IsCompleted();
                tmp += SecondaryTypeTraining.IsCompleted();
                tmp += SecondarySpecialty.IsCompleted();
                tmp += SecondaryFrom.HasValue ? 1 : 0;
                tmp += SecondaryTo.HasValue ? 1 : 0;
                tmp += SecondaryCompleted.HasValue ? 1 : 0;

                // tertiary
                tmp += TertiaryInstitution.IsCompleted();
                tmp += TertiaryProgramDirector.IsCompleted();
                tmp += TertiaryMailingAddress.IsCompleted();
                tmp += TertiaryCity.IsCompleted();
                tmp += TertiaryState.IsCompleted();
                tmp += TertiaryZip.IsCompleted();
                tmp += TertiaryTypeTraining.IsCompleted();
                tmp += TertiarySpecialty.IsCompleted();
                tmp += TertiaryFrom.HasValue ? 1 : 0;
                tmp += TertiaryTo.HasValue ? 1 : 0;
                tmp += TertiaryCompleted.HasValue ? 1 : 0;

                return 100 * tmp / 33;
            }
        }
    }
}