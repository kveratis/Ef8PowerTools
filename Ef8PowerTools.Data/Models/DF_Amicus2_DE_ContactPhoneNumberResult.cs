﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Amicus2_DE_ContactPhoneNumberResult
    {
        public int ContactPhoneNumberID { get; set; }
        public int ContactID { get; set; }
        public string ProgramName { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public string PrimaryYN { get; set; }
        public string OKtoLeaveMessageYN { get; set; }
        public string PreferredTimeToCall { get; set; }
        public string PhoneComments { get; set; }
        public string ActiveYN { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
    }
}
