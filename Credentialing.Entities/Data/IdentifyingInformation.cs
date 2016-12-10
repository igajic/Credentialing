using Credentialing.Entities.Enums;
using System;

namespace Credentialing.Entities.Data
{
    public class IdentifyingInformation
    {
        public IdentifyingInformation()
        {
        }

        public int IdentifyingInformationId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string OtherKnownNames { get; set; }

        public string HomeMailingAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string HomeTelephoneNumber { get; set; }

        public string HomeFaxNumber { get; set; }

        public string EmailAddress { get; set; }

        public string PagerNumber { get; set; }

        public DateTime? BirthDate { get; set; }

        public string BirthPlace { get; set; }

        public int? AttachmentId { get; set; }

        public string SocialSecurityNumber { get; set; }

        public Gender? Gender { get; set; }

        public string Specialty { get; set; }

        public string RaceEthnicity { get; set; }

        public string Subspecialties { get; set; }

        public Attachment Attachment { get; set; }

        public int PercentComplete
        {
            get
            {
                var tmp = LastName.IsCompleted();
                tmp += FirstName.IsCompleted();
                tmp += MiddleName.IsCompleted();
                tmp += OtherKnownNames.IsCompleted();
                tmp += HomeMailingAddress.IsCompleted();
                tmp += City.IsCompleted();
                tmp += State.IsCompleted();
                tmp += Zip.IsCompleted();
                tmp += HomeTelephoneNumber.IsCompleted();
                tmp += HomeFaxNumber.IsCompleted();
                tmp += EmailAddress.IsCompleted();
                tmp += PagerNumber.IsCompleted();
                tmp += (BirthDate.HasValue ? 1 : 0);
                tmp += BirthPlace.IsCompleted();
                tmp += SocialSecurityNumber.IsCompleted();
                tmp += Specialty.IsCompleted();
                tmp += Subspecialties.IsCompleted();

                return 100 * tmp / 17;
            }
        }
    }
}