using System.ComponentModel.DataAnnotations;

namespace CayoteRoadRunners.Models
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string HTMLContent { get; set; }
        public string VideoLink { get; set; }
        // one to one relationship reference
        public CategoryItem CategoryItem { get; set; }
    }
}
