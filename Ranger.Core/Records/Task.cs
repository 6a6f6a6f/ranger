using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ranger.Core.Records
{
    public record Task
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required] public DateTime ExpirationAt { get; set; }
        
        [Required] public bool IsRunning { get; set; }
        [Required] public List<Bulk> Bulks { get; set; }
    }
}