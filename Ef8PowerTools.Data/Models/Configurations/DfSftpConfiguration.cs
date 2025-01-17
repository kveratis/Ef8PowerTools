﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfSftpConfiguration : IEntityTypeConfiguration<DfSftp>
    {
        public void Configure(EntityTypeBuilder<DfSftp> entity)
        {
            entity.ToTable("DF_SFTP");

            entity.Property(e => e.DfSftpid).HasColumnName("DF_SFTPID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DfJobId).HasColumnName("DF_JobID");
            entity.Property(e => e.FailureEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FileMask)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Host)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsCmdLineSftp)
                .HasDefaultValue(false)
                .HasColumnName("IsCmdLineSFTP");
            entity.Property(e => e.IsOutboundSftp)
                .HasDefaultValue(true)
                .HasColumnName("IsOutboundSFTP");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocalFolder)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Port)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RemoteFolder)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SftpPassword)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SFTP_Password");
            entity.Property(e => e.SftpSshkeyFileName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SFTP_SSHKeyFileName");
            entity.Property(e => e.SftpcmdLine)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SFTPCmdLine");
            entity.Property(e => e.SftpscriptText)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SFTPScriptText");
            entity.Property(e => e.SuccessEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorType)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfSftp> entity);
    }
}
