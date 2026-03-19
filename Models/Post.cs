using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

[Table("post")]
public partial class Post
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("employee_post")]
    [StringLength(255)]
    public string EmployeePost { get; set; } = null!;
}
