﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class NoteTemplateListConfiguration : IEntityTypeConfiguration<NoteTemplateList>
    {
        public void Configure(EntityTypeBuilder<NoteTemplateList> entity)
        {
            entity.ToTable("Note_TemplateList");

            entity.Property(e => e.NoteTemplateListId).HasColumnName("Note_TemplateList_ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.SrTypeShortDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SR_TypeShortDesc");
            entity.Property(e => e.TemplateSubject)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TemplateText).IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<NoteTemplateList> entity);
    }
}
