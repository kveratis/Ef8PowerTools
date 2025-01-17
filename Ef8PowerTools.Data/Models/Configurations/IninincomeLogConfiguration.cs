﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class IninincomeLogConfiguration : IEntityTypeConfiguration<IninincomeLog>
    {
        public void Configure(EntityTypeBuilder<IninincomeLog> entity)
        {
            entity.ToTable("ININIncomeLog");

            entity.Property(e => e.IninincomeLogId).HasColumnName("ININIncomeLogID");
            entity.Property(e => e.ConsentUserResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Data).IsUnicode(false);
            entity.Property(e => e.DeletedReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InteractionId)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.InteractionType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Processed).HasColumnType("datetime");
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.TakenAt).HasColumnType("datetime");
            entity.Property(e => e.TakenBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<IninincomeLog> entity);
    }
}
