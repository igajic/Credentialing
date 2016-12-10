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

        public DateTime? PrimaryDateCertifiedRecertified { get; set; }

        public DateTime? PrimaryExpirationDate { get; set; }

        // secondary
        public string SecondaryNameIssuingBoard { get; set; }

        public string SecondarySpecialty { get; set; }

        public DateTime? SecondaryDateCertifiedRecertified { get; set; }

        public DateTime? SecondaryExpirationDate { get; set; }

        // tertiary
        public string TertiaryNameIssuingBoard { get; set; }

        public string TertiarySpecialty { get; set; }

        public DateTime? TertiaryDateCertifiedRecertified { get; set; }

        public DateTime? TertiaryExpirationDate { get; set; }

        public bool? AdditionalBoards { get; set; }

        public string AdditionalListBoardsDates { get; set; }

        public int? AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                // primary
                var tmp = PrimaryNameIssuingBoard.IsCompleted();
                tmp += PrimarySpecialty.IsCompleted();
                tmp += PrimaryDateCertifiedRecertified.HasValue ? 1 : 0;
                tmp += PrimaryExpirationDate.HasValue ? 1 : 0;

                // secondary
                tmp += SecondaryNameIssuingBoard.IsCompleted();
                tmp += SecondarySpecialty.IsCompleted();
                tmp += SecondaryDateCertifiedRecertified.HasValue ? 1 : 0;
                tmp += SecondaryExpirationDate.HasValue ? 1 : 0;

                // tertiary
                tmp += TertiaryNameIssuingBoard.IsCompleted();
                tmp += TertiarySpecialty.IsCompleted();
                tmp += TertiaryDateCertifiedRecertified.HasValue ? 1 : 0;
                tmp += TertiaryExpirationDate.HasValue ? 1 : 0;

                tmp += AdditionalBoards.HasValue ? 1 : 0;
                tmp += AdditionalListBoardsDates.IsCompleted();

                return 100*tmp/14;
            }
        }
    }
}