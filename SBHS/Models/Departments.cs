﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SBHS.Models;

public partial class Departments
{
    public int Id { get; set; }

    [Display(Name = "Departments")]
    public string DepartmentName { get; set; }

    public virtual ICollection<OncallRequests> OncallRequests { get; set; } = new List<OncallRequests>();

    public virtual ICollection<UserDetails> UserDetails { get; set; } = new List<UserDetails>();
}