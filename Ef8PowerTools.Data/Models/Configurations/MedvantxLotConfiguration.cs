﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MedvantxLotConfiguration : IEntityTypeConfiguration<MedvantxLot>
    {
        public void Configure(EntityTypeBuilder<MedvantxLot> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK__Medvantx__3214EC0705797FDD");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AcquisitionDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MedvantxInventoryUpdate).WithMany(p => p.MedvantxLots)
                .HasForeignKey(d => d.MedvantxInventoryUpdateId)
                .HasConstraintName("FK__MedvantxL__Medva__6C6EDFCD");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MedvantxLot> entity);
    }
}
