﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class TracleerRemsInPatientPharmacyConfiguration : IEntityTypeConfiguration<TracleerRemsInPatientPharmacy>
    {
        public void Configure(EntityTypeBuilder<TracleerRemsInPatientPharmacy> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Tracleer_REMS_InPatientPharmacy");

            entity.Property(e => e.InpatientPharmacyCertificationDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.InpatientPharmacyId).HasColumnName("InpatientPharmacyID");
            entity.Property(e => e.PharmacyHin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PharmacyHIN");
            entity.Property(e => e.PharmacyName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyNpi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PharmacyNPI");
            entity.Property(e => e.PharmacyOtherIdentifier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RepEmail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RepFax)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RepName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RepPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ShipToAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShipToCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipToFaxNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ShipToPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ShipToState)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShipToZip)
                .HasMaxLength(15)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TracleerRemsInPatientPharmacy> entity);
    }
}