﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class FaqlistConfiguration : IEntityTypeConfiguration<Faqlist>
    {
        public void Configure(EntityTypeBuilder<Faqlist> entity)
        {
            entity.ToTable("FAQList");

            entity.Property(e => e.FaqListId).HasColumnName("FaqListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Answer)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Question)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SortOrder).HasDefaultValue(1.0);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Faqlist> entity);
    }
}
