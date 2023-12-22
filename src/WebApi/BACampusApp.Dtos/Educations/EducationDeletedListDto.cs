﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACampusApp.Dtos.Educations
{
    public class EducationDeletedListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CourseHours { get; set; }
        public string Description { get; set; }
        public string SubCategoryId { get; set; }
    }
}
