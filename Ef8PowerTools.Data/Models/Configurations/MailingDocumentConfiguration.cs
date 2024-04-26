﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MailingDocumentConfiguration : IEntityTypeConfiguration<MailingDocument>
    {
        public void Configure(EntityTypeBuilder<MailingDocument> entity)
        {
            entity.HasKey(e => e.MailingDocumentId).HasName("PK_SH_ShipmentDocuments");

            entity.Property(e => e.MailingDocumentId).HasColumnName("MailingDocumentID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CreatedDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LastUpdatedDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MailingId).HasColumnName("MailingID");

            entity.HasOne(d => d.Document).WithMany(p => p.MailingDocuments)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SH_ShipmentDocuments_Documents");

            entity.HasOne(d => d.Mailing).WithMany(p => p.MailingDocuments)
                .HasForeignKey(d => d.MailingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SH_ShipmentDocuments_SH_Shipments");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MailingDocument> entity);
    }
}