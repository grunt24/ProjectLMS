using System.ComponentModel.DataAnnotations;

namespace LMS.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }
        public DateTime DateTimeReleased { get; set; }
    }
}
