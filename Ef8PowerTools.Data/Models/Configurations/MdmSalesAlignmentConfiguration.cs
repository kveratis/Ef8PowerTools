﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MdmSalesAlignmentConfiguration : IEntityTypeConfiguration<MdmSalesAlignment>
    {
        public void Configure(EntityTypeBuilder<MdmSalesAlignment> entity)
        {
            entity
                .HasNoKey()
                .ToTable("MDM_SalesAlignment");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("DFProduct");
            entity.Property(e => e.ProgramId)
                .HasDefaultValue(112)
                .HasColumnName("ProgramID");
            entity.Property(e => e.SaleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SALE_ID");
            entity.Property(e => e.TerrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TERR_ID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MdmSalesAlignment> entity);
    }
}
