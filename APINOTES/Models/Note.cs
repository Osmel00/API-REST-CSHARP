using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APINOTES.Models;

public partial class Note
{
    public int Id { get; set; }
    
    [Required]
    public string Tittel { get; set; } = null!;
    
    [Required]
    public string Description { get; set; } = null!;
}
