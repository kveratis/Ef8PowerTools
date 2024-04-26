﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwAspnetWebPartStatePathConfiguration : IEntityTypeConfiguration<VwAspnetWebPartStatePath>
    {
        public void Configure(EntityTypeBuilder<VwAspnetWebPartStatePath> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Paths");

            entity.Property(e => e.LoweredPath)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.Path)
                .IsRequired()
                .HasMaxLength(256);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwAspnetWebPartStatePath> entity);
    }
}
