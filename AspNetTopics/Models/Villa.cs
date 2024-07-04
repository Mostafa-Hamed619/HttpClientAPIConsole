using System;
using System.Collections.Generic;

namespace AspNetTopics.Models;

public partial class Villa
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Details { get; set; }

    public double Rate { get; set; }

    public int Sqft { get; set; }

    public int Occupancy { get; set; }

    public string? ImageUrl { get; set; }

    public string? Amenity { get; set; }

    public DateTime DateCreation { get; set; }

    public DateTime UpdatedTime { get; set; }

    public virtual ICollection<VillaNumber> VillaNumbers { get; set; } = new List<VillaNumber>();
}
