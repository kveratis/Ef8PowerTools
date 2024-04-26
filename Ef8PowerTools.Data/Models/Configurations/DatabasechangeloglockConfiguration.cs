﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DatabasechangeloglockConfiguration : IEntityTypeConfiguration<Databasechangeloglock>
    {
        public void Configure(EntityTypeBuilder<Databasechangeloglock> entity)
        {
            entity.ToTable("DATABASECHANGELOGLOCK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Lockedby)
                .HasMaxLength(255)
                .HasColumnName("LOCKEDBY");
            entity.Property(e => e.Lockgranted)
                .HasPrecision(3)
                .HasColumnName("LOCKGRANTED");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Databasechangeloglock> entity);
    }
}