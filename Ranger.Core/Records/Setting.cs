using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ranger.Core.Records
{
    public record Setting
    {
        [Key] public int Id { get; set; }
        [Required] public Dictionary<string, string> Headers { get; set; } = new();
        [Required] public string ScreenshotResolution { get; set; } = "1920x1080";
        [Required] public int MaxAllowedRedirect { get; set; } = 4;
        [Required] public int Timeout { get; set; } = 4000;
        [Required] public int Threads { get; set; } = Environment.ProcessorCount;
        [Required] public bool AllowAutomaticRedirect { get; set; } = true;
        [Required] public bool Screenshot { get; set; } = true;
        [Required] public bool IgnoreTls { get; set; } = true;
        [Required] public bool ResolveName { get; set; } = true;
    }
}