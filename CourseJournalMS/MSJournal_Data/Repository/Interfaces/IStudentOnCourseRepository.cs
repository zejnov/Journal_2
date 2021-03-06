﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSJournal_Data.Models;

namespace MSJournal_Data.Repository.Interfaces
{
    public interface IStudentOnCourseRepository
    {
        bool AddStudentToCourse(StudentOnCourse model);

        bool RemoveStudentFromCourse(StudentOnCourse model);

        List<Student> StudentsOnCourse(Course model);

        int StudentsOnCourseCount(Course model);

        List<StudentOnCourse> StudentsListOnCourse(Course model);

        bool Add(StudentOnCourse model);

        StudentOnCourse Get(int id);

        List<StudentOnCourse> GetAll();

        bool Exist(StudentOnCourse model);


    }
}
