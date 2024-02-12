using System.ComponentModel.DataAnnotations;

namespace PracticeProject1.Models
{
    public class Product
    {
        [Key]
        public int LaptopId { get; set; }

        [Required]
        public string? LaptopName { get; set; }    

        public string? LaptopDescription { get; set; }
        [Range(0, 50000,ErrorMessage ="The product rate shouldn't exceeds more than 1000 rupees")]
        public double LaptopRate { get; set; }
    }
}
