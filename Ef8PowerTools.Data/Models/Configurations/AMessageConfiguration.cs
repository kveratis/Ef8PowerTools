﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class AMessageConfiguration : IEntityTypeConfiguration<AMessage>
    {
        public void Configure(EntityTypeBuilder<AMessage> entity)
        {
            entity.HasKey(e => e.Pkid);

            entity.ToTable("A_Message");

            entity.Property(e => e.Pkid).HasColumnName("pkid");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Message_Text");
            entity.Property(e => e.Messageid).HasColumnName("messageid");
            entity.Property(e => e.Messageid2).HasColumnName("messageid2");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.SendTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SenderFirstName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SenderLastName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Source)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Src).HasColumnName("src");
            entity.Property(e => e.Threadid).HasColumnName("threadid");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AMessage> entity);
    }
}
