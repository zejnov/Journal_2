﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSJournal_Business.Dtos;
using MSJournal_Data.Models;

namespace MSJournal_Business.Mappers
{
    public class DtoToEntity
    {
        public static Report ReportDtoToEntity(ReportDto reportDto)
        {
            if (reportDto == null)
            {
                return null;
            }

            var report = new Report()
            {
                Course = CourseDtoToEntity(reportDto.Course),
                TimeOfGeneration = reportDto.TimeOfGeneration,
            };

                report.CourseStudentList = new List<StudentOnCourse>();
            foreach (var entry in reportDto.CourseStudentList)
            {
                report.CourseStudentList.Add(StudentOnCourseDtoToEntity(entry));
            }
            
            return report;
        }

        public static Student StudentDtoToEntity(StudentDto student)
        {
            if (student == null)
            {
                return null;
            }

            return new Student
            {
                Id = student.Id,
                Name = student.Name,
                Surname = student.Surname,
                Gender = student.Gender,
                BirthDate = student.BirthDate,
                Pesel = student.Pesel,

                HomeworkPoints = student.HomeworkPoints,
                HomeworkPerformance = student.HomeworkPerformance,
                HomeworkMaxPoints = student.HomeworkMaxPoints,
                PresentDays = student.PresentDays,
                StudentAttendance = student.StudentAttendance,
                AttendanceOk = student.AttendanceOk,
                HomeworkOk = student.HomeworkOk,
                CourseDays = student.CourseDays,
            };
        }

        public static Course CourseDtoToEntity(CourseDto course)
        {
            if (course == null)
            {
                return null;
            }

            return new Course()
            {
                Id = course.Id,
                Name = course.Name,
                LeaderName = course.LeaderName,
                LeaderSurname = course.LeaderSurname,
                StartDate = course.StartDate,
                HomeworkThreshold = course.HomeworkThreshold,
                PresenceThreshold = course.PresenceThreshold,
                StudentsNumber = course.StudentsNumber,
            };
        }

        public static StudentOnCourse StudentOnCourseDtoToEntity(StudentOnCourseDto studentOnCourse)
        {
            if (studentOnCourse == null)
            {
                return null;
            }

            return new StudentOnCourse()
            {
                Id = studentOnCourse.Id,
                Course = CourseDtoToEntity(studentOnCourse.Course),
                Student = StudentDtoToEntity(studentOnCourse.Student),
            };
        }

        public static Homework HomeworkDtoToEntity(HomeworkDto homework)
        {
            if (homework == null)
            {
                return null;
            }

            return new Homework()
            {
                Id = homework.Id,
                StudentPoints = homework.StudentPoints,
                MaxPoints = homework.MaxPoints,
                StudentOnCourse = StudentOnCourseDtoToEntity(homework.StudentOnCourse),
            };
        }

        public static CourseDay CourseDayDtoToEntity(CourseDayDto courseDay)
        {
            if (courseDay == null)
            {
                return null;
            }

            return new CourseDay()
            {
                Id = courseDay.Id,
                Attendance = courseDay.Attendance,
                StudentOnCourse = StudentOnCourseDtoToEntity(courseDay.StudentOnCourse),
            };
        }
    }

}
