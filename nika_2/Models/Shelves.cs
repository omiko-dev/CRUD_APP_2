using Microsoft.Build.Framework;

namespace nika_2.Models
{
    public class Shelves
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        public int Capacity { get; set; } 


    }
}
