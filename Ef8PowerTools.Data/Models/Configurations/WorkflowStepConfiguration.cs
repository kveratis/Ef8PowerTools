﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class WorkflowStepConfiguration : IEntityTypeConfiguration<WorkflowStep>
    {
        public void Configure(EntityTypeBuilder<WorkflowStep> entity)
        {
            entity.HasKey(e => e.WorkflowStepId).HasName("Pk_Workflow_ProgramWorkflowID");

            entity.ToTable(tb => tb.HasComment("The workflow steps for a workflow"));

            entity.Property(e => e.WorkflowStepId)
                .ValueGeneratedNever()
                .HasComment("The primary key")
                .HasColumnName("WorkflowStepID");
            entity.Property(e => e.ButtonText)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeadingText)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.IconCss)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Active flag");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sequence).HasComment("The workflow step sequence for display");
            entity.Property(e => e.StepText)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.WorkflowId)
                .HasComment("The parent workflow for a program and product")
                .HasColumnName("WorkflowID");
            entity.Property(e => e.WorkflowStep1)
                .HasComment("The workflow step where the lookup name is WORKFLOW_STEPS")
                .HasColumnName("WorkflowStep");

            entity.HasOne(d => d.Workflow).WithMany(p => p.WorkflowSteps)
                .HasForeignKey(d => d.WorkflowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkflowSteps_Workflow");

            entity.HasOne(d => d.WorkflowStep1Navigation).WithMany(p => p.WorkflowStepWorkflowStep1Navigations)
                .HasForeignKey(d => d.WorkflowStep1)
                .HasConstraintName("FK_Workflow_LookupItems");

            entity.HasOne(d => d.WorkflowType).WithMany(p => p.WorkflowStepWorkflowTypes)
                .HasForeignKey(d => d.WorkflowTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkflowTypeId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkflowStep> entity);
    }
}