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

        public DateTime PrimaryStartDate { get; set; }

        public DateTime PrimaryEndDate { get; set; }

        // secondary
        public string SecondaryNamePracticeEmployer { get; set; }

        public string SecondaryContactName { get; set; }

        public string SecondaryTelephoneNumber { get; set; }

        public string SecondaryFaxNumber { get; set; }

        public string SecondaryPracticeAddress { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryState { get; set; }

        public string SecondaryZip { get; set; }

        public DateTime SecondaryStartDate { get; set; }

        public DateTime SecondaryEndDate { get; set; }


        // tertiary
        public string TertiaryNamePracticeEmployer { get; set; }

        public string TertiaryContactName { get; set; }

        public string TertiaryTelephoneNumber { get; set; }

        public string TertiaryFaxNumber { get; set; }

        public string TertiaryPracticeAddress { get; set; }

        public string TertiaryCity { get; set; }

        public string TertiaryState { get; set; }

        public string TertiaryZip { get; set; }

        public DateTime TertiaryStartDate { get; set; }

        public DateTime TertiaryEndDate { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}