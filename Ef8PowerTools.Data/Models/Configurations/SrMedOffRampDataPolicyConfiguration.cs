﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrMedOffRampDataPolicyConfiguration : IEntityTypeConfiguration<SrMedOffRampDataPolicy>
    {
        public void Configure(EntityTypeBuilder<SrMedOffRampDataPolicy> entity)
        {
            entity.HasKey(e => e.SrMedOffRampDataPolicyId).HasName("Pk_SR_MedOffRampDataPolicyNEW_SR_MedOffRampDataPolicyId");

            entity.ToTable("SR_MedOffRampDataPolicy", tb => tb.HasTrigger("tr_SR_MedOffRampDataPolicy_Update"));

            entity.HasIndex(e => new { e.Deleted, e.SrOffRampId, e.PolicyType, e.ProgramId }, "IX_NCI_SRMORDP_Deleted");

            entity.Property(e => e.SrMedOffRampDataPolicyId).HasColumnName("SR_MedOffRampDataPolicyId");
            entity.Property(e => e.AccumulatorDetailsAfterOopisMetServicesCovered100Percent)
                .HasMaxLength(128)
                .HasColumnName("AccumulatorDetailsAfterOOPIsMetServicesCovered100Percent");
            entity.Property(e => e.AccumulatorDetailsDeductibleAppliesToOop)
                .HasMaxLength(128)
                .HasColumnName("AccumulatorDetailsDeductibleAppliesToOOP");
            entity.Property(e => e.AccumulatorDetailsDeductibleFamilyAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsDeductibleIndividualAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsDeductibleIndividualAmountMet).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxFamilyAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxFamilyAmountMet).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxIndividualAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxIndividualAmountMet).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsdseductibleFamilyAmountMet).HasMaxLength(128);
            entity.Property(e => e.BenefitVerificationTransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("benefitVerificationTransactionDate");
            entity.Property(e => e.BenefitVerificationTransactionId).HasMaxLength(128);
            entity.Property(e => e.ConnectPayerPhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DrugRequirementsBuyBillPermitted).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPredeterminationAvailable).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPredeterminationRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPriorAuthorizationChannel).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPriorAuthorizationEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.DrugRequirementsPriorAuthorizationEndDate).HasColumnType("datetime");
            entity.Property(e => e.DrugRequirementsPriorAuthorizationNumber).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsPriorTherapyRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyAvailable).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsTherapyRestrictionNotes).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsisPriorAuthorizationOnFile).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementspriorAuthorizationRequired).HasMaxLength(128);
            entity.Property(e => e.GovernmentPlanDetected)
                .HasMaxLength(128)
                .HasColumnName("governmentPlanDetected");
            entity.Property(e => e.GovernmentPolicyType)
                .HasMaxLength(128)
                .HasColumnName("governmentPolicyType");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.MedEPayerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Med_ePayerID");
            entity.Property(e => e.MedicalPolicy).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsCoInsApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsCoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsCode).HasMaxLength(100);
            entity.Property(e => e.OfficeVisitDetailsCopayApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsPcpCopayAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsSpecialistCopayAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.PayerPhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHighLevelInfoConnectPayerOptionCode).HasMaxLength(256);
            entity.Property(e => e.PolicyHighLevelInfoEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyHighLevelInfoEligibilityStatus).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoEndDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyHighLevelInfoGroupName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoGroupNumber).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualCallRef).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualGroupName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualGroupNumber).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualNetworkStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHighLevelInfoManualPayerId).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualPayerName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualPayerType1).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualPlanName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualPlanType).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoManualPlanTypeDetail3).HasMaxLength(256);
            entity.Property(e => e.PolicyHighLevelInfoManualPlanTypeDetail4).HasMaxLength(256);
            entity.Property(e => e.PolicyHighLevelInfoManualPlanTypeDetail5).HasMaxLength(256);
            entity.Property(e => e.PolicyHighLevelInfoPayerId).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPayerName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPayerType).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPlanName).HasMaxLength(128);
            entity.Property(e => e.PolicyHighLevelInfoPlanType).HasMaxLength(128);
            entity.Property(e => e.PolicyMessageContent).HasColumnName("policyMessageContent");
            entity.Property(e => e.PolicyMessageId)
                .HasMaxLength(128)
                .HasColumnName("policyMessageId");
            entity.Property(e => e.PolicyOutcomeKey).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProductStatusDetailsCoInsApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsCode).HasMaxLength(100);
            entity.Property(e => e.ProductStatusDetailsCopayApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsPcpCopayAmount).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsSpecialistCopayAmount).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailscoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SrMedOffRampDataId).HasColumnName("SR_MedOffRampDataId");
            entity.Property(e => e.SrOffRampId).HasColumnName("SR_OffRampId");
            entity.Property(e => e.VerifiedWith)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.SrMedOffRampData).WithMany(p => p.SrMedOffRampDataPolicies)
                .HasForeignKey(d => d.SrMedOffRampDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_MEDOffRampDataPolicyNEW_SR_MEDOffRampData");

            entity.HasOne(d => d.SrOffRamp).WithMany(p => p.SrMedOffRampDataPolicies)
                .HasForeignKey(d => d.SrOffRampId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_MEDOffRampDataPolicyNEW_SR_OffRamp");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrMedOffRampDataPolicy> entity);
    }
}
