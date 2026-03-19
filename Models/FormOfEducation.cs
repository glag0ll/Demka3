using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

[Table("form_of_education")]
[Index("EducationForm", Name = "form_of_education_unique", IsUnique = true)]
public partial class FormOfEducation
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("education_form", TypeName = "character varying")]
    public string EducationForm { get; set; } = null!;
}
