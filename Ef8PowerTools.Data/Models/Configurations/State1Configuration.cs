﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class State1Configuration : IEntityTypeConfiguration<State1>
    {
        public void Configure(EntityTypeBuilder<State1> entity)
        {
            entity.HasKey(e => e.StateCode).HasName("PK__states__86729A0252D92AFC");

            entity.ToTable("states");

            entity.Property(e => e.StateCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("state_code");
            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("state");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<State1> entity);
    }
}
