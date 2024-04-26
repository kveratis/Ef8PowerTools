﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EServiceApilogConfiguration : IEntityTypeConfiguration<EServiceApilog>
    {
        public void Configure(EntityTypeBuilder<EServiceApilog> entity)
        {
            entity.ToTable("eServiceAPILog");

            entity.Property(e => e.EServiceApilogId).HasColumnName("eServiceAPILog_ID");
            entity.Property(e => e.Apiname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APIName");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RequestJson)
                .IsUnicode(false)
                .HasColumnName("RequestJSON");
            entity.Property(e => e.ResponseJson)
                .IsUnicode(false)
                .HasColumnName("ResponseJSON");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EServiceApilog> entity);
    }
}