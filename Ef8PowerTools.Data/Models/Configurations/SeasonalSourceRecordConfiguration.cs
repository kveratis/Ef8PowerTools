﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SeasonalSourceRecordConfiguration : IEntityTypeConfiguration<SeasonalSourceRecord>
    {
        public void Configure(EntityTypeBuilder<SeasonalSourceRecord> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Seasonal_SourceRecord");

            entity.Property(e => e.ClientPatientId)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Mdeleted)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("MDeleted");
            entity.Property(e => e.MedeBvprocessingId).HasColumnName("MedeBVProcessingId");
            entity.Property(e => e.MedeBvprocessingTypeId).HasColumnName("MedeBVProcessingTypeId");
            entity.Property(e => e.MedeBvresponseId)
                .HasMaxLength(50)
                .HasColumnName("MedeBVResponseId");
            entity.Property(e => e.MedeBvresponseSourceTypeId)
                .HasMaxLength(50)
                .HasColumnName("MedeBVResponseSourceTypeId");
            entity.Property(e => e.MedeBvresponseTypeCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("MedeBVResponseTypeCode");
            entity.Property(e => e.Srcreated).HasColumnName("SRCreated");
            entity.Property(e => e.SrmedeBvprocessingId).HasColumnName("SRMedeBVProcessingId");
            entity.Property(e => e.SrmedeBvresponseTypeCode)
                .HasMaxLength(50)
                .HasColumnName("SRMedeBVResponseTypeCode");
            entity.Property(e => e.Srmodified).HasColumnName("SRModified");
            entity.Property(e => e.Srstatus)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("SRStatus");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SeasonalSourceRecord> entity);
    }
}