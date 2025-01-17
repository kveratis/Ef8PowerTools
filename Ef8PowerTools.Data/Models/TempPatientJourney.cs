﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class TempPatientJourney
{
    public int Pkid { get; set; }

    public int? ProgramId { get; set; }

    public int? PatientId { get; set; }

    public int? CarecycleId { get; set; }

    public string PatientName { get; set; }

    public string PatientInit { get; set; }

    public string Territory { get; set; }

    public string Zip { get; set; }

    public string PatCategory { get; set; }

    public string StartSmntype { get; set; }

    public string PatientStatus { get; set; }

    public string PhysicianName { get; set; }

    public string CoCnurseInit { get; set; }

    public string CoCnurseCurrent { get; set; }

    public string CareCycleState { get; set; }

    public string SmnreferralReceivedDate { get; set; }

    public string SmnreferralReceivedDateColor { get; set; }

    public string Pafreceived { get; set; }

    public string PafreceivedColor { get; set; }

    public string Bicompleted { get; set; }

    public string BicompletedColor { get; set; }

    public string InitialPriorAuthorization { get; set; }

    public string InitialPriorAuthorizationColor { get; set; }

    public string MaintenancePriorAuthorization { get; set; }

    public string MaintenancePriorAuthorizationColor { get; set; }

    public string InitialShipDate { get; set; }

    public string InitialShipDateColor { get; set; }

    public string NurseAssignmentDate { get; set; }

    public string NurseAssignmentDateColor { get; set; }

    public string FirstWecomeCallAttempt { get; set; }

    public string FirstWecomeCallAttemptColor { get; set; }

    public string WelcomeCallCompleted { get; set; }

    public string PreInitiationEducationVisit { get; set; }

    public string InitiationVisit { get; set; }

    public string InitiationVisitColor { get; set; }

    public string Call24hourPostInitiation { get; set; }

    public string Call24hourPostInitiationColor { get; set; }

    public string MaintenanceSmnreceived { get; set; }

    public string MaintenanceSmnreceivedColor { get; set; }

    public string Visit1weekPostinitiation { get; set; }

    public string Visit1weekPostinitiationColor { get; set; }

    public string Call2weekpostinitiationeducation { get; set; }

    public string Call2weekpostinitiationeducationColor { get; set; }

    public string CurrentMaintenanceSmnreceived { get; set; }

    public string MonthlyFollowUp { get; set; }

    public string PostInitiationFollowUpVisit { get; set; }

    public string LastShipDate { get; set; }

    public string DaysSinceLastFill { get; set; }

    public string SpecialtyPharmacy { get; set; }

    public string CurrentPastartDate { get; set; }

    public string CurrentPacompletedDate { get; set; }

    public string CurrentPacompletedDateColor { get; set; }
}