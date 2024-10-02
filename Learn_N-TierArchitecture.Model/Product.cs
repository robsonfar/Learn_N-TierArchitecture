using System.ComponentModel.DataAnnotations;

namespace Learn_N_TierArchitecture.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public ProductType ProductType { get; set; }
    }
}
