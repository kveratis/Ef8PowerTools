﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrFaxTransactionConfiguration : IEntityTypeConfiguration<LtrFaxTransaction>
    {
        public void Configure(EntityTypeBuilder<LtrFaxTransaction> entity)
        {
            entity.HasKey(e => e.FaxTransactionId);

            entity.ToTable("LTR_FaxTransaction");

            entity.Property(e => e.FaxTransactionId).HasColumnName("FaxTransactionID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EventTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasColumnName("ExternalID");
            entity.Property(e => e.ExternalMessage).IsUnicode(false);
            entity.Property(e => e.FaxNotificationId).HasColumnName("FaxNotificationID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            entity.HasOne(d => d.FaxNotification).WithMany(p => p.LtrFaxTransactions).HasForeignKey(d => d.FaxNotificationId);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrFaxTransaction> entity);
    }
}
