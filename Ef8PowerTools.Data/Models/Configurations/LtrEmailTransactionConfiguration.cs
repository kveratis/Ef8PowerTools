﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrEmailTransactionConfiguration : IEntityTypeConfiguration<LtrEmailTransaction>
    {
        public void Configure(EntityTypeBuilder<LtrEmailTransaction> entity)
        {
            entity.HasKey(e => e.EmailTransactionId);

            entity.ToTable("LTR_EmailTransaction");

            entity.Property(e => e.EmailTransactionId).HasColumnName("EmailTransactionID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailEvent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailNotificationId).HasColumnName("EmailNotificationID");
            entity.Property(e => e.EventTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasColumnName("ExternalID");
            entity.Property(e => e.ExternalMessage).IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            entity.HasOne(d => d.EmailNotification).WithMany(p => p.LtrEmailTransactions)
                .HasForeignKey(d => d.EmailNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrEmailTransaction> entity);
    }
}
