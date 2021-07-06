using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ranger.Core.Records
{
    public record Bulk
    {
        [Key] public int Id { get; set; }
        [Required] public List<Target> Targets { get; set; }
    }
}