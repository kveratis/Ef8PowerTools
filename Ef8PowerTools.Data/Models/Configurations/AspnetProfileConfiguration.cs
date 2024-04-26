﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class AspnetProfileConfiguration : IEntityTypeConfiguration<AspnetProfile>
    {
        public void Configure(EntityTypeBuilder<AspnetProfile> entity)
        {
            entity.HasKey(e => e.UserId).HasName("PK__aspnet_P__1788CC4C253C7D7E");

            entity.ToTable("aspnet_Profile");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PropertyNames)
                .IsRequired()
                .HasColumnType("ntext");
            entity.Property(e => e.PropertyValuesBinary)
                .IsRequired()
                .HasColumnType("image");
            entity.Property(e => e.PropertyValuesString)
                .IsRequired()
                .HasColumnType("ntext");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetProfile)
                .HasForeignKey<AspnetProfile>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pr__UserI__2724C5F0");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AspnetProfile> entity);
    }
}
