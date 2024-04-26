﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class TracleerRemsUniquePrescriberConfiguration : IEntityTypeConfiguration<TracleerRemsUniquePrescriber>
    {
        public void Configure(EntityTypeBuilder<TracleerRemsUniquePrescriber> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Tracleer_REMS_Unique_Prescribers");

            entity.Property(e => e.PrescriberId).HasColumnName("PrescriberID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TracleerRemsUniquePrescriber> entity);
    }
}