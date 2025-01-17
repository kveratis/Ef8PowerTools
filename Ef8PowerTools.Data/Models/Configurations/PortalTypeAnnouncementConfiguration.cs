﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalTypeAnnouncementConfiguration : IEntityTypeConfiguration<PortalTypeAnnouncement>
    {
        public void Configure(EntityTypeBuilder<PortalTypeAnnouncement> entity)
        {
            entity
                .HasNoKey()
                .ToTable("PortalTypeAnnouncement");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortalAnnouncementId).HasColumnName("PortalAnnouncementID");
            entity.Property(e => e.PortalTypeAnnouncementId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PortalTypeAnnouncementID");
            entity.Property(e => e.ProgramTypePortalId).HasColumnName("ProgramTypePortalID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalTypeAnnouncement> entity);
    }
}
