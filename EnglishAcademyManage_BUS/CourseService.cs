using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManage_BUS
{
    public class CourseService
    {
        private readonly EnglishAcademyDbContext context = new EnglishAcademyDbContext();

        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }
    }
}
