﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class WorkflowPaptypeConfigConfiguration : IEntityTypeConfiguration<WorkflowPaptypeConfig>
    {
        public void Configure(EntityTypeBuilder<WorkflowPaptypeConfig> entity)
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowPAPTypeConfig");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultPaptypeItemId).HasColumnName("DefaultPAPTypeItemID");
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.PaptypeItemId).HasColumnName("PAPTypeItemID");
            entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");
            entity.Property(e => e.WorkflowPaptypeConfigId).HasColumnName("WorkflowPAPTypeConfigID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkflowPaptypeConfig> entity);
    }
}
