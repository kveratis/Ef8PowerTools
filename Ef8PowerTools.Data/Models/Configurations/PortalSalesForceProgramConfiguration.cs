﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalSalesForceProgramConfiguration : IEntityTypeConfiguration<PortalSalesForceProgram>
    {
        public void Configure(EntityTypeBuilder<PortalSalesForceProgram> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Portal_SalesForceProgram");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FunctionLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SalesForce)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalesForceProgramId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SalesForceProgramID");
            entity.Property(e => e.Therapy)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalSalesForceProgram> entity);
    }
}
