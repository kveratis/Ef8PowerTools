﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrMedOffRampDataRequestPoliciesTmpConfiguration : IEntityTypeConfiguration<SrMedOffRampDataRequestPoliciesTmp>
    {
        public void Configure(EntityTypeBuilder<SrMedOffRampDataRequestPoliciesTmp> entity)
        {
            entity
                .HasNoKey()
                .ToTable("SR_MedOffRampDataRequestPoliciesTmp");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.MemberId).HasMaxLength(128);
            entity.Property(e => e.PatientIsSubscriber).HasMaxLength(128);
            entity.Property(e => e.PayerId).HasMaxLength(128);
            entity.Property(e => e.PayerName).HasMaxLength(128);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriorAuthorizationEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PriorAuthorizationEndDate).HasColumnType("datetime");
            entity.Property(e => e.PriorAuthorizationNumber).HasMaxLength(128);
            entity.Property(e => e.PriorAuthorizationOnFile).HasMaxLength(10);
            entity.Property(e => e.PriorAuthorizationType).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SrMedOffRampDataId).HasColumnName("SR_MedOffRampDataId");
            entity.Property(e => e.SrMedOffRampDataRequestPoliciesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SR_MedOffRampDataRequestPoliciesId");
            entity.Property(e => e.SrOffRampId).HasColumnName("SR_OffRampId");
            entity.Property(e => e.SubscriberDateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.SubscriberFirstName).HasMaxLength(128);
            entity.Property(e => e.SubscriberGender).HasMaxLength(10);
            entity.Property(e => e.SubscriberLastName).HasMaxLength(128);
            entity.Property(e => e.SubscriberMemberId).HasMaxLength(128);
            entity.Property(e => e.SubscriberMiddleName).HasMaxLength(128);
            entity.Property(e => e.SubscriberPrefix).HasMaxLength(128);
            entity.Property(e => e.SubscriberSuffix).HasMaxLength(128);
            entity.Property(e => e.SubscriberTitle).HasMaxLength(128);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrMedOffRampDataRequestPoliciesTmp> entity);
    }
}
