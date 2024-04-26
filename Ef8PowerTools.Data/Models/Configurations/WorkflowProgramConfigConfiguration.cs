﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class WorkflowProgramConfigConfiguration : IEntityTypeConfiguration<WorkflowProgramConfig>
    {
        public void Configure(EntityTypeBuilder<WorkflowProgramConfig> entity)
        {
            entity.HasKey(e => e.WorkflowProgramConfigId).HasName("Pk_WorkflowProgramConfiguration_WorkflowProgramConfigurationID");

            entity.ToTable("WorkflowProgramConfig", tb => tb.HasComment("Program configuration"));

            entity.Property(e => e.WorkflowProgramConfigId)
                .ValueGeneratedNever()
                .HasComment("The primary key")
                .HasColumnName("WorkflowProgramConfigID");
            entity.Property(e => e.AttestationType)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ConectDrugName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ConsentSource)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasComment("The created timestamp")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Csstext)
                .HasComment("The css to be used for custom css")
                .HasColumnName("CSSText");
            entity.Property(e => e.Domain)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasComment("The domain for a vanity url");
            entity.Property(e => e.InvitationExpirationHours).HasComment("The number of hours for which an invitation must expire");
            entity.Property(e => e.InvitationExpirationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Active flag");
            entity.Property(e => e.LastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogoManufacturer).HasComment("The manufacturer lo");
            entity.Property(e => e.LogoProgram).HasComment("The program / franchise or drug lo");
            entity.Property(e => e.Subdomain)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasComment("The subdomain for a vanity url");
            entity.Property(e => e.SupportEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updated)
                .HasComment("The updated timestamp")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkflowId)
                .HasComment("The parent workflow for a program and product")
                .HasColumnName("WorkflowID");

            entity.HasOne(d => d.Workflow).WithMany(p => p.WorkflowProgramConfigs)
                .HasForeignKey(d => d.WorkflowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkflowProgramConfig_Workflow");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkflowProgramConfig> entity);
    }
}