using System;

namespace Credentialing.Entities.Data
{
    public class ProfessionalLiability
    {
        public ProfessionalLiability()
        {
        }

        public int ProfessionalLiabilityId { get; set; }

        public string CurrentInsuranceCarrier { get; set; }

        public string CurrentPolicyNumber { get; set; }

        public DateTime? InitialEffectiverDate { get; set; }

        public string CurrentMailingAddress { get; set; }

        public string CurrentCity { get; set; }

        public string CurrentState { get; set; }

        public string CurrentZip { get; set; }

        public decimal? CurrentPerClaimAmount { get; set; }

        public decimal? CurrentAggregateAmount { get; set; }

        public DateTime? CurrentExpirationDate { get; set; }

        // Previous liability carriers

        // first
        public string FirstPolicyCarrierName { get; set; }

        public string FirstPolicyNumber { get; set; }

        public DateTime? FirstFromDate { get; set; }

        public DateTime? FirstToDate { get; set; }

        public string FirstMailingAddress { get; set; }

        public string FirstCity { get; set; }

        public string FirstState { get; set; }

        public string FirstZip { get; set; }

        // second
        public string SecondPolicyCarrierName { get; set; }

        public string SecondPolicyNumber { get; set; }

        public DateTime? SecondFromDate { get; set; }

        public DateTime? SecondToDate { get; set; }

        public string SecondMailingAddress { get; set; }

        public string SecondCity { get; set; }

        public string SecondState { get; set; }

        public string SecondZip { get; set; }

        // third
        public string ThirdPolicyCarrierName { get; set; }

        public string ThirdPolicyNumber { get; set; }

        public DateTime? ThirdFromDate { get; set; }

        public DateTime? ThirdToDate { get; set; }

        public string ThirdMailingAddress { get; set; }

        public string ThirdCity { get; set; }

        public string ThirdState { get; set; }

        public string ThirdZip { get; set; }

        // fourth
        public string FourthPolicyCarrierName { get; set; }

        public string FourthPolicyNumber { get; set; }

        public DateTime? FourthFromDate { get; set; }

        public DateTime? FourthToDate { get; set; }

        public string FourthMailingAddress { get; set; }

        public string FourthCity { get; set; }

        public string FourthState { get; set; }

        public string FourthZip { get; set; }

        public bool? Completed { get; set; }

        public int? AttachmentId { get; set; }

        // reference fields
        public virtual Attachment Attachment { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = CurrentInsuranceCarrier.IsCompleted();
                tmp += CurrentPolicyNumber.IsCompleted();
                tmp += InitialEffectiverDate.HasValue ? 1 : 0;
                tmp += CurrentMailingAddress.IsCompleted();
                tmp += CurrentCity.IsCompleted();
                tmp += CurrentState.IsCompleted();
                tmp += CurrentZip.IsCompleted();
                tmp += CurrentPerClaimAmount.HasValue ? 1 : 0;
                tmp += CurrentAggregateAmount.HasValue ? 1 : 0;
                tmp += CurrentExpirationDate.HasValue ? 1 : 0;
                // Previous liability carriers

                // firstUpda
                tmp += FirstPolicyCarrierName.IsCompleted();
                tmp += FirstPolicyNumber.IsCompleted();
                tmp += FirstFromDate.HasValue ? 1 : 0;
                tmp += FirstToDate.HasValue ? 1 : 0;
                tmp += FirstMailingAddress.IsCompleted();
                tmp += FirstCity.IsCompleted();
                tmp += FirstState.IsCompleted();
                tmp += FirstZip.IsCompleted();

                // second
                tmp += SecondPolicyCarrierName.IsCompleted();
                tmp += SecondPolicyNumber.IsCompleted();
                tmp += SecondFromDate.HasValue ? 1 : 0;
                tmp += SecondToDate.HasValue ? 1 : 0;
                tmp += SecondMailingAddress.IsCompleted();
                tmp += SecondCity.IsCompleted();
                tmp += SecondState.IsCompleted();
                tmp += SecondZip.IsCompleted();

                // third
                tmp += ThirdPolicyCarrierName.IsCompleted();
                tmp += ThirdPolicyNumber.IsCompleted();
                tmp += ThirdFromDate.HasValue ? 1 : 0;
                tmp += ThirdToDate.HasValue ? 1 : 0;
                tmp += ThirdMailingAddress.IsCompleted();
                tmp += ThirdCity.IsCompleted();
                tmp += ThirdState.IsCompleted();
                tmp += ThirdZip.IsCompleted();

                // fourth
                tmp += FourthPolicyCarrierName.IsCompleted();
                tmp += FourthPolicyNumber.IsCompleted();
                tmp += FourthFromDate.HasValue ? 1 : 0;
                tmp += FourthToDate.HasValue ? 1 : 0;
                tmp += FourthMailingAddress.IsCompleted();
                tmp += FourthCity.IsCompleted();
                tmp += FourthState.IsCompleted();
                tmp += FourthZip.IsCompleted();

                return 100 * tmp / 42;
            }
        }
    }
}