using System;
using System.Collections.Generic;

namespace APINOTES.Models;

public partial class Note
{
    public int Id { get; set; }

    public string Tittel { get; set; } = null!;

    public string Description { get; set; } = null!;
}
