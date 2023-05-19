using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> categoryItems { get; set; }
        [ForeignKey("CategoryId")]

        public virtual ICollection<UserCategory> UserCategories  { get; set; }
    }
}
