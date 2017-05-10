﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace CourseJournalMS
{
    public class CourseDay
    {
        private static DateTime CourseDayDate;               //add
        private static int _courseDayNumber = 0;     //!?!?

        public enum AttendanceOnCourse
        {
            none,
            p,      //for present
            present,
            a,      //for absent
            absent,
        }
        public AttendanceOnCourse Attendance;
        public DateTime DayOfClasses;
        public int DayOrderNumber;

        public CourseDay(Student student)  //creator!!
        {
            Console.Write("{0}. {1} {2} is: ", student.OrderNumber, student.Name, student.Surname);
            Attendance = (CourseDay.AttendanceOnCourse) Enum.Parse(typeof(CourseDay.AttendanceOnCourse), Console.ReadLine());
            DayOrderNumber = _courseDayNumber+1;
            DayOfClasses = CourseDayDate;
        }

        public static void NewCourseDay()
        {
            Console.Write("Please enter date of course day: ");
            CourseDayDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("For each student please enter p(present) or a(absent):");
        }

        public static void IncreaseCourseDayNumber()
        {
            _courseDayNumber++;
        }

        public static int DaysOfCourse()
        {
            return _courseDayNumber;
        }

    }
}