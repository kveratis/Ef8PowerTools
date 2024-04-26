﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrMedOffRampDataPolicyCptCodesDetailConfiguration : IEntityTypeConfiguration<SrMedOffRampDataPolicyCptCodesDetail>
    {
        public void Configure(EntityTypeBuilder<SrMedOffRampDataPolicyCptCodesDetail> entity)
        {
            entity.HasKey(e => e.SrMedOffRampDataPolicyCptCodesDetailsId).HasName("Pk_SR_MedOffRampDataPolicyCptCodesDetails_SR_MedOffRampDataPolicyCptCodesDetailsId");

            entity.ToTable("SR_MedOffRampDataPolicyCptCodesDetails");

            entity.HasIndex(e => e.SrMedOffRampDataPolicyId, "IX_NCI_SEMedORDPCCD_DataPolicyId");

            entity.Property(e => e.SrMedOffRampDataPolicyCptCodesDetailsId).HasColumnName("SR_MedOffRampDataPolicyCptCodesDetailsId");
            entity.Property(e => e.CptCodeDetailsCoInsApplies).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailsCode).HasMaxLength(100);
            entity.Property(e => e.CptCodeDetailsCopayApplies).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailsDeductibleApplies).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailsOopMaxApplies).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailsPcpCopayAmount).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailsSpecialistCopayAmount).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailsStatus).HasMaxLength(128);
            entity.Property(e => e.CptCodeDetailscoInsuranceAmount).HasMaxLength(128);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SrMedOffRampDataPolicyId).HasColumnName("SR_MedOffRampDataPolicyId");

            entity.HasOne(d => d.SrMedOffRampDataPolicy).WithMany(p => p.SrMedOffRampDataPolicyCptCodesDetails)
                .HasForeignKey(d => d.SrMedOffRampDataPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_MedOffRampDataPolicyCptCodesDetails_SR_MedOffRampDataPolicy");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrMedOffRampDataPolicyCptCodesDetail> entity);
    }
}
