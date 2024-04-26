﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfEbvTrackingConfiguration : IEntityTypeConfiguration<DfEbvTracking>
    {
        public void Configure(EntityTypeBuilder<DfEbvTracking> entity)
        {
            entity.HasKey(e => e.TrackingId).HasName("pk_DF_EbvTracking");

            entity.ToTable("DF_EbvTracking");

            entity.Property(e => e.AltCoverageReferral)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ClientPatientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CopayCardProgram)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CptCode1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CptCode2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CptCode3)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CptCode4)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CptCode5)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.InternalReference)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MedicareId)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Mfg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MFG");
            entity.Property(e => e.NoFaxingFlag)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PatientDob).HasColumnName("PatientDOB");
            entity.Property(e => e.PatientFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientGender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PatientLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientSsn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("PatientSSN");
            entity.Property(e => e.PatientZip)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Policy1MemberId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PatientSubscriber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PayerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PayerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PriorAuthNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PriorAuthOnFile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PriorAuthmisc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy1PriorAuthtype)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy1SubscriberDob).HasColumnName("Policy1SubscriberDOB");
            entity.Property(e => e.Policy1SubscriberFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy1SubscriberGender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy1SubscriberLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy1SubscriberMemberId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy2McSuppPlanLetter)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy2MemberId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PatientSubscriber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PayerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PayerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PriorAuthMisc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PriorAuthNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PriorAuthType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy2PriorAuthonFile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy2SubscriberDob).HasColumnName("Policy2SubscriberDOB");
            entity.Property(e => e.Policy2SubscriberFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy2SubscriberGender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy2SubscriberLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy2SubscriberMemberId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy3MemberId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PatientSubscriber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PayerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PayerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PriorAuthMisc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PriorAuthNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PriorAuthOnFile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Policy3PriorAuthType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy3SubscriberDob).HasColumnName("Policy3SubscriberDOB");
            entity.Property(e => e.Policy3SubscriberFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy3SubscriberGender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Policy3SubscriberLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Policy3SubscriberMemberid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pos)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POS");
            entity.Property(e => e.PracticeAddress1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PracticeAddress2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PracticeCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PracticeContactFname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PracticeContactFName");
            entity.Property(e => e.PracticeContactLname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PracticeContactLName");
            entity.Property(e => e.PracticeFaxnumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PracticeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PracticeNpi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PracticeNPI");
            entity.Property(e => e.PracticeState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PracticeZip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryDiagnosis)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProviderFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderNpi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ProviderNPI");
            entity.Property(e => e.ProviderState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProviderTaxId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProviderTitle)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ResponseId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseMessage).HasColumnType("text");
            entity.Property(e => e.ResponseStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryDiagnosis)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SiteOfficeFax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TertiaryDiagnosis)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfEbvTracking> entity);
    }
}
