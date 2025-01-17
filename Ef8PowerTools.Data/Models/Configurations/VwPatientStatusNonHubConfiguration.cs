﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwPatientStatusNonHubConfiguration : IEntityTypeConfiguration<VwPatientStatusNonHub>
    {
        public void Configure(EntityTypeBuilder<VwPatientStatusNonHub> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_PatientStatusNonHub");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GlobalPatientId).HasColumnName("GlobalPatientID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientStatusListId).HasColumnName("PatientStatusListID");
            entity.Property(e => e.PatientStatusNonHubId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PatientStatusNonHubID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.SppatientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPPatientID");
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
            entity.Property(e => e.StatusType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TransactionID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwPatientStatusNonHub> entity);
    }
}
