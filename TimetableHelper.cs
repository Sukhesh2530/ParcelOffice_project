using System;
using System.Data;
using System.Data.SqlClient;

namespace ParcelOffice_project
{
    public static class TimetableHelper
    {
        public enum ScheduleType
        {
            Early = 0,
            Late = 1
        }

        public static ScheduleType GetStudentScheduleType(int studentId)
        {
            try
            {
                object courseIdObj = DatabaseHelper.ExecuteScalar(
                    "SELECT CourseId FROM Students WHERE StudentId = @studentId",
                    new SqlParameter("@studentId", studentId));

                if (courseIdObj == null)
                    return ScheduleType.Early;

                int courseId = Convert.ToInt32(courseIdObj);
                int? scheduleType = DatabaseHelper.GetCourseScheduleType(courseId);

                if (scheduleType.HasValue && scheduleType.Value == (int)ScheduleType.Late)
                    return ScheduleType.Late;

                return ScheduleType.Early;
            }
            catch
            {
                return ScheduleType.Early;
            }
        }

        public static (DateTime SlotStart, DateTime SlotEnd)? GetNextAvailableSlot(int studentId)
        {
            try
            {
                ScheduleType scheduleType = GetStudentScheduleType(studentId);

                DataTable dt = DatabaseHelper.ExecuteQuery(
                    @"SELECT SlotName, StartTime, EndTime
                      FROM TimetableSlots
                      WHERE ScheduleType = @scheduleType AND IsBreak = 1
                      ORDER BY StartTime",
                    new SqlParameter("@scheduleType", (int)scheduleType));

                if (dt.Rows.Count == 0)
                    return null;

                DateTime now = DateTime.Now;
                DateTime today = now.Date;

                foreach (DataRow row in dt.Rows)
                {
                    TimeSpan startTime = (TimeSpan)row["StartTime"];
                    TimeSpan endTime = (TimeSpan)row["EndTime"];

                    DateTime slotStart = today.Add(startTime);
                    DateTime slotEnd = today.Add(endTime);

                    if (now <= slotEnd)
                        return (slotStart, slotEnd);
                }

                DataRow firstRow = dt.Rows[0];
                TimeSpan nextStart = (TimeSpan)firstRow["StartTime"];
                TimeSpan nextEnd = (TimeSpan)firstRow["EndTime"];
                DateTime nextDay = today.AddDays(1);

                return (nextDay.Add(nextStart), nextDay.Add(nextEnd));
            }
            catch
            {
                return null;
            }
        }

        public static string GetSlotName(DateTime slotStart, DateTime slotEnd, ScheduleType scheduleType)
        {
            try
            {
                object slotNameObj = DatabaseHelper.ExecuteScalar(
                    @"SELECT TOP 1 SlotName
                      FROM TimetableSlots
                      WHERE ScheduleType = @scheduleType
                        AND StartTime = @startTime
                        AND EndTime = @endTime",
                    new SqlParameter("@scheduleType", (int)scheduleType),
                    new SqlParameter("@startTime", slotStart.TimeOfDay),
                    new SqlParameter("@endTime", slotEnd.TimeOfDay));

                return slotNameObj == null ? "Break Slot" : slotNameObj.ToString();
            }
            catch
            {
                return "Break Slot";
            }
        }

        public static string FormatSlotTime(DateTime slotStart, DateTime slotEnd)
        {
            return $"{slotStart:dddd, dd MMM yyyy} | {slotStart:hh:mm tt} - {slotEnd:hh:mm tt}";
        }
    }
}
