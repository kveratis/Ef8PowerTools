﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MessageQueueConfiguration : IEntityTypeConfiguration<MessageQueue>
    {
        public void Configure(EntityTypeBuilder<MessageQueue> entity)
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("Message_Queue");

            entity.HasIndex(e => new { e.ProgramId, e.Source, e.Status, e.Deleted }, "ProgramID_Source_Status_Deleted");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DestinationApplication)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockedBy)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.MessageSubject)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Message_Subject");
            entity.Property(e => e.MessageText)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("Message_Text");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Reviewed)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SendTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SenderFirstName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sender_First_Name");
            entity.Property(e => e.SenderLastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sender_Last_Name");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Source)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MessageQueue> entity);
    }
}