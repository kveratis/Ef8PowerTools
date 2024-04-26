﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class WorkflowFieldConfiguration : IEntityTypeConfiguration<WorkflowField>
    {
        public void Configure(EntityTypeBuilder<WorkflowField> entity)
        {
            entity.HasKey(e => e.FieldId).HasName("Pk_Questions_QuestionID");

            entity.ToTable(tb => tb.HasComment("Workflow field configuration"));

            entity.Property(e => e.FieldId)
                .ValueGeneratedNever()
                .HasComment("The primary key")
                .HasColumnName("FieldID");
            entity.Property(e => e.DataType).HasComment("The field data type where the lookup name is DATA_TYPES");
            entity.Property(e => e.Interpretation).HasComment("The field interpretation where the lookup name is INTERPRETATION");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Active flag");
            entity.Property(e => e.MaxLength).HasComment("The maximum length");
            entity.Property(e => e.MinLength).HasComment("The minimum length");
            entity.Property(e => e.MinValue)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasComment("The field name");

            entity.HasOne(d => d.DataTypeNavigation).WithMany(p => p.WorkflowFieldDataTypeNavigations)
                .HasForeignKey(d => d.DataType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkflowFields_WorkflowLookupItems_DataTypes");

            entity.HasOne(d => d.InterpretationNavigation).WithMany(p => p.WorkflowFieldInterpretationNavigations).HasForeignKey(d => d.Interpretation);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkflowField> entity);
    }
}