﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientXmldatumConfiguration : IEntityTypeConfiguration<PatientXmldatum>
    {
        public void Configure(EntityTypeBuilder<PatientXmldatum> entity)
        {
            entity.HasKey(e => e.PatientXmldataId);

            entity.ToTable("PatientXMLData");

            entity.Property(e => e.PatientXmldataId).HasColumnName("PatientXMLData_ID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataDescription)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Xmldata)
                .HasColumnType("xml")
                .HasColumnName("XMLData");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientXmldatum> entity);
    }
}
