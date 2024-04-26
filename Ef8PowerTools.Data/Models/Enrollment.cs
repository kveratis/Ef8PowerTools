﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public string PatientFirstName { get; set; }

    public string PatientMiddleName { get; set; }

    public string PatientLastName { get; set; }

    public DateOnly? PatientDob { get; set; }

    public string PatientGender { get; set; }

    public string PatientPreferredLanguage { get; set; }

    public string PatientOtherLanguage { get; set; }

    public string PatientEmail { get; set; }

    public string PatientHomePhoneNumber { get; set; }

    public string PatientMobileNumber { get; set; }

    public string PatientAddress1 { get; set; }

    public string PatientAddress2 { get; set; }

    public string PatientZip { get; set; }

    public string PatientCity { get; set; }

    public string PatientState { get; set; }

    public bool? PatientOkToLeaveMsgMobile { get; set; }

    public bool? PatientOkToLeaveMsgHome { get; set; }

    public int? InsuranceId { get; set; }

    public bool? HasPatientInsurance { get; set; }

    public bool? MedicarePartB { get; set; }

    public bool? MedicarePartD { get; set; }

    public bool? MedicareAdvantage { get; set; }

    public bool? Medicaid { get; set; }

    public bool? VaMilitary { get; set; }

    public bool? CommercialPrivateInsurance { get; set; }

    public bool? Other { get; set; }

    public string PrimaryPlanName { get; set; }

    public string PrimaryCardHolderId { get; set; }

    public string PrimaryGroupNumber { get; set; }

    public string PrimaryPhoneNumber { get; set; }

    public string SecondaryPlanName { get; set; }

    public string SecondaryCardHolderId { get; set; }

    public string SecondaryGroupNumber { get; set; }

    public string SecondaryPhoneNumber { get; set; }

    public string PharmacyPlanName { get; set; }

    public string PharmacyCardHolderId { get; set; }

    public string RxGroupNumber { get; set; }

    public string RxBin { get; set; }

    public string RxPcn { get; set; }

    public string PharmacyPhoneNumber { get; set; }

    public string OtherPlanName { get; set; }

    public string OtherCardHolderId { get; set; }

    public string OtherGroupNumber { get; set; }

    public string OtherPhoneNumber { get; set; }

    public int? PhysicianId { get; set; }

    public string PhysicianFirstName { get; set; }

    public string PhysicianLastName { get; set; }

    public string PhysicianMiddleName { get; set; }

    public string PhysicianNpi { get; set; }

    public string PhysicianTaxId { get; set; }

    public string PhysicianStateLicenseNumber { get; set; }

    public string PhysicianLicenseState { get; set; }

    public string PhysicianOrganizationName { get; set; }

    public string PhysicianOrganizationNpi { get; set; }

    public string PhysicianOrganizationTaxId { get; set; }

    public string PhysicianAddress1 { get; set; }

    public string PhysicianAddress2 { get; set; }

    public string PhysicianZip { get; set; }

    public string PhysicianCity { get; set; }

    public string PhysicianState { get; set; }

    public string PhysicianPhoneNumber { get; set; }

    public string PhysicianFaxNumber { get; set; }

    public string OfficeContactFirstName { get; set; }

    public string OfficeContactLastName { get; set; }

    public string OfficeContactPhone { get; set; }

    public DateOnly? TreatmentStartDate { get; set; }

    public string DiagnosisCodes { get; set; }

    public string OtherDiagnosisCodes { get; set; }

    public string AdministrationInformation { get; set; }

    public int? FacilityId { get; set; }

    public string FacilityNpi { get; set; }

    public string FacilityName { get; set; }

    public string FacilityAddress1 { get; set; }

    public string FacilityAddress2 { get; set; }

    public string FacilityState { get; set; }

    public string FacilityCity { get; set; }

    public string FacilityTaxId { get; set; }

    public string FacilityOfficeContactFirstName { get; set; }

    public string FacilityOfficeContactLastName { get; set; }

    public string FacilityOfficeContactPhone { get; set; }

    public int? PatientAttestationId { get; set; }

    public string PatientAttestationType { get; set; }

    public string ElectronicAttestationPatientEmail { get; set; }

    public string ElectronicAttestationPatientPhone { get; set; }

    public bool? IsCertified { get; set; }

    public string TypedSignature { get; set; }

    public DateOnly? SignatureDate { get; set; }

    public int? PatientId { get; set; }

    public int? OrganizationAddressId { get; set; }

    public string MedicalBeneficiaryId { get; set; }

    public string OtherInsurance { get; set; }

    public int? OrganizationId { get; set; }

    public int? ProgramId { get; set; }

    public string CaremetxRecordId { get; set; }

    public string CaremetxRecordType { get; set; }

    public int? PatientAddressId { get; set; }

    public byte[] AdministrationInformationFormData { get; set; }

    public byte[] InsuranceCardData { get; set; }

    public byte[] ManualAttestationFileData { get; set; }

    public string InsuranceCardName { get; set; }

    public string EnrollmentType { get; set; }

    public string AdministrationInformationFormName { get; set; }

    public string ManualAttestationFileName { get; set; }

    public string PatientCopayCardId { get; set; }

    public string GroupNumber { get; set; }

    public string PreferredMethodOfPayment { get; set; }

    public byte[] AdditionalDocumentsData { get; set; }

    public string AdditionalDocumentsName { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string FacilityZip { get; set; }

    public bool? PatientPreviouslyEnrolled { get; set; }

    public bool? HasAscvsorHeFh { get; set; }

    public bool? ContactPatientForEnrollmentIssues { get; set; }

    public string OrganizationEmail { get; set; }

    public string PhysicianPtan { get; set; }

    public string PhysicianDea { get; set; }

    public string PhysicianEmail { get; set; }

    public string OfficeContactFax { get; set; }

    public string OfficeContactEmail { get; set; }

    public string PrimaryEmployer { get; set; }

    public string PrimarySubscriberRelationshipToCardholder { get; set; }

    public string SecondaryEmployer { get; set; }

    public string SecondarySubscriberRelationshipToCardholder { get; set; }

    public bool? SecondaryIsMedicalSupplementPlan { get; set; }

    public string SecondaryMedicalSupplementPlanLetter { get; set; }

    public string ClinicalContraindications { get; set; }

    public string ClinicalVisualAcuityLeftEye { get; set; }

    public string ClinicalVisualAcuityRightEye { get; set; }

    public bool? HasCaregiver { get; set; }

    public string CaregiverFirstName { get; set; }

    public string CaregiverLastName { get; set; }

    public string CaregiverMiddleName { get; set; }

    public string CaregiverEmail { get; set; }

    public string CaregiverHomePhoneNumber { get; set; }

    public string CaregiverMobilePhoneNumber { get; set; }

    public string CaregiverRelationship { get; set; }

    public bool? CaregiverIsLegallyAuthorizedRep { get; set; }

    public bool? PrimaryPatientIsPrimaryCardholder { get; set; }

    public string PrimarySubscriberFirstName { get; set; }

    public string PrimarySubscriberLastName { get; set; }

    public DateOnly? PrimarySubscriberDob { get; set; }

    public bool? SecondaryPatientIsPrimaryCardholder { get; set; }

    public string SecondarySubscriberFirstName { get; set; }

    public string SecondarySubscriberLastName { get; set; }

    public DateOnly? SecondarySubscriberDob { get; set; }

    public string ClinicalCptcode1 { get; set; }

    public string ClinicalBillingPreference { get; set; }

    public bool? ClinicalisSampleProductAdministered { get; set; }

    public DateOnly? ClinicalDateProductNeeded { get; set; }

    public bool? ClinicalAnyKnownDrugAllergies { get; set; }

    public string ClinicalAllergies { get; set; }

    public string PrescriptionDrugDescription { get; set; }

    public decimal? PrescriptionQuantity { get; set; }

    public string PrescriptionQuantityUnitOfMeasure { get; set; }

    public int? PrescriptionDaysSupply { get; set; }

    public int? PrescriptionNumberOfRefills { get; set; }

    public DateOnly? PrescriptionEffectiveDate { get; set; }

    public bool? PrescriptionAllowSubstitutions { get; set; }

    public string PrescriptionDirectionForUse { get; set; }

    public string PrescriptionAdditionalNotes { get; set; }

    public string PrescriptionTypedSignature { get; set; }

    public DateOnly? PrescriptionTypedSignatureDate { get; set; }

    public string ClinicalCptcode2 { get; set; }

    public string ClinicalCptcode3 { get; set; }

    public string ClinicalCptcode4 { get; set; }

    public string ClinicalCptcode5 { get; set; }

    public bool? ClinicalHasStartedTreatment { get; set; }

    public string Signatures { get; set; }

    public string DiagnosisCodesSecondary { get; set; }

    public string DiagnosisCodesTertiary { get; set; }

    public int? DrugId { get; set; }

    public string PlaceOfService { get; set; }

    public Guid? PatientEnrollmentGuid { get; set; }

    public string PatientLast4Ssn { get; set; }

    public bool? MedicaidPending { get; set; }

    public string PolicyHolderName { get; set; }

    public string PatientPreferredPhone { get; set; }

    public DateOnly? ClinicalPreviousTreatmentStartDate { get; set; }

    public DateOnly? ClinicalPreviousTreatmentEndDate { get; set; }

    public string ClinicalPreviousTreatmentDose { get; set; }

    public string ClinicalPreviousTreatment { get; set; }

    public string ClinicalPreviousTreatmentFrequency { get; set; }

    public bool? ClinicalOptIn { get; set; }

    public DateOnly? ClinicalPreviousTreatmentStartDate1 { get; set; }

    public DateOnly? ClinicalPreviousTreatmentEndDate1 { get; set; }

    public string ClinicalPreviousTreatmentDose1 { get; set; }

    public string ClinicalPreviousTreatment1 { get; set; }

    public string ClinicalPreviousTreatmentFrequency1 { get; set; }

    public DateOnly? ClinicalPreviousTreatmentStartDate2 { get; set; }

    public DateOnly? ClinicalPreviousTreatmentEndDate2 { get; set; }

    public string ClinicalPreviousTreatmentDose2 { get; set; }

    public string ClinicalPreviousTreatment2 { get; set; }

    public string ClinicalPreviousTreatmentFrequency2 { get; set; }

    public string PrescriptionHeight { get; set; }

    public string PrescriptionWeight { get; set; }

    public string PrescriptionBsa { get; set; }

    public string Prescription15mg { get; set; }

    public string Prescription20mg { get; set; }

    public string PrescriptionFixedDoseTablet { get; set; }

    public string PrescriptionTabletsPerCycle { get; set; }

    public string PrescriptionSig { get; set; }

    public bool? IsCertified2 { get; set; }

    public string SecondaryPolicyHolderName { get; set; }

    public string PrimaryPolicyHolderName { get; set; }

    public string OtherPolicyHolderName { get; set; }

    public string PrescriptionSig1 { get; set; }

    public int? PrescriptionNumberOfRefills1 { get; set; }

    public string PrescriptionInitialDose { get; set; }

    public string PrescriptionSecondDose { get; set; }

    public string PharmacyName { get; set; }

    public string PharmacyOtherValue { get; set; }

    public bool? IsCertified3 { get; set; }

    public string PrescriptionPhysicianSignatureType { get; set; }

    public bool? PrescriptionSigningAttestation { get; set; }

    public string DiagnosisDescription { get; set; }

    public string TreatingSiteContactName { get; set; }

    public bool? HasAscvd { get; set; }

    public bool? HasHeFh { get; set; }

    public bool? HasClinicalOther { get; set; }

    public string ClinicalAscvdtext { get; set; }

    public string ClinicalHeFhtext { get; set; }

    public string ClinicalOtherText { get; set; }
}