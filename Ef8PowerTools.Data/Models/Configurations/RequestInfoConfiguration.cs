﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class RequestInfoConfiguration : IEntityTypeConfiguration<RequestInfo>
    {
        public void Configure(EntityTypeBuilder<RequestInfo> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RequestInfoes");

            entity.Property(e => e.DrugFullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DrugId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FormDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FormName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RequestId)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RequestInfo> entity);
    }
}
