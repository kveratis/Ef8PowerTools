﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwGetPatientRecentPhoneConfiguration : IEntityTypeConfiguration<VwGetPatientRecentPhone>
    {
        public void Configure(EntityTypeBuilder<VwGetPatientRecentPhone> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_GetPatientRecentPhone");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Home)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwGetPatientRecentPhone> entity);
    }
}