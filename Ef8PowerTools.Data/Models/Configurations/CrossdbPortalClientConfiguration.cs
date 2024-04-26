﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CrossdbPortalClientConfiguration : IEntityTypeConfiguration<CrossdbPortalClient>
    {
        public void Configure(EntityTypeBuilder<CrossdbPortalClient> entity)
        {
            entity
                .HasNoKey()
                .ToView("crossdb_PortalClient");

            entity.Property(e => e.Address1)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientLogo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CssoverrideFile)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CSSOverrideFile");
            entity.Property(e => e.DomainUrl)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DomainURL");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeaderLogo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortalClientId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PortalClientID");
            entity.Property(e => e.PortalTypeId).HasColumnName("PortalTypeID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CrossdbPortalClient> entity);
    }
}
