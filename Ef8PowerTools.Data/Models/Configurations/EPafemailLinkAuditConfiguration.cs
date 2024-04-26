﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EPafemailLinkAuditConfiguration : IEntityTypeConfiguration<EPafemailLinkAudit>
    {
        public void Configure(EntityTypeBuilder<EPafemailLinkAudit> entity)
        {
            entity.HasKey(e => e.EmailId);

            entity.ToTable("ePAFEmailLinkAudit");

            entity.Property(e => e.EmailId).HasColumnName("EMailID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.ExpiredAt).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsSubmitted).HasColumnName("isSubmitted");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Submitted).HasColumnType("datetime");
            entity.Property(e => e.SubmittedBy).HasMaxLength(100);
            entity.Property(e => e.Token)
                .IsRequired()
                .HasColumnType("xml");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EPafemailLinkAudit> entity);
    }
}