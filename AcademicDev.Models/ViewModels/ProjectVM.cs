using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDev.Models.ViewModels
{
    public class ProjectVM
    {
        public Project Project { get; set; }
        [ValidateNever]
        public IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CategoryList { get; set; }
    }
}
