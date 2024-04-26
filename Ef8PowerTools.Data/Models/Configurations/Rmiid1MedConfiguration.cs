﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class Rmiid1MedConfiguration : IEntityTypeConfiguration<Rmiid1Med>
    {
        public void Configure(EntityTypeBuilder<Rmiid1Med> entity)
        {
            entity
                .HasNoKey()
                .ToTable("RMIID1_MED");

            entity.Property(e => e.GcnSeqno).HasColumnName("GCN_SEQNO");
            entity.Property(e => e.GenericMedid).HasColumnName("GENERIC_MEDID");
            entity.Property(e => e.MedGcnseqnoAssignCd)
                .HasMaxLength(1)
                .HasColumnName("MED_GCNSEQNO_ASSIGN_CD");
            entity.Property(e => e.MedMedidDesc)
                .HasMaxLength(70)
                .HasColumnName("MED_MEDID_DESC");
            entity.Property(e => e.MedNameSourceCd)
                .HasMaxLength(1)
                .HasColumnName("MED_NAME_SOURCE_CD");
            entity.Property(e => e.MedRefDeaCd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_DEA_CD");
            entity.Property(e => e.MedRefDesi2Ind)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_DESI2_IND");
            entity.Property(e => e.MedRefDesiInd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_DESI_IND");
            entity.Property(e => e.MedRefFedLegendInd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_FED_LEGEND_IND");
            entity.Property(e => e.MedRefGenCompPriceCd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_GEN_COMP_PRICE_CD");
            entity.Property(e => e.MedRefGenDrugNameCd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_GEN_DRUG_NAME_CD");
            entity.Property(e => e.MedRefGenSpreadCd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_GEN_SPREAD_CD");
            entity.Property(e => e.MedRefGenTheraEquCd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_GEN_THERA_EQU_CD");
            entity.Property(e => e.MedRefInnovInd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_INNOV_IND");
            entity.Property(e => e.MedRefMultiSourceCd)
                .HasMaxLength(1)
                .HasColumnName("MED_REF_MULTI_SOURCE_CD");
            entity.Property(e => e.MedStatusCd)
                .HasMaxLength(1)
                .HasColumnName("MED_STATUS_CD");
            entity.Property(e => e.MedStrength)
                .HasMaxLength(15)
                .HasColumnName("MED_STRENGTH");
            entity.Property(e => e.MedStrengthUom)
                .HasMaxLength(15)
                .HasColumnName("MED_STRENGTH_UOM");
            entity.Property(e => e.Medid).HasColumnName("MEDID");
            entity.Property(e => e.RoutedDosageFormMedId).HasColumnName("ROUTED_DOSAGE_FORM_MED_ID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Rmiid1Med> entity);
    }
}
