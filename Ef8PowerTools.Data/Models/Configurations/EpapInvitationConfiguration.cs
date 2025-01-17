﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EpapInvitationConfiguration : IEntityTypeConfiguration<EpapInvitation>
    {
        public void Configure(EntityTypeBuilder<EpapInvitation> entity)
        {
            entity.HasKey(e => e.InvitationId).HasName("Pk_ePAP_Invites_InvitationID");

            entity.ToTable("EPAP_Invitations", tb => tb.HasComment("The ePAP invitation"));

            entity.Property(e => e.InvitationId)
                .ValueGeneratedNever()
                .HasComment("The primary key")
                .HasColumnName("InvitationID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasComment("The created timestamp")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("The user that generated the invitation");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("The email address for which the invitation was sent");
            entity.Property(e => e.Expiration)
                .HasComment("The invitation expiration timestamp")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Active flag");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasComment("Deleted flag for backend soft deletes");
            entity.Property(e => e.LastUpdated)
                .HasComment("The last updated timestamp")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("The user that last performed an update to the invitation");
            entity.Property(e => e.OnBehalfOf)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId)
                .HasComment("The program id")
                .HasColumnName("ProgramID");
            entity.Property(e => e.PublicId)
                .HasComment("The public invitation id")
                .HasColumnName("PublicID");
            entity.Property(e => e.ServiceRequestId)
                .HasComment("The service request id")
                .HasColumnName("ServiceRequestID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpapInvitation> entity);
    }
}
