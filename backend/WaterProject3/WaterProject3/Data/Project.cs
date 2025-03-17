using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WaterProject3.Data;

public partial class Project
{
    [Key]
    public int ProjectId { get; set; }

    [Required]
    public string ProjectName { get; set; } = null!;

    public string? ProjectType { get; set; }

    public string? ProjectRegionalProgram { get; set; }

    public int? ProjectImpact { get; set; }

    public string? ProjectPhase { get; set; }

    public string? ProjectFunctionalityStatus { get; set; }
}
