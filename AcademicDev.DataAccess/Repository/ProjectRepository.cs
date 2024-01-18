using AcademicDev.DataAccess.Repository.IRepository;
using AcademicDev.Models;
using AcademicDevP.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDev.DataAccess.Repository
{
        public class ProjectRepository : Repository<Project>, IProjectRepository
        {
            private ApplicationDbContext _context;
            public ProjectRepository(ApplicationDbContext context) : base(context)
            {
                _context = context;
            }

            public void Update(Project obj)
            {
                var objFromDb = _context.Projects.FirstOrDefault(u =>u.ProjectId == obj.ProjectId);
                if(objFromDb != null)
                {
                    objFromDb.PrjName = obj.PrjName;
                    objFromDb.Description = obj.Description;
                    objFromDb.CategoryId = obj.CategoryId;
                    objFromDb.GithubLink = obj.GithubLink;
                    if(objFromDb.Image != null)
                    {
                        objFromDb.Image = obj.Image;
                    }
                }
            }
        }
}
