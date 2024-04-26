﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalStagingRegistrationAddrEntityMappingConfiguration : IEntityTypeConfiguration<PortalStagingRegistrationAddrEntityMapping>
    {
        public void Configure(EntityTypeBuilder<PortalStagingRegistrationAddrEntityMapping> entity)
        {
            entity.HasKey(e => e.RegistrationRecordMappingId).HasName("PK__Portal_S__E4B76BF860DDFCE7");

            entity.ToTable("Portal_Staging_Registration_Addr_Entity_Mapping");

            entity.Property(e => e.RegistrationRecordMappingId).HasColumnName("RegistrationRecordMappingID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationRecordAddressId).HasColumnName("RegistrationRecordAddressID");
            entity.Property(e => e.RegistrationRecordEntityId).HasColumnName("RegistrationRecordEntityID");

            entity.HasOne(d => d.RegistrationRecordAddress).WithMany(p => p.PortalStagingRegistrationAddrEntityMappings)
                .HasForeignKey(d => d.RegistrationRecordAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Portal_St__Regis__5E01903C");

            entity.HasOne(d => d.RegistrationRecordEntity).WithMany(p => p.PortalStagingRegistrationAddrEntityMappings)
                .HasForeignKey(d => d.RegistrationRecordEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Portal_St__Regis__5EF5B475");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalStagingRegistrationAddrEntityMapping> entity);
    }
}