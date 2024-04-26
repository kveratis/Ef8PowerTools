﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientEligibilityResponseCodeListConfiguration : IEntityTypeConfiguration<PatientEligibilityResponseCodeList>
    {
        public void Configure(EntityTypeBuilder<PatientEligibilityResponseCodeList> entity)
        {
            entity.ToTable("PatientEligibility_ResponseCodeList");

            entity.Property(e => e.PatientEligibilityResponseCodeListId).HasColumnName("PatientEligibility_ResponseCodeListID");
            entity.Property(e => e.ResponseCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseCodeDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResponseComments)
                .HasMaxLength(8000)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientEligibilityResponseCodeList> entity);
    }
}