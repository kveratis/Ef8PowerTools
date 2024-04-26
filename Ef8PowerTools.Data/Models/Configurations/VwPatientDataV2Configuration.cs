﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwPatientDataV2Configuration : IEntityTypeConfiguration<VwPatientDataV2>
    {
        public void Configure(EntityTypeBuilder<VwPatientDataV2> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_PatientData_v2");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AptSuite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CellPhone)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.HomePhone)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Paptype)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAPType");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PreferredLanguage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreferredPhone)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.PreferredPhoneType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreferredTime)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RelationshipToPatient)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwPatientDataV2> entity);
    }
}
