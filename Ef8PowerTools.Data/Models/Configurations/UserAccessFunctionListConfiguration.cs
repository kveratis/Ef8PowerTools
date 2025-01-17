﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class UserAccessFunctionListConfiguration : IEntityTypeConfiguration<UserAccessFunctionList>
    {
        public void Configure(EntityTypeBuilder<UserAccessFunctionList> entity)
        {
            entity.HasKey(e => e.AccessFunctionId).HasName("PK_AccessFunctionList");

            entity.ToTable("UserAccessFunctionList");

            entity.Property(e => e.AccessFunctionId).HasColumnName("AccessFunctionID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FunctionName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Program).WithMany(p => p.UserAccessFunctionLists)
                .HasForeignKey(d => d.ProgramId)
                .HasConstraintName("FK_UserAccessFunctionList_Programs");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UserAccessFunctionList> entity);
    }
}
