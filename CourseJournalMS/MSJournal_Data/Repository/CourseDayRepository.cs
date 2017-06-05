﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSJournal_Data.Models;
using MSJournal_Data.Repository.Basic;
using MSJournal_Data.Repository.Interfaces;

namespace MSJournal_Data.Repository
{
    class CourseDayRepository : BasicRepository<CourseDay> , ICourseDayRepository
    {
        public override bool Add(CourseDay model)
        {
            return ExecuteQuery(dbContext =>
            {
                model.Course = dbContext.CourseDbSet
                    .First(p => p.Id == model.Course.Id);
                model.Student = dbContext.StudentDbSet
                    .First(p => p.Id == model.Student.Id);

                dbContext.CoruseDayDbSet.Add(model);
                model.Course.AttendanceList.Add(model);

                return true;
            });
        }

        public override CourseDay Get(int id)
        {
            return ExecuteQuery(dbContext => dbContext.CoruseDayDbSet
                .First(p => p.Id == id));
        }

        public override List<CourseDay> GetAll()
        {
            return ExecuteQuery(dbContext => dbContext.CoruseDayDbSet
                .ToList());
        }

        public override bool Exist(CourseDay model)
        {
            return ExecuteQuery(dbContext =>
            {
                var data = dbContext.CoruseDayDbSet
                    .FirstOrDefault(p => p.Id == model.Id);

                return data != null;
            });
        }
    }
}