﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwBioMarinSrlistExcludeNonConsentedV3Configuration : IEntityTypeConfiguration<VwBioMarinSrlistExcludeNonConsentedV3>
    {
        public void Configure(EntityTypeBuilder<VwBioMarinSrlistExcludeNonConsentedV3> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_BioMarinSRListExcludeNonConsented_V3");

            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Lastupdated)
                .HasColumnType("datetime")
                .HasColumnName("lastupdated");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwBioMarinSrlistExcludeNonConsentedV3> entity);
    }
}
