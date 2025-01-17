﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MedeBvofframpResponseTypeCodeListConfiguration : IEntityTypeConfiguration<MedeBvofframpResponseTypeCodeList>
    {
        public void Configure(EntityTypeBuilder<MedeBvofframpResponseTypeCodeList> entity)
        {
            entity.ToTable("MedeBVOfframpResponseTypeCodeList");

            entity.Property(e => e.MedeBvofframpResponseTypeCodeListId).HasColumnName("MedeBVOfframpResponseTypeCodeListID");
            entity.Property(e => e.ActivatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActivatedDate).HasColumnType("datetime");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseTypeDescription)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MedeBvofframpResponseTypeCodeList> entity);
    }
}
