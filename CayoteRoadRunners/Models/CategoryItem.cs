using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CayoteRoadRunners.Models
{
    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public int MediaTypeId { get; set; }
        [NotMapped]
        public virtual ICollection<SelectListItem>? MediaTypes { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateTimeItemReleased {
            get
            { 
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now: _releaseDate;
            } 
            set
            {
                _releaseDate = value;
            }
                }
        [NotMapped]
        public int ContentId { get; set; }
    }
}
