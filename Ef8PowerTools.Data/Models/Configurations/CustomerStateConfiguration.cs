﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CustomerStateConfiguration : IEntityTypeConfiguration<CustomerState>
    {
        public void Configure(EntityTypeBuilder<CustomerState> entity)
        {
            entity
                .HasNoKey()
                .ToTable("CustomerState");

            entity.Property(e => e.IdState).HasColumnName("idState");
            entity.Property(e => e.LabelState)
                .HasMaxLength(14)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CustomerState> entity);
    }
}
