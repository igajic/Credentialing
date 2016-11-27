using Credentialing.Entities.Enums;
using System;

namespace Credentialing.Entities.Steps
{
    public class IdentifyingInformationData
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string HomeMailingAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string HomeTelephoneNumber { get; set; }

        public string HomeFaxNumber { get; set; }

        public string EmailAddress { get; set; }

        public string PagerNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthPlace { get; set; }

        public string CitizenshipFile { get; set; }

        public string SocialSecurityNumber { get; set; }

        public Gender? Gender { get; set; }

        public string Specialty { get; set; }

        public string RaceEthnicity { get; set; }

        public string Subspecialties { get; set; }
    }
}