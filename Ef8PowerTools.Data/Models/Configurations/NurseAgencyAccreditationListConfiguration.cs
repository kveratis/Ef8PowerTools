﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class NurseAgencyAccreditationListConfiguration : IEntityTypeConfiguration<NurseAgencyAccreditationList>
    {
        public void Configure(EntityTypeBuilder<NurseAgencyAccreditationList> entity)
        {
            entity.HasKey(e => e.NaAccreditationListId);

            entity.ToTable("NurseAgencyAccreditationList");

            entity.Property(e => e.NaAccreditationListId).HasColumnName("NA_AccreditationListID");
            entity.Property(e => e.Accreditation)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreateBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<NurseAgencyAccreditationList> entity);
    }
}