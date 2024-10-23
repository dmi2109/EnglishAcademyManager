using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EnglishAcademyManage_DAL.Entities; // Ensure you have the correct using directive for your entity classes

namespace EnglishAcademyManage_BUS
{
    public class AttendanceService
    {
        private readonly EnglishAcademyDbContext _context;

        public AttendanceService()
        {
            _context = new EnglishAcademyDbContext();
        }

        // In AttendanceService.cs
        public void SaveAttendance(string studentId, string classId, DateTime date, string status)
        {
            using (var context = new EnglishAcademyDbContext())
            {
                var attendanceRecord = new Attendance
                {
                    student_id = studentId,
                    class_id = classId,
                    attendance_date = date,
                    status = status
                };

                context.Attendances.Add(attendanceRecord);
                context.SaveChanges(); // Save the changes to the database
            }
        }



        public List<Attendance> GetAttendanceByStudentId(string studentId)
        {
            return _context.Attendances
                .Where(a => a.student_id == studentId)
                .ToList();
        }

        // In AttendanceService.cs
        public List<Attendance> GetAttendanceForClassAndDate(string classId, DateTime date)
        {
            using (var context = new EnglishAcademyDbContext())
            {
                // Query the Attendances directly from the context
                var attendanceRecords = context.Attendances
                    .Where(a => a.class_id == classId && a.attendance_date == date)
                    .Include(a => a.Student) // Include related student data if needed
                    .ToList();

                return attendanceRecords;
            }
        }
    }
}
