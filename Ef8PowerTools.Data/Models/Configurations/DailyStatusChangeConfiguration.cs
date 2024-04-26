﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DailyStatusChangeConfiguration : IEntityTypeConfiguration<DailyStatusChange>
    {
        public void Configure(EntityTypeBuilder<DailyStatusChange> entity)
        {
            entity.Property(e => e.DailyStatusChangeId).HasColumnName("DailyStatusChangeID");
            entity.Property(e => e.Acnumber)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACNumber");
            entity.Property(e => e.CertificationNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fnrptype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FNRPType");
            entity.Property(e => e.FrpcategoryChange)
                .HasMaxLength(20)
                .HasColumnName("FRPCategoryChange");
            entity.Property(e => e.PatientDob).HasColumnName("PatientDOB");
            entity.Property(e => e.PatientFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientMiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PersonContacted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberAddressLine1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberAddressLine2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrescriberCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberMiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberNpi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PrescriberNPI");
            entity.Property(e => e.PrescriberState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberZip)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("PrescriberZIP");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Spname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPName");
            entity.Property(e => e.SppatientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPPatientID");
            entity.Property(e => e.TitleofPersonContacted)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DailyStatusChange> entity);
    }
}