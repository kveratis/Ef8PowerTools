﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class UserLoginHistory
{
    public int UserLoginHistoryId { get; set; }

    public int UserInformationId { get; set; }

    public string UserName { get; set; }

    public string HostName { get; set; }

    public string Ipaddress { get; set; }

    public string ExtraInfo { get; set; }

    public DateTime LoginDateTime { get; set; }

    public DateTime? LogoutDateTime { get; set; }
}