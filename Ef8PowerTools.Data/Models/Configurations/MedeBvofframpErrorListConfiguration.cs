﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class MedeBvofframpErrorListConfiguration : IEntityTypeConfiguration<MedeBvofframpErrorList>
    {
        public void Configure(EntityTypeBuilder<MedeBvofframpErrorList> entity)
        {
            entity.ToTable("MedeBVOfframpErrorList");

            entity.Property(e => e.MedeBvofframpErrorListId).HasColumnName("MedeBVOfframpErrorListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ConnectOfframpMessage)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisplayMessage)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MedeBvcircumstance)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MedeBVCircumstance");
            entity.Property(e => e.MedeBvpolicyMessageContent)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MedeBVPolicyMessageContent");
            entity.Property(e => e.MedeBvpolicyMessageId).HasColumnName("MedeBVPolicyMessageID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MedeBvofframpErrorList> entity);
    }
}
