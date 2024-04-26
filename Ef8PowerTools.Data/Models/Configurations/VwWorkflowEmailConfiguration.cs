﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwWorkflowEmailConfiguration : IEntityTypeConfiguration<VwWorkflowEmail>
    {
        public void Configure(EntityTypeBuilder<VwWorkflowEmail> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_WorkflowEmail");

            entity.Property(e => e.Bcclist)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BCCList");
            entity.Property(e => e.BodyText).HasColumnType("text");
            entity.Property(e => e.Cclist)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CCList");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailType)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LookupDisplay)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LookupId).HasColumnName("LookupID");
            entity.Property(e => e.LookupItemId).HasColumnName("LookupItemID");
            entity.Property(e => e.LookupItemTag).IsUnicode(false);
            entity.Property(e => e.LookupName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Paptype)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwWorkflowEmail> entity);
    }
}
