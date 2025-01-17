﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity
                .HasNoKey()
                .ToTable("customer");

            entity.Property(e => e.Customername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customername");
            entity.Property(e => e.Idcustomer).HasColumnName("idcustomer");
            entity.Property(e => e.Idusstate).HasColumnName("idusstate");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Customer> entity);
    }
}
