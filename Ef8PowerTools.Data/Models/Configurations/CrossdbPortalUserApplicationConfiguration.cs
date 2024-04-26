﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CrossdbPortalUserApplicationConfiguration : IEntityTypeConfiguration<CrossdbPortalUserApplication>
    {
        public void Configure(EntityTypeBuilder<CrossdbPortalUserApplication> entity)
        {
            entity
                .HasNoKey()
                .ToView("crossdb_PortalUserApplication");

            entity.Property(e => e.ApplicationName)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.CareMetxRecordId).HasColumnName("CareMetxRecordID");
            entity.Property(e => e.CareMetxRecordType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoweredApplicationName)
                .IsRequired()
                .HasMaxLength(256);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CrossdbPortalUserApplication> entity);
    }
}
