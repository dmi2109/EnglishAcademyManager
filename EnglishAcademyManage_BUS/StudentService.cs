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

        public StudentService()
        {
            context = new EnglishAcademyDbContext();
        }
        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }
        public string AddStudent(Student student)
        {
            try
            {
                if (context.Students.Any(s => s.student_id == student.student_id))
                {
                    return "Mã học viên đã tồn tại.";
                }
                //student.Status = true;
                context.Students.Add(student);
                context.SaveChanges();
                return "Thêm học viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi thêm học viên: {ex.Message}";
            }
        }
        public Student GetStudentById(string student_id)
        {
            return context.Students.FirstOrDefault(s => s.student_id == student_id);
        }
        public string UpdateStudent(Student student)
        {
            try
            {
                var existingStudent = context.Students.FirstOrDefault(s => s.student_id == student.student_id);
                if (existingStudent == null)
                {
                    return "Học viên không tồn tại.";
                }

                existingStudent.last_name = student.last_name;
                existingStudent.first_name = student.first_name;
                existingStudent.day_of_birth = student.day_of_birth;
                existingStudent.phone = student.phone;
                existingStudent.email = student.email;

                context.SaveChanges();
                return "Cập nhật thông tin sinh viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi cập nhật sinh viên: {ex.Message}";
            }
        }
        public string DeleteStudent(string studentId)
        {
            try
            {
                var existingStudent = context.Students.FirstOrDefault(s => s.student_id == studentId);
                if (existingStudent == null)
                {
                    return "Sinh viên không tồn tại.";
                }

                //existingStudent.Status = false; // Đánh dấu học viên đã bị xóa
                context.SaveChanges();
                return "Đã đánh dấu học viên là đã xóa!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi xóa sinh viên: {ex.Message}";
            }
        }

        public List<StudentRegistrationInfo> GetStudentRegistrationInfo(string classId)
        {
            var studentInfo = from s in context.Students
                              join r in context.Registrations on s.student_id equals r.student_id into registrations
                              from reg in registrations.DefaultIfEmpty()
                              join c in context.Courses on reg.course_id equals c.course_id into courses
                              from course in courses.DefaultIfEmpty()
                              join cls in context.Classes on course.course_id equals cls.course_id
                              where cls.class_id == classId
                              select new StudentRegistrationInfo
                              {
                                  StudentId = s.student_id,
                                  LastName = s.last_name,
                                  FirstName = s.first_name
                              };

            return studentInfo.ToList();
        }





        public class StudentRegistrationInfo
        {
            public string StudentId { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public DateTime? RegistrationDate { get; set; }
            public string CourseName { get; set; }
            public string Status { get; set; }
        }


    }
}
