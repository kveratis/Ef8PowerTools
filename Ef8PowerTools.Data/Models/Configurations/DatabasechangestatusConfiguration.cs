﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DatabasechangestatusConfiguration : IEntityTypeConfiguration<Databasechangestatus>
    {
        public void Configure(EntityTypeBuilder<Databasechangestatus> entity)
        {
            entity.HasKey(e => e.Pkid);

            entity.ToTable("DATABASECHANGESTATUS");

            entity.HasIndex(e => e.Id, "Idx_DATABASECHANGESTATUS_ID");

            entity.HasIndex(e => e.Status, "Idx_DATABASECHANGESTATUS_Status");

            entity.Property(e => e.Pkid).HasColumnName("pkid");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Databasechangestatus> entity);
    }
}