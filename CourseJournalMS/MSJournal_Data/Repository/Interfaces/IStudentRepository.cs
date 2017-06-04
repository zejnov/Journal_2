﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSJournal_Data.Models;

namespace MSJournal_Data.Repository.Interfaces
{
    interface IStudentRepository
    {
        bool Add(Student model);
        bool Exist(Student model);
        Student Get(int id);
        List<Student> GetAll();
        bool UpdateStudentData(Student oldModel, Student newModel);
    }
}
