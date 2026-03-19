using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

[Table("presence_of_something")]
public partial class PresenceOfSomething
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("answers")]
    [StringLength(50)]
    public string Answers { get; set; } = null!;
}
