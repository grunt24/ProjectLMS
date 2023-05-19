namespace LMS.Entities
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string HTMLContent { get; set; }
        public string VideoLink { get; set; }
        public CategoryItem categoryItem { get; set; }
    }
}
