﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientFulfillmentConfiguration : IEntityTypeConfiguration<PatientFulfillment>
    {
        public void Configure(EntityTypeBuilder<PatientFulfillment> entity)
        {
            entity.HasKey(e => e.Id).HasName("Patient_Fulfillment_ID");

            entity.ToTable("Patient_Fulfillment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CampaignCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CellCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentGroupNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ExtractDate).HasColumnType("datetime");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Field6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Field7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FulfillmentId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FulfillmentID");
            entity.Property(e => e.IndividualId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IndividualID");
            entity.Property(e => e.KitCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Kit_Code");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NamePrefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ResponseSourceCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TreatmentCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientFulfillment> entity);
    }
}