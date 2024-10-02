using System.ComponentModel.DataAnnotations;

namespace Learn_N_TierArchitecture.Model
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
