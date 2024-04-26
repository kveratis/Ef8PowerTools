﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalStagingRegistrationEntityConfiguration : IEntityTypeConfiguration<PortalStagingRegistrationEntity>
    {
        public void Configure(EntityTypeBuilder<PortalStagingRegistrationEntity> entity)
        {
            entity.HasKey(e => e.RegistrationRecordEntityId).HasName("PK__Portal_S__A04536DD7AD2D914");

            entity.ToTable("Portal_Staging_Registration_Entity");

            entity.Property(e => e.RegistrationRecordEntityId).HasColumnName("RegistrationRecordEntityID");
            entity.Property(e => e.BestTimeToContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEA");
            entity.Property(e => e.Degree)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hin)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("HIN");
            entity.Property(e => e.HubPhysicianId).HasColumnName("HubPhysicianID");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LicensingState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_Extension");
            entity.Property(e => e.PreferredCommunicationMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Ptan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PTAN");
            entity.Property(e => e.RegistrationRecordId).HasColumnName("RegistrationRecordID");
            entity.Property(e => e.StagingStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateLicenseNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TaxID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RegistrationRecord).WithMany(p => p.PortalStagingRegistrationEntities)
                .HasForeignKey(d => d.RegistrationRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Portal_St__Regis__7CBB2186");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalStagingRegistrationEntity> entity);
    }
}