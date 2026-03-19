using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

[Table("login_type")]
public partial class LoginType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("employee_login_type")]
    [StringLength(10)]
    public string EmployeeLoginType { get; set; } = null!;
}
