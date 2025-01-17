﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class NurseAgencyAccreditationConfiguration : IEntityTypeConfiguration<NurseAgencyAccreditation>
    {
        public void Configure(EntityTypeBuilder<NurseAgencyAccreditation> entity)
        {
            entity.Property(e => e.NurseAgencyAccreditationId)
                .ValueGeneratedNever()
                .HasColumnName("NurseAgencyAccreditationID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NaAccreditationListId).HasColumnName("NA_AccreditationListID");
            entity.Property(e => e.NurseAgencyId).HasColumnName("NurseAgencyID");

            entity.HasOne(d => d.NaAccreditationList).WithMany(p => p.NurseAgencyAccreditations)
                .HasForeignKey(d => d.NaAccreditationListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseAgencyAccreditations_NurseAgencyAccreditationList");

            entity.HasOne(d => d.NurseAgency).WithMany(p => p.NurseAgencyAccreditations)
                .HasForeignKey(d => d.NurseAgencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseAgencyAccreditations_NurseAgencies");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<NurseAgencyAccreditation> entity);
    }
}
