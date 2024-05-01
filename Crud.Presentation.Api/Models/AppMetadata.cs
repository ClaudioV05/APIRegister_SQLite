using System.ComponentModel.DataAnnotations;

namespace Crud.Presentation.Api.Models;

public class AppMetadata
{
    /// <summary>
    /// Script of Metadata.
    /// </summary>
    [Required]
    public string? ScriptMetadata { get; set; }

    /// <summary>
    /// Identify of development Environment.
    /// </summary>
    [Required]
    public int IdDevelopmentEnvironment { get; set; }

    /// <summary>
    /// Identify of databases.
    /// </summary>
    [Required]
    public int IdDatabases { get; set; }

    /// <summary>
    /// Identify of forms.
    /// </summary>
    [Required]
    public int IdForms { get; set; }
}