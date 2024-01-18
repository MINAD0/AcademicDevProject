using AcademicDev.DataAccess.Repository;
using AcademicDev.DataAccess.Repository.IRepository;
using AcademicDev.Models;
using AcademicDev.Models.ViewModels;
using AcademicDevP.DataAccess.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AcademicDevP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProjectController(IUnitOfWork db, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = db;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Project> objProjectList = _unitOfWork.Projects.GetAll(includeProperties:"Category").ToList();           
            return View(objProjectList);
        }
        public IActionResult Upsert(int? id)
        {
            ProjectVM projectVM = new ProjectVM()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.CategoryId.ToString()
                }),
                Project = new Project()
            };
            if (id == null || id==0)
            {
                //create
                return View(projectVM);
            }
            else
            {
                //update
                projectVM.Project = _unitOfWork.Projects.Get(u => u.ProjectId == id);
                return View(projectVM);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(ProjectVM projectVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string projectPath = Path.Combine(wwwRootPath, @"Images\projects");

                    if(!string.IsNullOrEmpty(projectVM.Project.Image)) 
                    {
                        //delete old image
                        var oldimage = Path.Combine(wwwRootPath, projectVM.Project.Image.TrimStart('\\'));
                        if(System.IO.File.Exists(oldimage))
                        {
                            System.IO.File.Delete(oldimage);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(projectPath, fileName),FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    projectVM.Project.Image = @"\Images\projects\"+fileName;
                }
                if(projectVM.Project.ProjectId == 0)
                {
                    _unitOfWork.Projects.Add(projectVM.Project);
                    TempData["success"] = "Project created successfully";
                }
                else
                {
                    _unitOfWork.Projects.Update(projectVM.Project);
                    TempData["success"] = "Project updated successfully";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            else
            {
                projectVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.CategoryId.ToString()
                });
                return View(projectVM);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            Project categoryFromDb = _unitOfWork.Projects.Get(u => u.ProjectId == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Project obj = _unitOfWork.Projects.Get(u => u.ProjectId == id);
            if (obj == null)
            {
                return NotFound(obj);
            }
            _unitOfWork.Projects.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Project deleted successfully";
            return RedirectToAction("Index");
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Project> objProjectList = _unitOfWork.Projects.GetAll(includeProperties:"Category").ToList();
            return Json(new
            {
                data = objProjectList
            });
        }
        #endregion
    }
}
