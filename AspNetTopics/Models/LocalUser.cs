using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetTopics.Models;

public partial class LocalUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }
    [Required]
    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}
