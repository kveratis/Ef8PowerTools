﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrSubTypeConfiguration : IEntityTypeConfiguration<SrSubType>
    {
        public void Configure(EntityTypeBuilder<SrSubType> entity)
        {
            entity.ToTable("SR_SubTypes");

            entity.HasIndex(e => new { e.ProgramId, e.Deleted, e.SrSubTypeListId, e.ServiceRequestId }, "IX_SR_SubTypes_ProgramID_Deleted");

            entity.Property(e => e.SrSubTypeId).HasColumnName("SR_SubTypeID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.SrSubTypeListId).HasColumnName("SR_SubTypeListID");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.SrSubTypes)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_SubTypes_ServiceRequests");

            entity.HasOne(d => d.SrSubTypeList).WithMany(p => p.SrSubTypes)
                .HasForeignKey(d => d.SrSubTypeListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_SubTypes_SR_SubTypeList");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrSubType> entity);
    }
}