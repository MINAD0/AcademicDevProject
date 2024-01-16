using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AcademicDev_Temp.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        [Range(0, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
