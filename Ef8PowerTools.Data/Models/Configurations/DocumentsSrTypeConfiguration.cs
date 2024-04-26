﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DocumentsSrTypeConfiguration : IEntityTypeConfiguration<DocumentsSrType>
    {
        public void Configure(EntityTypeBuilder<DocumentsSrType> entity)
        {
            entity.HasKey(e => new { e.DocumentListId, e.SrType });

            entity.ToTable("Documents_SrTypes");

            entity.Property(e => e.DocumentListId).HasColumnName("DocumentListID");
            entity.Property(e => e.SrType)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.DocumentList).WithMany(p => p.DocumentsSrTypes)
                .HasForeignKey(d => d.DocumentListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documents_SrTypes_DocumentList");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DocumentsSrType> entity);
    }
}
