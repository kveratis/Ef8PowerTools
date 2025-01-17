﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class RiteAidHolidayConfiguration : IEntityTypeConfiguration<RiteAidHoliday>
    {
        public void Configure(EntityTypeBuilder<RiteAidHoliday> entity)
        {
            entity.Property(e => e.RiteAidHolidayId).HasColumnName("RiteAidHolidayID");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Holiday)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RiteAidHoliday> entity);
    }
}
