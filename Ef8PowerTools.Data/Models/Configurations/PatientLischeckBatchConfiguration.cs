﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientLischeckBatchConfiguration : IEntityTypeConfiguration<PatientLischeckBatch>
    {
        public void Configure(EntityTypeBuilder<PatientLischeckBatch> entity)
        {
            entity.ToTable("PatientLISCheckBatch");

            entity.Property(e => e.PatientLischeckBatchId).HasColumnName("PatientLISCheckBatchID");
            entity.Property(e => e.AbRejectCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ab_reject_code");
            entity.Property(e => e.AbRejectCode2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ab_reject_code_2");
            entity.Property(e => e.AbRejectText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ab_reject_text");
            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("client_id");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DBin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_bin");
            entity.Property(e => e.DContractId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_contract_id");
            entity.Property(e => e.DGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_group");
            entity.Property(e => e.DMemberId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_member_id");
            entity.Property(e => e.DPcn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_pcn");
            entity.Property(e => e.DPlanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_plan_id");
            entity.Property(e => e.DPlanName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("d_plan_name");
            entity.Property(e => e.DRejectCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_reject_code");
            entity.Property(e => e.DRejectCode2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("d_reject_code_2");
            entity.Property(e => e.DRejectText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("d_reject_text");
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.Dob)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dob");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Hcin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hcin");
            entity.Property(e => e.InboundFileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LischeckDate)
                .HasColumnType("datetime")
                .HasColumnName("LISCheckDate");
            entity.Property(e => e.Lislevel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LISLevel");
            entity.Property(e => e.PartA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("part_a");
            entity.Property(e => e.PartB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("part_b");
            entity.Property(e => e.PartD)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("part_d");
            entity.Property(e => e.PatientFirst)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patient_first");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientLast)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patient_last");
            entity.Property(e => e.ProcessingComments)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("processing_comments");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ssn");
            entity.Property(e => e.TransactionStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction_status");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientLischeckBatch> entity);
    }
}