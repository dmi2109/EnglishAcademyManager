using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManage_BUS
{
    public class TeacherService
    {
        private readonly EnglishAcademyDbContext context = new EnglishAcademyDbContext();
        public List<Teacher> GetAll()
        {
            return context.Teachers.ToList();
        }

        public string AddTeacher(Teacher teacher)
        {
            try
            {
                if (context.Teachers.Any(s => s.teacher_id == teacher.teacher_id))
                {
                    return "Mã giáo viên đã tồn tại.";
                }

                teacher.Status = true;
                context.Teachers.Add(teacher);
                context.SaveChanges();
                return "Thêm giáo viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi thêm giáo viên: {ex.Message}";
            }
        }
        public Teacher GetTeacherById(string teacher_id)
        {
            return context.Teachers.FirstOrDefault(s => s.teacher_id == teacher_id);
        }
        public string UpdateTeacher(Teacher teacher)
        {
            try
            {
                var existingTeacher = context.Teachers.FirstOrDefault(s => s.teacher_id == teacher.teacher_id);
                if (existingTeacher == null)
                {
                    return "Giáo viên không tồn tại.";
                }

                existingTeacher.last_name = teacher.last_name;
                existingTeacher.first_name = teacher.first_name;
                existingTeacher.phone = teacher.phone;
                existingTeacher.email = teacher.email;

                context.SaveChanges();
                return "Cập nhật thông tin sinh viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi cập nhật sinh viên: {ex.Message}";
            }
        }
        public string DeleteTeacher(string teacherId)
        {
            try
            {
                var existingTeacher = context.Teachers.FirstOrDefault(s => s.teacher_id == teacherId);
                if (existingTeacher == null)
                {
                    return "Sinh viên không tồn tại.";
                }
                existingTeacher.Status = false;
                context.SaveChanges();
                return "Đã đánh dấu giáo viên là đã xóa!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi xóa sinh viên: {ex.Message}";
            }
        }

    }
}
