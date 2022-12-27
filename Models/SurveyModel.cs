using System.ComponentModel.DataAnnotations;
// Dissable the nullable warnings
#pragma warning disable CS8618

namespace DojoSurveyWithModel.Models;
public class Survey
{
    [Required]
    [MinLength(2)]
    public string Name {get;set;}
    [Required]
    public string DojoLocation {get;set;}
    [Required]
    public string FavoriteLanguage {get;set;}
    [MinLength(21)]
    public string? Comment {get;set;}
}