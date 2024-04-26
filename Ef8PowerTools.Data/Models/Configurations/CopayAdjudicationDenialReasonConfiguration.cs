﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CopayAdjudicationDenialReasonConfiguration : IEntityTypeConfiguration<CopayAdjudicationDenialReason>
    {
        public void Configure(EntityTypeBuilder<CopayAdjudicationDenialReason> entity)
        {
            entity.ToTable("Copay_Adjudication_DenialReasons");

            entity.Property(e => e.CopayAdjudicationDenialReasonId).HasColumnName("Copay_Adjudication_DenialReason_ID");
            entity.Property(e => e.CopayAdjudicationId).HasColumnName("Copay_Adjudication_ID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LookupDataListId).HasColumnName("LookupDataListID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CopayAdjudicationDenialReason> entity);
    }
}