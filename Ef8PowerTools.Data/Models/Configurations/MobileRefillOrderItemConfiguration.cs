﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MobileRefillOrderItemConfiguration : IEntityTypeConfiguration<MobileRefillOrderItem>
    {
        public void Configure(EntityTypeBuilder<MobileRefillOrderItem> entity)
        {
            entity.Property(e => e.MobileRefillOrderItemId).HasColumnName("MobileRefillOrderItemID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileRefillOrderId).HasColumnName("MobileRefillOrderID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RxNumber)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RxProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RxProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MobileRefillOrder).WithMany(p => p.MobileRefillOrderItems)
                .HasForeignKey(d => d.MobileRefillOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MobileRefillOrderItems_MobileRefillOrders");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MobileRefillOrderItem> entity);
    }
}