﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSJournal_Business.Dtos;
using MSJournal_Business.Mappers;
using MSJournal_Data.Repository;

namespace MSJournal_Business.Services
{
    public class CourseServices
    {
        public static bool Add(CourseDto courseDto)
        {
            if (Exist(courseDto))
                return false;
            return new CourseRepository()
                .Add(DtoToEntity.CourseDtoToEntity(courseDto));
        }

        public static bool Exist(CourseDto courseDto)
        {
            return new CourseRepository()
                .Exist(DtoToEntity.CourseDtoToEntity(courseDto));
        }
        public static CourseDto Get(int id)
        {
            if (!Exist(new CourseDto() { Id = id }))
                return null;

            return EntityToDto.CourseEntityToDto
                (new CourseRepository().Get(id));
        }

        public static List<CourseDto> GetAll()
        {
            return new CourseRepository()
                .GetAll()
                .Select(EntityToDto.CourseEntityToDto)
                .ToList();
        }

        public static bool UpdateCourseData(CourseDto oldModel, CourseDto newModel)
        {
            if (!Exist(oldModel))
                return false;

            return new CourseRepository().UpdateCourseData(
                DtoToEntity.CourseDtoToEntity(oldModel),
                DtoToEntity.CourseDtoToEntity(newModel));
        }

        public static int GetCourseCount()
        {
            return new CourseRepository().GetCourseCount();
        }
       
    }
}