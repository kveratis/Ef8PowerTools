﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class OrganizationDynamicDatumConfiguration : IEntityTypeConfiguration<OrganizationDynamicDatum>
    {
        public void Configure(EntityTypeBuilder<OrganizationDynamicDatum> entity)
        {
            entity.HasKey(e => e.OrganizationDynamicDataId);

            entity.Property(e => e.OrganizationDynamicDataId).HasColumnName("OrganizationDynamicDataID");
            entity.Property(e => e.Answer)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AnswerId).HasColumnName("AnswerID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DynamicDataListId).HasColumnName("DynamicDataListID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            entity.HasOne(d => d.DynamicDataList).WithMany(p => p.OrganizationDynamicData)
                .HasForeignKey(d => d.DynamicDataListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationDynamicData_DynamicDataList");

            entity.HasOne(d => d.Organization).WithMany(p => p.OrganizationDynamicData)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationDynamicData_Organizations");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrganizationDynamicDatum> entity);
    }
}
