using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class WorkHistory
    {
        public WorkHistory()
        {
        }

        public int WorkHistoryId { get; set; }

        // primary
        public string PrimaryNamePracticeEmployer { get; set; }

        public string PrimaryContactName { get; set; }

        public string PrimaryTelephoneNumber { get; set; }

        public string PrimaryFaxNumber { get; set; }

        public string PrimaryPracticeAddress { get; set; }

        public string PrimaryCity { get; set; }

        public string PrimaryState { get; set; }

        public string PrimaryZip { get; set; }

        public DateTime? PrimaryStartDate { get; set; }

        public DateTime? PrimaryEndDate { get; set; }

        // secondary
        public string SecondaryNamePracticeEmployer { get; set; }

        public string SecondaryContactName { get; set; }

        public string SecondaryTelephoneNumber { get; set; }

        public string SecondaryFaxNumber { get; set; }

        public string SecondaryPracticeAddress { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryState { get; set; }

        public string SecondaryZip { get; set; }

        public DateTime? SecondaryStartDate { get; set; }

        public DateTime? SecondaryEndDate { get; set; }

        // tertiary
        public string TertiaryNamePracticeEmployer { get; set; }

        public string TertiaryContactName { get; set; }

        public string TertiaryTelephoneNumber { get; set; }

        public string TertiaryFaxNumber { get; set; }

        public string TertiaryPracticeAddress { get; set; }

        public string TertiaryCity { get; set; }

        public string TertiaryState { get; set; }

        public string TertiaryZip { get; set; }

        public DateTime? TertiaryStartDate { get; set; }

        public DateTime? TertiaryEndDate { get; set; }

        public bool? Completed { get; set; }

        public string Explanation { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = PrimaryNamePracticeEmployer.IsCompleted();
                tmp += PrimaryContactName.IsCompleted();
                tmp += PrimaryTelephoneNumber.IsCompleted();
                tmp += PrimaryFaxNumber.IsCompleted();
                tmp += PrimaryPracticeAddress.IsCompleted();
                tmp += PrimaryCity.IsCompleted();
                tmp += PrimaryState.IsCompleted();
                tmp += PrimaryZip.IsCompleted();
                tmp += PrimaryStartDate.HasValue ? 1 : 0;
                tmp += PrimaryEndDate.HasValue ? 1 : 0;

                // secondary
                tmp += SecondaryNamePracticeEmployer.IsCompleted();
                tmp += SecondaryContactName.IsCompleted();
                tmp += SecondaryTelephoneNumber.IsCompleted();
                tmp += SecondaryFaxNumber.IsCompleted();
                tmp += SecondaryPracticeAddress.IsCompleted();
                tmp += SecondaryCity.IsCompleted();
                tmp += SecondaryState.IsCompleted();
                tmp += SecondaryZip.IsCompleted();
                tmp += SecondaryStartDate.HasValue ? 1 : 0;
                tmp += SecondaryEndDate.HasValue ? 1 : 0;

                // tertiary
                tmp += TertiaryNamePracticeEmployer.IsCompleted();
                tmp += TertiaryContactName.IsCompleted();
                tmp += TertiaryTelephoneNumber.IsCompleted();
                tmp += TertiaryFaxNumber.IsCompleted();
                tmp += TertiaryPracticeAddress.IsCompleted();
                tmp += TertiaryCity.IsCompleted();
                tmp += TertiaryState.IsCompleted();
                tmp += TertiaryZip.IsCompleted();
                tmp += TertiaryStartDate.HasValue ? 1 : 0;
                tmp += TertiaryEndDate.HasValue ? 1 : 0;

                return 100 * tmp / 30;
            }
        }
    }
}