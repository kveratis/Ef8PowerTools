﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientJourneyDatumConfiguration : IEntityTypeConfiguration<PatientJourneyDatum>
    {
        public void Configure(EntityTypeBuilder<PatientJourneyDatum> entity)
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Pkid, "Pkid_PatientJourney").IsClustered();

            entity.Property(e => e.Bicompleted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BICompleted");
            entity.Property(e => e.BicompletedColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BICompletedColor");
            entity.Property(e => e.BicompletedNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BICompletedNA");
            entity.Property(e => e.Call24hourPostInitiation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_24HourPostInitiation");
            entity.Property(e => e.Call24hourPostInitiationColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_24HourPostInitiationColor");
            entity.Property(e => e.Call24hourPostInitiationNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_24HourPostInitiationNA");
            entity.Property(e => e.Call2weekpostinitiationeducation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_2weekpostinitiationeducation");
            entity.Property(e => e.Call2weekpostinitiationeducationColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_2weekpostinitiationeducationColor");
            entity.Property(e => e.Call2weekpostinitiationeducationNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_2weekpostinitiationeducationNA");
            entity.Property(e => e.CallPostInitiationTitration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_PostInitiationTitration");
            entity.Property(e => e.CallPostInitiationTitrationColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_PostInitiationTitrationColor");
            entity.Property(e => e.CallPostInitiationTitrationNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Call_PostInitiationTitrationNA");
            entity.Property(e => e.CareCycleState)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CarecycleId).HasColumnName("CarecycleID");
            entity.Property(e => e.CarecycleStartDate).HasColumnType("datetime");
            entity.Property(e => e.CoCnurseCurrent)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CoCNurse_Current");
            entity.Property(e => e.CoCnurseInit)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CoCNurse_Init");
            entity.Property(e => e.CompleteSmnreceived)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CompleteSMNReceived");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentMaintenanceSmnreceived)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentMaintenanceSMNReceived");
            entity.Property(e => e.CurrentMaintenanceSmnreceivedNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentMaintenanceSMNReceivedNA");
            entity.Property(e => e.CurrentPacompletedDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentPACompletedDate");
            entity.Property(e => e.CurrentPacompletedDateColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentPACompletedDateColor");
            entity.Property(e => e.CurrentPacompletedDateNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentPACompletedDateNA");
            entity.Property(e => e.CurrentPastartDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentPAStartDate");
            entity.Property(e => e.CurrentPastartDateNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentPAStartDateNA");
            entity.Property(e => e.DaysSinceLastFill)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExportId).HasColumnName("ExportID");
            entity.Property(e => e.FirstWecomeCallAttempt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstWecomeCallAttemptColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstWecomeCallAttemptNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FirstWecomeCallAttemptNA");
            entity.Property(e => e.InitialPriorAuthorization)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InitialPriorAuthorizationColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InitialPriorAuthorizationNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InitialPriorAuthorizationNA");
            entity.Property(e => e.InitialShipDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InitialShipDateColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InitialShipDateNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InitialShipDateNA");
            entity.Property(e => e.InitiationVisit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InitiationVisitColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InitiationVisitNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InitiationVisitNA");
            entity.Property(e => e.LastShipDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastShipDateNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastShipDateNA");
            entity.Property(e => e.MaintenancePriorAuthorization)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaintenancePriorAuthorizationColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaintenancePriorAuthorizationNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MaintenancePriorAuthorizationNA");
            entity.Property(e => e.MaintenanceSmnreceived)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MaintenanceSMNReceived");
            entity.Property(e => e.MaintenanceSmnreceivedColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MaintenanceSMNReceivedColor");
            entity.Property(e => e.MaintenanceSmnreceivedNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MaintenanceSMNReceivedNA");
            entity.Property(e => e.MonthlyFollowUp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthlyFollowUpNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MonthlyFollowUpNA");
            entity.Property(e => e.MostRecentCompletedContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MostRecentContactAttempt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NurseAssignmentDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NurseAssignmentDateColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NurseAssignmentDateNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NurseAssignmentDateNA");
            entity.Property(e => e.Pafreceived)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAFReceived");
            entity.Property(e => e.PafreceivedColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAFReceivedColor");
            entity.Property(e => e.PafreceivedNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAFReceivedNA");
            entity.Property(e => e.Painitiated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAInitiated");
            entity.Property(e => e.PatCategory)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientInit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientName)
                .HasMaxLength(130)
                .IsUnicode(false);
            entity.Property(e => e.PatientStatus)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientStatusDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianName)
                .HasMaxLength(130)
                .IsUnicode(false);
            entity.Property(e => e.Pkid).ValueGeneratedOnAdd();
            entity.Property(e => e.PostInitiationFollowUpVisit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostInitiationFollowUpVisitNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PostInitiationFollowUpVisitNA");
            entity.Property(e => e.PreInitiationEducationVisit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreInitiationEducationVisitNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PreInitiationEducationVisitNA");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RefillRemaining)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SmnreferralReceivedDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMNReferralReceivedDate");
            entity.Property(e => e.SmnreferralReceivedDateNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMNReferralReceivedDateNA");
            entity.Property(e => e.SpecialtyPharmacy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartSmntype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("StartSMNType");
            entity.Property(e => e.Territory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TitrationFormFaxedtoHcp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TitrationFormFaxedtoHCP");
            entity.Property(e => e.TitrationFormFaxedtoHcpna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TitrationFormFaxedtoHCPNA");
            entity.Property(e => e.Visit1weekPostinitiation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("visit_1weekPostinitiation");
            entity.Property(e => e.Visit1weekPostinitiationColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("visit_1weekPostinitiationColor");
            entity.Property(e => e.Visit1weekPostinitiationNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("visit_1weekPostinitiationNA");
            entity.Property(e => e.WelcomeCallCompleted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WelcomeCallCompletedNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WelcomeCallCompletedNA");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientJourneyDatum> entity);
    }
}
