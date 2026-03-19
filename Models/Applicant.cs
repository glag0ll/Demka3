using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

[Table("applicants")]
[Index("ApplicantCode", Name = "applicants_unique", IsUnique = true)]
public partial class Applicant
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("full_name")]
    [StringLength(255)]
    public string? FullName { get; set; }

    [Column("applicant_code")]
    public int? ApplicantCode { get; set; }

    [Column("passport_data")]
    [StringLength(100)]
    public string? PassportData { get; set; }

    [Column("birthday")]
    public DateOnly? Birthday { get; set; }

    [Column("address")]
    [StringLength(255)]
    public string? Address { get; set; }

    [Column("e-mail")]
    [StringLength(255)]
    public string? EMail { get; set; }

    [Column("phone_number")]
    [StringLength(25)]
    public string? PhoneNumber { get; set; }
}
