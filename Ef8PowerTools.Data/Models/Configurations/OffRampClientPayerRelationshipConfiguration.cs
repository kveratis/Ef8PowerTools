﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class OffRampClientPayerRelationshipConfiguration : IEntityTypeConfiguration<OffRampClientPayerRelationship>
    {
        public void Configure(EntityTypeBuilder<OffRampClientPayerRelationship> entity)
        {
            entity.ToTable("OffRampClient_Payer_Relationship");

            entity.Property(e => e.OffRampClientPayerRelationshipId).HasColumnName("OffRampClient_Payer_Relationship_ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OffRampClientId).HasColumnName("OffRampClientID");
            entity.Property(e => e.PayerId).HasColumnName("PayerID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OffRampClientPayerRelationship> entity);
    }
}
