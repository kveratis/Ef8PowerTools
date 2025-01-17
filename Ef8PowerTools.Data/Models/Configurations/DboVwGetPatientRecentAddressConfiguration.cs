﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DboVwGetPatientRecentAddressConfiguration : IEntityTypeConfiguration<DboVwGetPatientRecentAddress>
    {
        public void Configure(EntityTypeBuilder<DboVwGetPatientRecentAddress> entity)
        {
            entity
                .HasNoKey()
                .ToView("dbo.vw_GetPatientRecentAddress");

            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DboVwGetPatientRecentAddress> entity);
    }
}
