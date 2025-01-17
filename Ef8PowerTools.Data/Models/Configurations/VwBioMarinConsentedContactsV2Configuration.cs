﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VwBioMarinConsentedContactsV2Configuration : IEntityTypeConfiguration<VwBioMarinConsentedContactsV2>
    {
        public void Configure(EntityTypeBuilder<VwBioMarinConsentedContactsV2> entity)
        {
            entity
                .HasNoKey()
                .ToView("vw_BioMarinConsentedContacts_V2");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwBioMarinConsentedContactsV2> entity);
    }
}
