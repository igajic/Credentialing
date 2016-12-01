using System;

namespace Credentialing.Entities.Data
{
    public class BoardCertification
    {
        public BoardCertification()
        {
        }

        public int BoardCertificationId { get; set; }

        // primary
        public string PrimaryNameIssuingBoard { get; set; }

        public string PrimarySpecialty { get; set; }

        public DateTime PrimaryDateCertifiedRecertified { get; set; }

        public DateTime PrimaryExpirationDate { get; set; }

        // secondary
        public string SecondaryNameIssuingBoard { get; set; }

        public string SecondarySpecialty { get; set; }

        public DateTime SecondaryDateCertifiedRecertified { get; set; }

        public DateTime SecondaryExpirationDate { get; set; }

        // tertiary
        public string TertiaryNameIssuingBoard { get; set; }

        public string TertiarySpecialty { get; set; }

        public DateTime TertiaryDateCertifiedRecertified { get; set; }

        public DateTime TertiaryExpirationDate { get; set; }

        public bool AdditionalBoards { get; set; }

        public string AdditionalListBoardsDates { get; set; }

        public virtual Attachment Attachment { get; set; }
    }
}