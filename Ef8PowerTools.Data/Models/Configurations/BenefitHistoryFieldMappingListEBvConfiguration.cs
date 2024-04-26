﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class BenefitHistoryFieldMappingListEBvConfiguration : IEntityTypeConfiguration<BenefitHistoryFieldMappingListEBv>
    {
        public void Configure(EntityTypeBuilder<BenefitHistoryFieldMappingListEBv> entity)
        {
            entity.ToTable("BenefitHistoryFieldMappingList_eBV");

            entity.Property(e => e.BenefitHistoryFieldMappingListEBvId).HasColumnName("BenefitHistoryFieldMappingList_eBV_ID");
            entity.Property(e => e.BifieldName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BIFieldName");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EBvFieldName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eBvFieldName");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BenefitHistoryFieldMappingListEBv> entity);
    }
}