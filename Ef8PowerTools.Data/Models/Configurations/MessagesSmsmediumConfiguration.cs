﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MessagesSmsmediumConfiguration : IEntityTypeConfiguration<MessagesSmsmedium>
    {
        public void Configure(EntityTypeBuilder<MessagesSmsmedium> entity)
        {
            entity.HasKey(e => e.MessagesSmsmediaId);

            entity.ToTable("MessagesSMSMedia");

            entity.Property(e => e.MessagesSmsmediaId).HasColumnName("MessagesSMSMediaID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentStorageId).HasColumnName("DocumentStorageID");
            entity.Property(e => e.DocumentStorageType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessagesSmsid).HasColumnName("MessagesSMSID");
            entity.Property(e => e.ParentSid)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Sid)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Uri)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MessagesSmsmedium> entity);
    }
}