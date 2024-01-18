using AcademicDev.DataAccess.Repository.IRepository;
using AcademicDevP.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDev.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository Category { get; set; }
        public IProjectRepository Projects { get; set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            Projects = new ProjectRepository(_context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
