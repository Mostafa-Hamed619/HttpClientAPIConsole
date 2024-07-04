using System;
using System.Collections.Generic;

namespace AspNetTopics.Models;

public partial class VillaNumber
{
    public int VillaNo { get; set; }

    public int VillaId { get; set; }

    public string? SpecialDetails { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Villa Villa { get; set; } = null!;
}
