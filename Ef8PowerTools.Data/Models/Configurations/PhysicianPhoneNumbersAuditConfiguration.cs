﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PhysicianPhoneNumbersAuditConfiguration : IEntityTypeConfiguration<PhysicianPhoneNumbersAudit>
    {
        public void Configure(EntityTypeBuilder<PhysicianPhoneNumbersAudit> entity)
        {
            entity
                .HasNoKey()
                .ToTable("PhysicianPhoneNumbers_Audit");

            entity.Property(e => e.Action).HasMaxLength(25);
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ActionUser).HasMaxLength(50);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneComments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.PhysicianPhoneNumberId).HasColumnName("PhysicianPhoneNumberID");
            entity.Property(e => e.PhysicianPhoneNumbersAuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PhysicianPhoneNumbers_Audit_ID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PhysicianPhoneNumbersAudit> entity);
    }
}
