﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class OrganizationAddressConfiguration : IEntityTypeConfiguration<OrganizationAddress>
    {
        public void Configure(EntityTypeBuilder<OrganizationAddress> entity)
        {
            entity.HasKey(e => e.OrganizationAddressId).HasName("PK_OrgnizationAddresses");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_OrganizationAddresses_Whitelist_Insert");
                    tb.HasTrigger("Tr_OrganizationAddresses_Whitelist_Update");
                    tb.HasTrigger("Tr_OrganizationAddresses_Whitelist_Validation_Insert");
                    tb.HasTrigger("Tr_OrganizationAddresses_Whitelist_Validation_Update");
                });

            entity.HasIndex(e => e.OrganizationId, "OrganizationID");

            entity.HasIndex(e => new { e.MdmprogramId, e.Deleted }, "ProgramIDDeleted");

            entity.Property(e => e.OrganizationAddressId).HasColumnName("OrganizationAddressID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddressName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddressType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax2Comments)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fax2Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaxComments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MdmprogramId).HasColumnName("MDMProgramID");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone1Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone1Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone2Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreferredMethodOfContact)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SiteOfService)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            entity.HasOne(d => d.Mdmprogram).WithMany(p => p.OrganizationAddresses)
                .HasForeignKey(d => d.MdmprogramId)
                .HasConstraintName("FK_OrganizationAddresses_Programs");

            entity.HasOne(d => d.Organization).WithMany(p => p.OrganizationAddresses)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrgnizationAddresses_Orgnizations");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrganizationAddress> entity);
    }
}
