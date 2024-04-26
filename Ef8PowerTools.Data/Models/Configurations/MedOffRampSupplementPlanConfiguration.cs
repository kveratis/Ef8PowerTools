﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MedOffRampSupplementPlanConfiguration : IEntityTypeConfiguration<MedOffRampSupplementPlan>
    {
        public void Configure(EntityTypeBuilder<MedOffRampSupplementPlan> entity)
        {
            entity
                .HasNoKey()
                .ToTable("MedOffRampSupplementPlan");

            entity.Property(e => e.AccumulatorDetailsDeductibleIndividualAmount).HasMaxLength(128);
            entity.Property(e => e.AccumulatorDetailsOopMaxIndividualAmount).HasMaxLength(128);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CobSummaryAdminAmount).HasMaxLength(128);
            entity.Property(e => e.CobSummaryDeductibleRemaining).HasMaxLength(128);
            entity.Property(e => e.CobSummaryOfficeVisitAmount).HasMaxLength(128);
            entity.Property(e => e.CobSummaryProductAmount).HasMaxLength(128);
            entity.Property(e => e.CobSummarycoordinatedPlanBenefits).HasMaxLength(300);
            entity.Property(e => e.CptstatusDetailsCopayCoInsurance)
                .HasMaxLength(128)
                .HasColumnName("CPTStatusDetailsCopayCoInsurance");
            entity.Property(e => e.CptstatusDetailsCopayCoInsuranceAmount)
                .HasMaxLength(128)
                .HasColumnName("CPTStatusDetailsCopayCoInsuranceAmount");
            entity.Property(e => e.CptstatusDetailsDeductibleApplies)
                .HasMaxLength(128)
                .HasColumnName("CPTStatusDetailsDeductibleApplies");
            entity.Property(e => e.CptstatusDetailsOopMaxApplies)
                .HasMaxLength(128)
                .HasColumnName("CPTStatusDetailsOopMaxApplies");
            entity.Property(e => e.CptstatusDetailsStatus)
                .HasMaxLength(128)
                .HasColumnName("CPTStatusDetailsStatus");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugRequirementsBuyBillPermitted).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyAvailable).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementsSpecialtyPharmacyRequired).HasMaxLength(128);
            entity.Property(e => e.DrugRequirementspriorAuthorizationRequired).HasMaxLength(128);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfficeVisitDetailsCopayCoInsurance).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsCopayCoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.OfficeVisitDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsCopayCoInsurance).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsCopayCoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.ProductStatusDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SupplementDescription).HasMaxLength(128);
            entity.Property(e => e.SupplementLetter).HasMaxLength(128);
            entity.Property(e => e.SupplementPlanId).ValueGeneratedOnAdd();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MedOffRampSupplementPlan> entity);
    }
}