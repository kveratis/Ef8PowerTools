﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientFmrsrHistoryAuditConfiguration : IEntityTypeConfiguration<PatientFmrsrHistoryAudit>
    {
        public void Configure(EntityTypeBuilder<PatientFmrsrHistoryAudit> entity)
        {
            entity.ToTable("PatientFMRSR_History_Audit", tb => tb.HasTrigger("TR_PatientFMRSR_History_Audit_Permission"));

            entity.Property(e => e.PatientFmrsrHistoryAuditId).HasColumnName("PatientFMRSR_History_AuditID");
            entity.Property(e => e.AddressPhy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Address_Phy");
            entity.Property(e => e.ChangeAction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Change_Action");
            entity.Property(e => e.CityPhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("City_Phy");
            entity.Property(e => e.ContactName)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByLog)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedBy_log");
            entity.Property(e => e.CreatedBySr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedBy_SR");
            entity.Property(e => e.CreatedLog).HasColumnName("Created_log");
            entity.Property(e => e.CreatedSr)
                .HasColumnType("datetime")
                .HasColumnName("Created_SR");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocSource)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DrugCertificationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnrollmentDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentDatePhy)
                .HasColumnType("datetime")
                .HasColumnName("EnrollmentDate_Phy");
            entity.Property(e => e.EntityAsContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaxPhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fax_Phy");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstNamePhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FirstName_Phy");
            entity.Property(e => e.FmrscAnnualVerification)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Annual_Verification");
            entity.Property(e => e.FmrscInteractionId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FMRSC_InteractionID");
            entity.Property(e => e.FmrscNegativePregnancyTest)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Negative_Pregnancy_Test");
            entity.Property(e => e.FmrscPrescriberSignatureDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMRSC_PrescriberSignatureDate");
            entity.Property(e => e.FmrscReasonForChange)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Reason_for_Change");
            entity.Property(e => e.FmrscReasonForChangeDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Reason_for_Change_Description");
            entity.Property(e => e.FmrscReproductiveStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Reproductive_Status");
            entity.Property(e => e.FmrscStatusDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Status_Description");
            entity.Property(e => e.FmrscType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FMRSC_Type");
            entity.Property(e => e.FmrscVerballyAccepted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMRSC_VerballyAccepted");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastNamePhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastName_phy");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedBySr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastUpdatedBy_SR");
            entity.Property(e => e.LastUpdatedSr)
                .HasColumnType("datetime")
                .HasColumnName("LastUpdated_SR");
            entity.Property(e => e.NpiPhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPI_Phy");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientFmrsrHistoryId).HasColumnName("PatientFMRSR_HistoryID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientSpid).HasColumnName("PatientSPID");
            entity.Property(e => e.PhonePat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_Pat");
            entity.Property(e => e.PhonePhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_Phy");
            entity.Property(e => e.PhysicianAddressId).HasColumnName("PhysicianAddressID");
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Resolution)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ResolutionId).HasColumnName("ResolutionID");
            entity.Property(e => e.ShCreated)
                .HasColumnType("datetime")
                .HasColumnName("SH_Created");
            entity.Property(e => e.ShCreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SH_CreatedBy");
            entity.Property(e => e.ShLastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("SH_LastUpdated");
            entity.Property(e => e.ShLastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SH_LastUpdatedby");
            entity.Property(e => e.Spname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SPName");
            entity.Property(e => e.SrStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SR_Status");
            entity.Property(e => e.SrSubTypeFullDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SR_SubTypeFullDesc");
            entity.Property(e => e.SrSubTypeListId).HasColumnName("SR_SubTypeListID");
            entity.Property(e => e.SrTypeFullDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SR_TypeFullDesc");
            entity.Property(e => e.SrTypeListId).HasColumnName("SR_TypeListID");
            entity.Property(e => e.Srfcomplete)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SRFComplete");
            entity.Property(e => e.Srfreason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SRFReason");
            entity.Property(e => e.Srid).HasColumnName("SRID");
            entity.Property(e => e.StatePhy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("State_Phy");
            entity.Property(e => e.StatusPat)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("Status_Pat");
            entity.Property(e => e.SurveyHistoryId).HasColumnName("SurveyHistoryID");
            entity.Property(e => e.TriageSrid).HasColumnName("TriageSRID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZipPhy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Zip_Phy");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientFmrsrHistoryAudit> entity);
    }
}
