﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SBHS.API.Models;

public partial class LeaveTypes
{
    public int Id { get; set; }

    public string LeaveTypeName { get; set; }

    public virtual ICollection<LeaveRequests> LeaveRequests { get; set; } = new List<LeaveRequests>();
}