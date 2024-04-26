﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CrossdbPortalAccountConfiguration : IEntityTypeConfiguration<CrossdbPortalAccount>
    {
        public void Configure(EntityTypeBuilder<CrossdbPortalAccount> entity)
        {
            entity
                .HasNoKey()
                .ToView("crossdb_PortalAccounts");

            entity.Property(e => e.ApplicationName)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.CareMetxRecordId).HasColumnName("CareMetxRecordID");
            entity.Property(e => e.CareMetxRecordType)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CrossdbPortalAccount> entity);
    }
}