﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MessagesSmConfiguration : IEntityTypeConfiguration<MessagesSm>
    {
        public void Configure(EntityTypeBuilder<MessagesSm> entity)
        {
            entity.HasKey(e => e.MessagesSmsid);

            entity.ToTable("MessagesSMS");

            entity.Property(e => e.MessagesSmsid).HasColumnName("MessagesSMSID");
            entity.Property(e => e.AccountSid)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateSent).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageDirection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageSid)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MessageText)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MessageTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TakenAt).HasColumnType("datetime");
            entity.Property(e => e.TakenBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uri)
                .HasMaxLength(200)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MessagesSm> entity);
    }
}
