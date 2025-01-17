﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PayerInjectionDateConfigInfinituConfiguration : IEntityTypeConfiguration<PayerInjectionDateConfigInfinitu>
    {
        public void Configure(EntityTypeBuilder<PayerInjectionDateConfigInfinitu> entity)
        {
            entity
                .HasNoKey()
                .ToTable("PayerInjectionDateConfig_Infinitus");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ConfigID");
            entity.Property(e => e.DbrowLimiter).HasColumnName("DBRowLimiter");
            entity.Property(e => e.HeaderValue)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.PayerName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PayerInjectionDateConfigInfinitu> entity);
    }
}
