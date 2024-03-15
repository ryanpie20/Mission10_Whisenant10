using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10_Whisenant.Data;

public partial class Team
{
    [Key]
    [Required]
    public int TeamId { get; set; }

    public string? TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }
}
