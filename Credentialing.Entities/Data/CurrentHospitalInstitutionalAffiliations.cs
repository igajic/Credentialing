using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class CurrentHospitalInstitutionalAffiliations
    {
        public CurrentHospitalInstitutionalAffiliations()
        {
            Attachments = new List<Attachment>();
        }

        public int CurrentHospitalInstitutionalAffiliationsId { get; set; }

        // current affiliations
        // primary
        public string CurrentPrimaryAdmittingHospital { get; set; }

        public string CurrentPrimaryCity { get; set; }

        public string CurrentPrimaryState { get; set; }

        public string CurrentPrimaryZip { get; set; }

        public string CurrentPrimaryDepartmentStatus { get; set; }

        public DateTime? CurrentPrimaryAppointmentDate { get; set; }

        // secondary
        public string CurrentSecondaryAdmittingHospital { get; set; }

        public string CurrentSecondaryCity { get; set; }

        public string CurrentSecondaryState { get; set; }

        public string CurrentSecondaryZip { get; set; }

        public string CurrentSecondaryDepartmentStatus { get; set; }

        public DateTime? CurrentSecondaryAppointmentDate { get; set; }

        // tertiary
        public string CurrentTertiaryAdmittingHospital { get; set; }

        public string CurrentTertiaryCity { get; set; }

        public string CurrentTertiaryState { get; set; }

        public string CurrentTertiaryZip { get; set; }

        public string CurrentTertiaryDepartmentStatus { get; set; }

        public DateTime? CurrentTertiaryAppointmentDate { get; set; }

        // previous affiliations
        // primary
        public string PreviousPrimaryAdmittingHospital { get; set; }

        public string PreviousPrimaryCity { get; set; }

        public string PreviousPrimaryState { get; set; }

        public string PreviousPrimaryZip { get; set; }

        public string PreviousPrimaryDepartmentStatus { get; set; }

        public DateTime? PreviousPrimaryAppointmentDate { get; set; }

        public DateTime? PreviousPrimaryAppointmentDateTo { get; set; }

        // secondary
        public string PreviousSecondaryAdmittingHospital { get; set; }

        public string PreviousSecondaryCity { get; set; }

        public string PreviousSecondaryState { get; set; }

        public string PreviousSecondaryZip { get; set; }

        public string PreviousSecondaryDepartmentStatus { get; set; }

        public DateTime? PreviousSecondaryAppointmentDate { get; set; }

        public DateTime? PreviousSecondaryAppointmentDateTo  { get; set; }

        // tertiary
        public string PreviousTertiaryAdmittingHospital { get; set; }

        public string PreviousTertiaryCity { get; set; }

        public string PreviousTertiaryState { get; set; }

        public string PreviousTertiaryZip { get; set; }

        public string PreviousTertiaryDepartmentStatus { get; set; }

        public DateTime? PreviousTertiaryAppointmentDate { get; set; }

        public DateTime? PreviousTertiaryAppointmentDateTo { get; set; }

        public bool? Completed { get; set; }

        public List<Attachment>  Attachments { get; set; }

        public int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = CurrentPrimaryAdmittingHospital.IsCompleted();
                tmp += CurrentPrimaryCity.IsCompleted();
                tmp += CurrentPrimaryState.IsCompleted();
                tmp += CurrentPrimaryZip.IsCompleted();
                tmp += CurrentPrimaryDepartmentStatus.IsCompleted();
                tmp += CurrentPrimaryAppointmentDate.HasValue ? 1 : 0;

                // secondary
                tmp += CurrentSecondaryAdmittingHospital.IsCompleted();
                tmp += CurrentSecondaryCity.IsCompleted();
                tmp += CurrentSecondaryState.IsCompleted();
                tmp += CurrentSecondaryZip.IsCompleted();
                tmp += CurrentSecondaryDepartmentStatus.IsCompleted();
                tmp += CurrentSecondaryAppointmentDate.HasValue ? 1 : 0;

                // tertiary
                tmp += CurrentTertiaryAdmittingHospital.IsCompleted();
                tmp += CurrentTertiaryCity.IsCompleted();
                tmp += CurrentTertiaryState.IsCompleted();
                tmp += CurrentTertiaryZip.IsCompleted();
                tmp += CurrentTertiaryDepartmentStatus.IsCompleted();
                tmp += CurrentTertiaryAppointmentDate.HasValue ? 1 : 0;

                // previous affiliations
                // primary
                tmp += PreviousPrimaryAdmittingHospital.IsCompleted();
                tmp += PreviousPrimaryCity.IsCompleted();
                tmp += PreviousPrimaryState.IsCompleted();
                tmp += PreviousPrimaryZip.IsCompleted();
                tmp += PreviousPrimaryDepartmentStatus.IsCompleted();
                tmp += PreviousPrimaryAppointmentDate.HasValue ? 1 : 0;
                tmp += PreviousPrimaryAppointmentDateTo.HasValue ? 1 : 0;

                // secondary
                tmp += PreviousSecondaryAdmittingHospital.IsCompleted();
                tmp += PreviousSecondaryCity.IsCompleted();
                tmp += PreviousSecondaryState.IsCompleted();
                tmp += PreviousSecondaryZip.IsCompleted();
                tmp += PreviousSecondaryDepartmentStatus.IsCompleted();
                tmp += PreviousSecondaryAppointmentDate.HasValue ? 1 : 0;
                tmp += PreviousSecondaryAppointmentDateTo.HasValue ? 1 : 0;

                // tertiary
                tmp += PreviousTertiaryAdmittingHospital.IsCompleted();
                tmp += PreviousTertiaryCity.IsCompleted();
                tmp += PreviousTertiaryState.IsCompleted();
                tmp += PreviousTertiaryZip.IsCompleted();
                tmp += PreviousTertiaryDepartmentStatus.IsCompleted();
                tmp += PreviousTertiaryAppointmentDate.HasValue ? 1 : 0;
                tmp += PreviousTertiaryAppointmentDateTo.HasValue ? 1 : 0;

                return 100 * tmp / 39;
            }
        }
    }
}