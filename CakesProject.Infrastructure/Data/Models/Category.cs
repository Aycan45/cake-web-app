namespace CakesProject.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static CakesProject.Infrastructure.Data.DataConstants;
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameLength)]
        public string Name { get; set; } = null!;
    }
}
