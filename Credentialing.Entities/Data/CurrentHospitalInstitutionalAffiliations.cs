using System;

namespace Credentialing.Entities.Data
{
    public class CurrentHospitalInstitutionalAffiliations
    {
        public CurrentHospitalInstitutionalAffiliations()
        {
        }

        public int CurrentHospitalInstitutionalAffiliationsId { get; set; }

        // current affiliations
        // primary
        public string CurrentPrimaryAdmittingHospital { get; set; }

        public string CurrentPrimaryCity { get; set; }

        public string CurrentPrimaryState { get; set; }

        public string CurrentPrimaryZip { get; set; }

        public string CurrentPrimaryDepartmentStatus { get; set; }

        public DateTime CurrentPrimaryAppointmentDate { get; set; }

        // secondary
        public string CurrentSecondaryAdmittingHospital { get; set; }

        public string CurrentSecondaryCity { get; set; }

        public string CurrentSecondaryState { get; set; }

        public string CurrentSecondaryZip { get; set; }

        public string CurrentSecondaryDepartmentStatus { get; set; }

        public DateTime CurrentSecondaryAppointmentDate { get; set; }

        // tertiary
        public string CurrentTertiaryAdmittingHospital { get; set; }

        public string CurrentTertiaryCity { get; set; }

        public string CurrentTertiaryState { get; set; }

        public string CurrentTertiaryZip { get; set; }

        public string CurrentTertiaryDepartmentStatus { get; set; }

        public DateTime CurrentTertiaryAppointmentDate { get; set; }


        // previous affiliations
        // primary
        public string PreviousPrimaryAdmittingHospital { get; set; }

        public string PreviousPrimaryCity { get; set; }

        public string PreviousPrimaryState { get; set; }

        public string PreviousPrimaryZip { get; set; }

        public string PreviousPrimaryDepartmentStatus { get; set; }

        public DateTime PreviousPrimaryAppointmentDate { get; set; }

        // secondary
        public string PreviousSecondaryAdmittingHospital { get; set; }

        public string PreviousSecondaryCity { get; set; }

        public string PreviousSecondaryState { get; set; }

        public string PreviousSecondaryZip { get; set; }

        public string PreviousSecondaryDepartmentStatus { get; set; }

        public DateTime PreviousSecondaryAppointmentDate { get; set; }

        // tertiary
        public string PreviousTertiaryAdmittingHospital { get; set; }

        public string PreviousTertiaryCity { get; set; }

        public string PreviousTertiaryState { get; set; }

        public string PreviousTertiaryZip { get; set; }

        public string PreviousTertiaryDepartmentStatus { get; set; }

        public DateTime PreviousTertiaryAppointmentDate { get; set; }
        
    }
}