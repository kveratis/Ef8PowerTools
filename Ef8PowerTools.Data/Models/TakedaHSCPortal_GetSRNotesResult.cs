﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class TakedaHSCPortal_GetSRNotesResult
    {
        public int ServiceRequestID { get; set; }
        [Column("Created Date")]
        public DateTime CreatedDate { get; set; }
        public string SR_Type { get; set; }
        public string Subject { get; set; }
        [Column("Note Detail")]
        public string NoteDetail { get; set; }
    }
}
