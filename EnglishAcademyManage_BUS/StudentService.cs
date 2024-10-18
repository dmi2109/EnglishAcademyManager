using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManage_BUS
{
    public class StudentService
    {
        private readonly EnglishAcademyDbContext context = new EnglishAcademyDbContext();
        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }
    }
}
