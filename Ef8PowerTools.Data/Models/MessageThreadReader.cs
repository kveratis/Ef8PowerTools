﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MessageThreadReader
{
    public int MessageThreadReaderId { get; set; }

    public int ThreadId { get; set; }

    public Guid UserId { get; set; }

    public DateTime ReadDateTime { get; set; }

    public virtual MessageThread Thread { get; set; }
}