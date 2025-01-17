﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DispenseConfiguration : IEntityTypeConfiguration<Dispense>
    {
        public void Configure(EntityTypeBuilder<Dispense> entity)
        {
            entity.ToTable(tb => tb.HasTrigger("UpdateDispenses"));

            entity.HasIndex(e => new { e.ItemName, e.Deleted }, "IX_Dispenses_ItemName_Deleted");

            entity.HasIndex(e => new { e.ProgramId, e.Deleted }, "IX_Dispenses_ProgramID_Deleted");

            entity.HasIndex(e => e.PatientId, "PatientID");

            entity.HasIndex(e => new { e.ProgramId, e.PatientId, e.DrugName }, "Program_PatientID_Drug");

            entity.Property(e => e.DispenseId).HasColumnName("DispenseID");
            entity.Property(e => e.AlteraId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AlteraID");
            entity.Property(e => e.BinNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CareCycleId).HasColumnName("CareCycleID");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CopayAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CopayCardAmountUsed).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CopayCardId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CopayCardID");
            entity.Property(e => e.CopayPaid).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedFileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustomField1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomField2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomField3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomField4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomField5)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeviceSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Diagnosis)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Diagnosis2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Diagnosis3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DispendsesFromSpid).HasColumnName("Dispendses_fromSPID");
            entity.Property(e => e.DispenseData).HasColumnType("xml");
            entity.Property(e => e.DoseType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExternalPatientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalPatientID");
            entity.Property(e => e.ExternalSpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalSPName");
            entity.Property(e => e.FacilityAddress1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityAddress2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FacilityState)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityZip)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FemalePatientCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FillNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstShipDate).HasColumnName("First_Ship_Date");
            entity.Property(e => e.Fnrptype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FNRPType");
            entity.Property(e => e.Frequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Frpcounseled)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRPCounseled");
            entity.Property(e => e.FrppatientPregnant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRPPatientPregnant");
            entity.Property(e => e.FrppregnancyTest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRPPregnancyTest");
            entity.Property(e => e.GroupNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsurancePlanName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastReceivedRxdate).HasColumnName("LastReceivedRXDate");
            entity.Property(e => e.LastSynced).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lftperformed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LFTPerformed");
            entity.Property(e => e.MajorMedicalName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Miligrams).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MonthlyCounseled)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ndc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NDC");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderTransactionNum)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.PaapprovalDate).HasColumnName("PAApprovalDate");
            entity.Property(e => e.Pacode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PACode");
            entity.Property(e => e.PaexpirationDate).HasColumnName("PAExpirationDate");
            entity.Property(e => e.Parequired).HasColumnName("PARequired");
            entity.Property(e => e.PastatusCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAStatusCode");
            entity.Property(e => e.PatientAdr1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientAdr2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientCopay).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.PatientDob).HasColumnName("PatientDOB");
            entity.Property(e => e.PatientFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientGender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientPayAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PatientPhone)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PatientPhysicianId).HasColumnName("Patient_PhysicianID");
            entity.Property(e => e.PatientState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PatientZip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PayerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pbmname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBMName");
            entity.Property(e => e.Pcn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PCN");
            entity.Property(e => e.PharmaCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PharmacyDea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PharmacyDEA");
            entity.Property(e => e.PharmacyNcpdp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PharmacyNCPDP");
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.PrescriberNotifiedLft)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrescriberNotifiedLFT");
            entity.Property(e => e.PrescriberNotifiedPreg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrescriberNotifiedType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryBenefitType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primary_Benefit_Type");
            entity.Property(e => e.PrimaryClaimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryCopayType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primary_Copay_Type");
            entity.Property(e => e.PrimaryCoverageType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryDeductible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primary_Deductible");
            entity.Property(e => e.PrimaryLifetimeMax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primary_Lifetime_Max");
            entity.Property(e => e.PrimaryMaxOop)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primary_Max_Oop");
            entity.Property(e => e.PrimaryPlanType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primary_Plan_Type");
            entity.Property(e => e.ProductForm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Product_Form");
            entity.Property(e => e.ProductLot)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ProviderAddress1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProviderAddress2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProviderCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderDea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ProviderDEA");
            entity.Property(e => e.ProviderFax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProviderFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderNpi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ProviderNPI");
            entity.Property(e => e.ProviderPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProviderSpecialty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProviderZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ProviderZIP");
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ReasonForChange)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReferralDate).HasColumnType("datetime");
            entity.Property(e => e.ReferralNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferralSource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefillRemaining).HasColumnType("decimal(8, 0)");
            entity.Property(e => e.RestatementFlag)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RxLabelInfo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RxfilledOrCancellationDate).HasColumnName("RXFilledOrCancellationDate");
            entity.Property(e => e.ScCfcenterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SC_CFCenterID");
            entity.Property(e => e.ScCfcenterName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SC_CFCenterName");
            entity.Property(e => e.SecondaryBenefitType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Benefit_Type");
            entity.Property(e => e.SecondaryCopayAmount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Copay_Amount");
            entity.Property(e => e.SecondaryCopayType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Copay_Type");
            entity.Property(e => e.SecondaryDeductible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Deductible");
            entity.Property(e => e.SecondaryLifetimeMax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Lifetime_Max");
            entity.Property(e => e.SecondaryMaxOop)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Max_Oop");
            entity.Property(e => e.SecondaryPaExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("Secondary_PA_Expiration_Date");
            entity.Property(e => e.SecondaryPaRequired)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_PA_Required");
            entity.Property(e => e.SecondaryPayerBinNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryPayerGroupNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryPayerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryPayerPcn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SecondaryPayerPCN");
            entity.Property(e => e.SecondaryPayerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryPlanName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryPlanType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Secondary_Plan_Type");
            entity.Property(e => e.ShipCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipState)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ShipTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipToAddress1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipToAddress2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipToCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipToPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShipZipcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ShipZIPCode");
            entity.Property(e => e.ShippingCarrier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.SpCfcenterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SP_CFCenterID");
            entity.Property(e => e.SpProviderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SP_ProviderID");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.Spnpi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPNPI");
            entity.Property(e => e.SpreadyToShipDate).HasColumnName("SPReadyToShipDate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TerritoryID");
            entity.Property(e => e.TertiaryPayerBinNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TertiaryPayerGroupNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TertiaryPayerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TertiaryPayerPcn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TertiaryPayerPCN");
            entity.Property(e => e.TertiaryPayerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionSequence)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferPharmacyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitOfMeasure)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedFileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Dispense> entity);
    }
}
