﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SurveyMasterConfiguration : IEntityTypeConfiguration<SurveyMaster>
    {
        public void Configure(EntityTypeBuilder<SurveyMaster> entity)
        {
            entity.ToTable("SurveyMaster");

            entity.Property(e => e.SurveyMasterId)
                .ValueGeneratedNever()
                .HasColumnName("SurveyMasterID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HasNurseLink).HasDefaultValue(false);
            entity.Property(e => e.HasProviderLink).HasDefaultValue(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ReadOnly).HasDefaultValue(false);
            entity.Property(e => e.SurveyDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SurveyType)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SurveyMaster> entity);
    }
}
