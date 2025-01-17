﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MdmpatientProcessResultConfiguration : IEntityTypeConfiguration<MdmpatientProcessResult>
    {
        public void Configure(EntityTypeBuilder<MdmpatientProcessResult> entity)
        {
            entity.HasKey(e => e.MdmpatientProcessResultId).HasName("PK_MDMPatientSearchResult_MDMPatientProcessResultId");

            entity.ToTable("MDMPatientProcessResult");

            entity.Property(e => e.MdmpatientProcessResultId).HasColumnName("MDMPatientProcessResultId");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.MatchedPatientId).HasColumnName("MatchedPatientID");

            entity.HasOne(d => d.PatientSearchResult).WithMany(p => p.MdmpatientProcessResults)
                .HasForeignKey(d => d.PatientSearchResultId)
                .HasConstraintName("fk_MDMPatientProcessResult_PatientSearchResultId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MdmpatientProcessResult> entity);
    }
}
