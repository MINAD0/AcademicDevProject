using AcademicDev.DataAccess.Repository.IRepository;
using AcademicDev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AcademicDevP.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger,IUnitOfWork db)
        {
            _unitOfWork = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Project> projectsList = _unitOfWork.Projects.GetAll(includeProperties:"Category").ToList();
            return View(projectsList);
        }
        public IActionResult Details(int id)
        {
            Project project = _unitOfWork.Projects.Get(u=>u.ProjectId == id,includeProperties: "Category");
            return View(project);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
