using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

[Table("speciality")]
public partial class Speciality
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("speciality_code")]
    [StringLength(10)]
    public string SpecialityCode { get; set; } = null!;

    [Column("speciality_name")]
    [StringLength(255)]
    public string SpecialityName { get; set; } = null!;

    [Column("number_of_places")]
    public int NumberOfPlaces { get; set; }

    [Column("education_form")]
    public int EducationForm { get; set; }

    [Column("tuition_fee")]
    public int TuitionFee { get; set; }
}
