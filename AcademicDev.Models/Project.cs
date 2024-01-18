using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDev.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        public string PrjName { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required]
        [ValidateNever]
        public string Image { get; set; }
        [Required]
        public string GithubLink { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public Category Category { get; set; }

        public DateTime DateOfPublish { get; set; } = DateTime.UtcNow;
    }
}
