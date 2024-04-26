﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DispensesLogConfiguration : IEntityTypeConfiguration<DispensesLog>
    {
        public void Configure(EntityTypeBuilder<DispensesLog> entity)
        {
            entity.HasKey(e => e.DispenseLogId).HasName("PK_DispensesLog");

            entity.ToTable("Dispenses_Log");

            entity.Property(e => e.DispenseLogId).HasColumnName("DispenseLogID");
            entity.Property(e => e.BinNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CopayAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CopayCardAmountUsed).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CopayCardId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CopayCardID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DispendsesFromSpid).HasColumnName("Dispendses_fromSPID");
            entity.Property(e => e.DispenseId).HasColumnName("DispenseID");
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExternalPatientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalPatientID");
            entity.Property(e => e.FillNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastSynced).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MajorMedicalName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ndc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NDC");
            entity.Property(e => e.OrderTransactionNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientCopay).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.PatientDob).HasColumnName("PatientDOB");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientPayAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PayerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pbmname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBMName");
            entity.Property(e => e.Pcn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PCN");
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ProviderAddress1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderAddress2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderNpi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ProviderNPI");
            entity.Property(e => e.ProviderState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProviderZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ProviderZIP");
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RefillRemaining).HasColumnType("decimal(8, 0)");
            entity.Property(e => e.RxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScCfcenterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SC_CFCenterID");
            entity.Property(e => e.ScCfcenterName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SC_CFCenterName");
            entity.Property(e => e.ShipCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ShipTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipZipcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ShipZIPCode");
            entity.Property(e => e.ShippingCarrier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpCfcenterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SP_CFCenterID");
            entity.Property(e => e.SpProviderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SP_ProviderID");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.Spnpi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPNPI");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitOfMeasure)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DispensesLog> entity);
    }
}
