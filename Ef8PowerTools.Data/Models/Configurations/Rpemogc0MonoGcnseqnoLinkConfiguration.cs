﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class Rpemogc0MonoGcnseqnoLinkConfiguration : IEntityTypeConfiguration<Rpemogc0MonoGcnseqnoLink>
    {
        public void Configure(EntityTypeBuilder<Rpemogc0MonoGcnseqnoLink> entity)
        {
            entity
                .HasNoKey()
                .ToTable("RPEMOGC0_MONO_GCNSEQNO_LINK");

            entity.Property(e => e.GcnSeqno).HasColumnName("GCN_SEQNO");
            entity.Property(e => e.Pemono).HasColumnName("PEMONO");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Rpemogc0MonoGcnseqnoLink> entity);
    }
}
