﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LookupPaConfiguration : IEntityTypeConfiguration<LookupPa>
    {
        public void Configure(EntityTypeBuilder<LookupPa> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Lookup_PA");

            entity.Property(e => e.Appeal118).HasMaxLength(255);
            entity.Property(e => e.Appeal119).HasMaxLength(255);
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.Pa118)
                .HasMaxLength(255)
                .HasColumnName("PA118");
            entity.Property(e => e.Pa119)
                .HasMaxLength(255)
                .HasColumnName("PA119");
            entity.Property(e => e.Sort)
                .HasMaxLength(255)
                .HasColumnName("sort");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LookupPa> entity);
    }
}
