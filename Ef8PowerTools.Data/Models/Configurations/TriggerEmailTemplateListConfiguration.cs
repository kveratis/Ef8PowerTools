﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class TriggerEmailTemplateListConfiguration : IEntityTypeConfiguration<TriggerEmailTemplateList>
    {
        public void Configure(EntityTypeBuilder<TriggerEmailTemplateList> entity)
        {
            entity.HasKey(e => e.TriggerEmailTemplagteListId);

            entity.ToTable("Trigger_EmailTemplate_List");

            entity.Property(e => e.TriggerEmailTemplagteListId).HasColumnName("Trigger_EmailTemplagte_ListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailContent)
                .IsRequired()
                .IsUnicode(false);
            entity.Property(e => e.EmailFrom)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailSubject)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailTo)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.StoredProcName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TriggerName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TriggerEmailTemplateList> entity);
    }
}
