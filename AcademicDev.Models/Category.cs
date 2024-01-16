using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AcademicDev.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
