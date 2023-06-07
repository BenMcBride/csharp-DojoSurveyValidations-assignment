#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidations.Models;
public class Survey
{
  [Required]
  [MinLength(2)]
  [Display(Name = "Your Name:")]
  public string Name { get; set; }

  [Required]
  [Display(Name = "Location:")]
  public string Location { get; set; }

  [Required]
  [Display(Name = "Location:")]
  public string Language { get; set; }

  [MaxLength(20)]
  public string? Comment { get; set; }
}