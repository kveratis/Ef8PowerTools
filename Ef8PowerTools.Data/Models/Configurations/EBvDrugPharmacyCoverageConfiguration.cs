﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EBvDrugPharmacyCoverageConfiguration : IEntityTypeConfiguration<EBvDrugPharmacyCoverage>
    {
        public void Configure(EntityTypeBuilder<EBvDrugPharmacyCoverage> entity)
        {
            entity.ToTable("eBvDrugPharmacyCoverage");

            entity.Property(e => e.EBvDrugPharmacyCoverageId).HasColumnName("eBvDrugPharmacyCoverageID");
            entity.Property(e => e.CoveragePhaseMessage)
                .HasMaxLength(210)
                .IsUnicode(false);
            entity.Property(e => e.DaysSupplyPriced)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DeductibleAppliedAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeductibleRemainingAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugFormularyStatusCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DrugStatusCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EBvMedicationBenefitDetailsId).HasColumnName("eBvMedicationBenefitDetailsID");
            entity.Property(e => e.IsRequestedPharmacy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OopAppliedAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OopRemainingAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientPayAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyAddress1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyAddress2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyCity)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyFaxNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyNcpdpid)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("PharmacyNCPDPID");
            entity.Property(e => e.PharmacyNpi)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("PharmacyNPI");
            entity.Property(e => e.PharmacyPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyState)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyTypes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyZip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PlanPayAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriorAuthorization)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PriorAuthorizationSpecified)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Quantity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.QuantityUom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("QuantityUOM");
            entity.Property(e => e.TotalCost)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalSavings)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EBvMedicationBenefitDetails).WithMany(p => p.EBvDrugPharmacyCoverages)
                .HasForeignKey(d => d.EBvMedicationBenefitDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_eBvDrugPharmacyCoverage_eBvMedicationBenefitDetails");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EBvDrugPharmacyCoverage> entity);
    }
}
