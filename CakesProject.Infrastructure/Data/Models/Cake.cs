namespace CakesProject.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Cake
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public int Pieces { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime CreatedDate { get; set; }

        public decimal PriceForPiece { get; set; }

        public decimal PriceForCake { get; set; }

        public int CakeNumber { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
