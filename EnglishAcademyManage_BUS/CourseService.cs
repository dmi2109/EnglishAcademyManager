using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManage_BUS
{
    public class CourseService
    {
        private readonly EnglishAcademyDbContext _context; 

        public CourseService()
        {
            _context = new EnglishAcademyDbContext();
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            var existingCourse = _context.Courses.SingleOrDefault(c => c.course_id == course.course_id);
            if (existingCourse != null)
            {
                existingCourse.course_name = course.course_name;
                existingCourse.level = course.level;
                existingCourse.fee = course.fee;
                _context.SaveChanges();
            }
        }

        public void DeleteCourse(string courseId)
        {
            var course = _context.Courses.SingleOrDefault(c => c.course_id == courseId);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}

