﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrDateConfiguration : IEntityTypeConfiguration<SrDate>
    {
        public void Configure(EntityTypeBuilder<SrDate> entity)
        {
            entity.ToTable("SR_Dates");

            entity.HasIndex(e => new { e.ProgramId, e.Deleted, e.ServiceRequestId }, "IX_SR_Dates_ProgramID");

            entity.Property(e => e.SrDateId).HasColumnName("SR_DateID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateValue).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LookupDataListId).HasColumnName("LookupDataListID");
            entity.Property(e => e.Na)
                .HasDefaultValue(false)
                .HasColumnName("NA");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");

            entity.HasOne(d => d.LookupDataList).WithMany(p => p.SrDates)
                .HasForeignKey(d => d.LookupDataListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_Dates_LookupDataList");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.SrDates)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_Dates_ServiceRequests");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrDate> entity);
    }
}
