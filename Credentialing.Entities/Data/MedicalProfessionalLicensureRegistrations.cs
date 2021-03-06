﻿using System;
using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class MedicalProfessionalLicensureRegistrations
    {
        public MedicalProfessionalLicensureRegistrations()
        {
            Attachments = new List<Attachment>();
        }

        public int MedicalProfessionalLicensureRegistrationsId { get; set; }

        public string PrimaryStateMedicalLicenseNumber { get; set; }

        public string LicensureState { get; set; }

        public DateTime? PrimaryStateMedicalLicenseIssueDate { get; set; }

        public DateTime? PrimaryStateMedicalLicenseExpirationDate { get; set; }

        public string DrugAdministrationNumber { get; set; }

        public DateTime? DrugAdministrationExpirationDate { get; set; }

        public string StateControlledSubstancesCertificate { get; set; }

        public DateTime? StateControlledSubstancesCertificateExpirationDate { get; set; }

        public string ECFMGNumber { get; set; }

        public DateTime? ECFMGNumberIssueDate { get; set; }

        public string MedicareNationalPhysicianIdentifier { get; set; }

        public string MedicaidNumber { get; set; }

        public bool? Completed { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = PrimaryStateMedicalLicenseNumber.IsCompleted();
                tmp += LicensureState.IsCompleted();
                tmp += PrimaryStateMedicalLicenseIssueDate.HasValue ? 1 : 0;
                tmp += PrimaryStateMedicalLicenseExpirationDate.HasValue ? 1 : 0;
                tmp += DrugAdministrationNumber.IsCompleted();
                tmp += DrugAdministrationExpirationDate.HasValue ? 1 : 0;
                tmp += StateControlledSubstancesCertificate.IsCompleted();
                tmp += StateControlledSubstancesCertificateExpirationDate.HasValue ? 1 : 0;

                tmp += ECFMGNumber.IsCompleted();
                tmp += ECFMGNumberIssueDate.HasValue ? 1 : 0;
                tmp += MedicareNationalPhysicianIdentifier.IsCompleted();
                tmp += MedicaidNumber.IsCompleted();

                return 100 * tmp / 12;
            }
        }
    }
}