using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManage_BUS
{
    public class ClassService
    {
        private readonly EnglishAcademyDbContext context = new EnglishAcademyDbContext();
        public List<Class> GetAll()
        {
            return context.Classes.ToList();
        }
        public string AddClass(Class classes)
        {
            try
            {
                if (context.Classes.Any(s => s.class_id == classes.class_id))
                {
                    return "Mã lớp học đã tồn tại.";
                }
                classes.Status = true;
                context.Classes.Add(classes);
                context.SaveChanges();
                return "Thêm lớp học thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi thêm lớp học: {ex.Message}";
            }
        }
        public Class GetClassById(string class_id)
        {
            return context.Classes.FirstOrDefault(s => s.class_id == class_id);
        }
        public string UpdateClass(Class classes)
        {
            try
            {
                var existingClass = context.Classes.FirstOrDefault(s => s.class_id == classes.class_id);
                if (existingClass == null)
                {
                    return "lớp học không tồn tại.";
                }

                existingClass.class_name = classes.class_name;
                existingClass.start_date = classes.start_date;
                existingClass.end_date = classes.end_date;

                context.SaveChanges();
                return "Cập nhật thông tin lớp học thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi cập nhật lớp học: {ex.Message}";
            }
        }
        public string DeleteClass(string class_id)
        {
            try
            {
                var existingClass = context.Classes.FirstOrDefault(s => s.class_id == class_id);
                if (existingClass == null)
                {
                    return "lớp học không tồn tại.";
                }

                existingClass.Status = false; // Đánh dấu lớp học đã bị xóa
                context.SaveChanges();
                return "Đã đánh dấu lớp học là đã xóa!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi xóa lớp học: {ex.Message}";
            }
        }

    }
}
