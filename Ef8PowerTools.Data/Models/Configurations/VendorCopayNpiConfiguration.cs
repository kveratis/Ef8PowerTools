﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VendorCopayNpiConfiguration : IEntityTypeConfiguration<VendorCopayNpi>
    {
        public void Configure(EntityTypeBuilder<VendorCopayNpi> entity)
        {
            entity.HasKey(e => e.VendorCopayNpiId).HasName("PK_Vendor_NPIs");

            entity.ToTable("Vendor_CopayNPIs");

            entity.Property(e => e.VendorCopayNpiId).HasColumnName("Vendor_CopayNPI_ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Npi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VendorCopayNpi> entity);
    }
}