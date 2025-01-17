﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ProgramNdcConfiguration : IEntityTypeConfiguration<ProgramNdc>
    {
        public void Configure(EntityTypeBuilder<ProgramNdc> entity)
        {
            entity.ToTable("ProgramNDCs");

            entity.Property(e => e.ProgramNdcid).HasColumnName("ProgramNDCID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.DefalultTestClaimQuantity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultUnitofMeasure)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ndc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NDC");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.TestClaimAllowed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProgramNdc> entity);
    }
}
