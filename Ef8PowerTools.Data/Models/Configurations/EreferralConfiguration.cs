﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EreferralConfiguration : IEntityTypeConfiguration<Ereferral>
    {
        public void Configure(EntityTypeBuilder<Ereferral> entity)
        {
            entity.ToTable("EReferrals");

            entity.Property(e => e.EreferralId).HasColumnName("EReferralID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.ProviderName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RxProduct)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Ereferral> entity);
    }
}
