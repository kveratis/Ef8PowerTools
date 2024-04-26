﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class WorkflowProgramEmailConfiguration : IEntityTypeConfiguration<WorkflowProgramEmail>
    {
        public void Configure(EntityTypeBuilder<WorkflowProgramEmail> entity)
        {
            entity.ToTable("WorkflowProgramEmail");

            entity.Property(e => e.WorkflowProgramEmailId).ValueGeneratedNever();
            entity.Property(e => e.Bcclist)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BCCList");
            entity.Property(e => e.BodyText).HasColumnType("text");
            entity.Property(e => e.Cclist)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CCList");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkflowProgramEmail> entity);
    }
}
