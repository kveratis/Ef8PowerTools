﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwBioMarinConsentedPatientsV3Configuration : IEntityTypeConfiguration<VwBioMarinConsentedPatientsV3>
    {
        public void Configure(EntityTypeBuilder<VwBioMarinConsentedPatientsV3> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_BioMarinConsentedPatients_V3");

            entity.Property(e => e.BioMarinAuthorizationPafexpDate).HasColumnName("BioMarinAuthorizationPAFExpDate");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwBioMarinConsentedPatientsV3> entity);
    }
}