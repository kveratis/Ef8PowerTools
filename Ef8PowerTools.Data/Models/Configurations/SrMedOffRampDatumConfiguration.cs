﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrMedOffRampDatumConfiguration : IEntityTypeConfiguration<SrMedOffRampDatum>
    {
        public void Configure(EntityTypeBuilder<SrMedOffRampDatum> entity)
        {
            entity.HasKey(e => e.SrMedOffRampDataId).HasName("Pk_SR_MedOffRampDataNew_SR_MedOffRampDataId");

            entity.ToTable("SR_MedOffRampData");

            entity.HasIndex(e => e.SrOffRampId, "UIDX_SR_MedOffRampDataNew_SR_OffRampId").IsUnique();

            entity.Property(e => e.SrMedOffRampDataId).HasColumnName("SR_MedOffRampDataId");
            entity.Property(e => e.AccumulatorDetailsDeductibleFamilyAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsDeductibleIndividualAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsDeductibleIndividualAmountMet).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxFamilyAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxFamilyAmountMet).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxIndividualAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxIndividualAmountMet).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsdseductibleFamilyAmountMet).HasMaxLength(128);
            entity.Property(e => e.CallingTransactionId).HasMaxLength(50);
            entity.Property(e => e.CallingTransactionType).HasMaxLength(50);
            entity.Property(e => e.CobSummaryAdminAmount).HasMaxLength(128);
            entity.Property(e => e.CobSummaryDeductibleRemaining).HasMaxLength(128);
            entity.Property(e => e.CobSummaryOfficeVisitAmount).HasMaxLength(128);
            entity.Property(e => e.CobSummaryProductAmount).HasMaxLength(128);
            entity.Property(e => e.CobSummarymedicareSupplementLetter).HasMaxLength(128);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataserviceRequested).HasMaxLength(128);
            entity.Property(e => e.DateOfService).HasColumnType("datetime");
            entity.Property(e => e.DrugRequirementsBuyBillPermitted).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPredeterminationAvailable).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPredeterminationRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPriorAuthorizationChannel).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPriorAuthorizationEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.DrugRequirementsPriorAuthorizationEndDate).HasColumnType("datetime");
            entity.Property(e => e.DrugRequirementsPriorAuthorizationNumber).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPriorTherapyRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyAvailable).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyName).HasMaxLength(100);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsTherapyRestrictionNotes).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsisPriorAuthorizationOnFile).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementspriorAuthorizationRequired).HasMaxLength(128);
            entity.Property(e => e.EscalationReason).HasMaxLength(255);
            entity.Property(e => e.ExternalCaseId1).HasMaxLength(100);
            entity.Property(e => e.ExternalCaseId2).HasMaxLength(100);
            entity.Property(e => e.ExternalCaseId3).HasMaxLength(100);
            entity.Property(e => e.ExternalPatientId1).HasMaxLength(100);
            entity.Property(e => e.ExternalPatientId2).HasMaxLength(100);
            entity.Property(e => e.ExternalPatientId3).HasMaxLength(100);
            entity.Property(e => e.ExternalPracticeId1).HasMaxLength(100);
            entity.Property(e => e.ExternalPracticeId2).HasMaxLength(100);
            entity.Property(e => e.ExternalPracticeId3).HasMaxLength(100);
            entity.Property(e => e.ExternalProviderId1).HasMaxLength(100);
            entity.Property(e => e.ExternalProviderId2).HasMaxLength(100);
            entity.Property(e => e.ExternalProviderId3).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.ManualBvRequestId).HasMaxLength(36);
            entity.Property(e => e.ManualBvResponseId).HasMaxLength(36);
            entity.Property(e => e.MedEbvOffRampStatus).HasMaxLength(38);
            entity.Property(e => e.MedEbvResponseId).HasMaxLength(38);
            entity.Property(e => e.MedEbvResponseStatus).HasMaxLength(38);
            entity.Property(e => e.MedEbvResponseTypeCode).HasMaxLength(255);
            entity.Property(e => e.MedEbvResponseTypeCodeFinal).HasMaxLength(255);
            entity.Property(e => e.MedEbvResponseTypeMessage).HasMaxLength(255);
            entity.Property(e => e.MedicationDaysSupply).HasMaxLength(200);
            entity.Property(e => e.MedicationJcode)
                .HasMaxLength(200)
                .HasColumnName("MedicationJCode");
            entity.Property(e => e.MedicationManufactureName).HasMaxLength(200);
            entity.Property(e => e.MedicationNdc)
                .HasMaxLength(200)
                .HasColumnName("MedicationNDC");
            entity.Property(e => e.MedicationProductName).HasMaxLength(200);
            entity.Property(e => e.MedicationQuantity).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.NextScheduledDate).HasColumnType("datetime");
            entity.Property(e => e.NonDuplicationCoverage).HasMaxLength(50);
            entity.Property(e => e.OfficeVisitDetailsCoInsApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsCoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsCopayApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsPcpCopayAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsSpecialistCopayAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.OtherCoverageMemberId)
                .HasMaxLength(128)
                .HasColumnName("OtherCoverageMemberID");
            entity.Property(e => e.OtherCoverageName).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageResultBenefitVerificationTransactionId).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageResultGovernmentPlanDetected).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageResultGovernmentPolicyType).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageResultMedicalPolicy).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageResultPolicyMessageId).HasMaxLength(128);
            entity.Property(e => e.OtherCoverageResultbenefitVerificationTransactionDate).HasColumnType("datetime");
            entity.Property(e => e.OutcomeKey).HasMaxLength(100);
            entity.Property(e => e.OutcomeKeyDescription).HasMaxLength(100);
            entity.Property(e => e.PatientCity).HasMaxLength(100);
            entity.Property(e => e.PatientCountry).HasMaxLength(50);
            entity.Property(e => e.PatientDob).HasColumnType("datetime");
            entity.Property(e => e.PatientEmail).HasMaxLength(150);
            entity.Property(e => e.PatientFirstName).HasMaxLength(128);
            entity.Property(e => e.PatientGender).HasMaxLength(10);
            entity.Property(e => e.PatientLastName).HasMaxLength(128);
            entity.Property(e => e.PatientMedicareId).HasMaxLength(150);
            entity.Property(e => e.PatientMiddleName).HasMaxLength(128);
            entity.Property(e => e.PatientPrefix).HasMaxLength(128);
            entity.Property(e => e.PatientSsn).HasMaxLength(11);
            entity.Property(e => e.PatientState).HasMaxLength(10);
            entity.Property(e => e.PatientSubscriberId).HasMaxLength(150);
            entity.Property(e => e.PatientSuffix).HasMaxLength(128);
            entity.Property(e => e.PatientTitle).HasMaxLength(128);
            entity.Property(e => e.PatientZipCode).HasMaxLength(16);
            entity.Property(e => e.PolicyHighLevelInfoEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyHighLevelInfoEligibilityStatus).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoEndDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyHighLevelInfoGroupName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoGroupNumber).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPayerId).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPayerName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPayerType).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPlanName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPlanType).HasMaxLength(128);
            entity.Property(e => e.PracticeCity)
                .HasMaxLength(100)
                .HasColumnName("PracticeCIty");
            entity.Property(e => e.PracticeCountry).HasMaxLength(50);
            entity.Property(e => e.PracticeEmail).HasMaxLength(200);
            entity.Property(e => e.PracticeExternalOrganizationId1).HasMaxLength(100);
            entity.Property(e => e.PracticeExternalOrganizationId2).HasMaxLength(100);
            entity.Property(e => e.PracticeExternalOrganizationId3).HasMaxLength(100);
            entity.Property(e => e.PracticeFaxNumber).HasMaxLength(100);
            entity.Property(e => e.PracticeFaxType).HasMaxLength(100);
            entity.Property(e => e.PracticeFirstName).HasMaxLength(128);
            entity.Property(e => e.PracticeLastName).HasMaxLength(128);
            entity.Property(e => e.PracticeLegalName).HasMaxLength(55);
            entity.Property(e => e.PracticeMiddleName).HasMaxLength(128);
            entity.Property(e => e.PracticeName).HasMaxLength(55);
            entity.Property(e => e.PracticeNpi).HasMaxLength(10);
            entity.Property(e => e.PracticeOrganizationCity)
                .HasMaxLength(100)
                .HasColumnName("PracticeOrganizationCIty");
            entity.Property(e => e.PracticeOrganizationCountry).HasMaxLength(50);
            entity.Property(e => e.PracticeOrganizationEmail).HasMaxLength(200);
            entity.Property(e => e.PracticeOrganizationLegalName).HasMaxLength(128);
            entity.Property(e => e.PracticeOrganizationName).HasMaxLength(128);
            entity.Property(e => e.PracticeOrganizationNpi)
                .HasMaxLength(100)
                .HasColumnName("PracticeOrganizationNPI");
            entity.Property(e => e.PracticeOrganizationState).HasMaxLength(10);
            entity.Property(e => e.PracticeOrganizationTaxId).HasMaxLength(100);
            entity.Property(e => e.PracticeOrganizationWebsite).HasMaxLength(200);
            entity.Property(e => e.PracticeOrganizationZipCode).HasMaxLength(16);
            entity.Property(e => e.PracticePhoneExtension).HasMaxLength(100);
            entity.Property(e => e.PracticePhoneNumber).HasMaxLength(100);
            entity.Property(e => e.PracticePhoneType).HasMaxLength(100);
            entity.Property(e => e.PracticePlaceOfService).HasMaxLength(400);
            entity.Property(e => e.PracticePrefix).HasMaxLength(128);
            entity.Property(e => e.PracticeState).HasMaxLength(10);
            entity.Property(e => e.PracticeSuffix).HasMaxLength(128);
            entity.Property(e => e.PracticeTitle).HasMaxLength(128);
            entity.Property(e => e.PracticeWebsite).HasMaxLength(200);
            entity.Property(e => e.PracticeZipCode).HasMaxLength(16);
            entity.Property(e => e.ProductStatusDetailsCoInsApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsCopayApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsPcpCopayAmount).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsSpecialistCopayAmount).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailscoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ProviderEmail).HasMaxLength(200);
            entity.Property(e => e.ProviderExternalPracticeId1).HasMaxLength(100);
            entity.Property(e => e.ProviderExternalPracticeId2).HasMaxLength(100);
            entity.Property(e => e.ProviderExternalPracticeId3).HasMaxLength(100);
            entity.Property(e => e.ProviderFirstName).HasMaxLength(128);
            entity.Property(e => e.ProviderId).HasMaxLength(36);
            entity.Property(e => e.ProviderLastName).HasMaxLength(128);
            entity.Property(e => e.ProviderMiddleName).HasMaxLength(128);
            entity.Property(e => e.ProviderNpi).HasMaxLength(10);
            entity.Property(e => e.ProviderPracticeCity).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeCountry).HasMaxLength(50);
            entity.Property(e => e.ProviderPracticeEmail).HasMaxLength(200);
            entity.Property(e => e.ProviderPracticeExternalOrganizationId1).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeExternalOrganizationId2).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeExternalOrganizationId3).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeExternalOrganizationLegalName).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeExternalOrganizationName).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeExternalOrganizationNpi)
                .HasMaxLength(100)
                .HasColumnName("ProviderPracticeExternalOrganizationNPI");
            entity.Property(e => e.ProviderPracticeExternalOrganizationTaxId).HasMaxLength(100);
            entity.Property(e => e.ProviderPracticeFirstName).HasMaxLength(128);
            entity.Property(e => e.ProviderPracticeLastName).HasMaxLength(128);
            entity.Property(e => e.ProviderPracticeLegalName).HasMaxLength(55);
            entity.Property(e => e.ProviderPracticeMiddleName).HasMaxLength(128);
            entity.Property(e => e.ProviderPracticeName).HasMaxLength(55);
            entity.Property(e => e.ProviderPracticeNpi).HasMaxLength(10);
            entity.Property(e => e.ProviderPracticeOrganizationCity)
                .HasMaxLength(100)
                .HasColumnName("ProviderPracticeOrganizationCIty");
            entity.Property(e => e.ProviderPracticeOrganizationCountry).HasMaxLength(50);
            entity.Property(e => e.ProviderPracticeOrganizationEmail).HasMaxLength(200);
            entity.Property(e => e.ProviderPracticeOrganizationState).HasMaxLength(10);
            entity.Property(e => e.ProviderPracticeOrganizationWebsite).HasMaxLength(200);
            entity.Property(e => e.ProviderPracticeOrganizationZipCode).HasMaxLength(16);
            entity.Property(e => e.ProviderPracticePlaceOfService).HasMaxLength(400);
            entity.Property(e => e.ProviderPracticePrefix).HasMaxLength(128);
            entity.Property(e => e.ProviderPracticeState).HasMaxLength(10);
            entity.Property(e => e.ProviderPracticeSuffix).HasMaxLength(128);
            entity.Property(e => e.ProviderPracticeTitle).HasMaxLength(128);
            entity.Property(e => e.ProviderPracticeWebsite).HasMaxLength(200);
            entity.Property(e => e.ProviderPracticeZipCode).HasMaxLength(16);
            entity.Property(e => e.ProviderPrefix).HasMaxLength(128);
            entity.Property(e => e.ProviderSpecialty).HasMaxLength(40);
            entity.Property(e => e.ProviderSuffix).HasMaxLength(128);
            entity.Property(e => e.ProviderTexId).HasMaxLength(10);
            entity.Property(e => e.ProviderTitle).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsApplicationName).HasMaxLength(500);
            entity.Property(e => e.RequestingPartyDetailsEmail).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsFax).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsFirstName).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsLastName).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsPhone).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsPhoneType).HasMaxLength(128);
            entity.Property(e => e.RequestingPartyDetailsUserName).HasMaxLength(128);
            entity.Property(e => e.ResponseDataElectronicBenefitVerificationReport).HasMaxLength(128);
            entity.Property(e => e.ResponseDataelElectronicBenefitVerificationReportType).HasMaxLength(128);
            entity.Property(e => e.SecondaryCoordinateBenefits).HasMaxLength(100);
            entity.Property(e => e.SecondaryCopayOopmax)
                .HasMaxLength(100)
                .HasColumnName("SecondaryCopayOOPMax");
            entity.Property(e => e.SecondaryCoverPartBdeductible).HasMaxLength(100);
            entity.Property(e => e.SecondaryOfficeVisitCopayApply).HasMaxLength(100);
            entity.Property(e => e.SecondaryfollowMedicareguidelines).HasMaxLength(100);
            entity.Property(e => e.SrOffRampId).HasColumnName("SR_OffRampId");
            entity.Property(e => e.TransactionRequestId).HasMaxLength(36);
            entity.Property(e => e.TransactionResponseId).HasMaxLength(36);

            entity.HasOne(d => d.SrOffRamp).WithOne(p => p.SrMedOffRampDatum)
                .HasForeignKey<SrMedOffRampDatum>(d => d.SrOffRampId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_MedOffRampDataNew_SR_OffRamp");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrMedOffRampDatum> entity);
    }
}
