﻿using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repository.Base;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : RepositoryBase<Course,IOContext>, ICourseDal
    {
    }
}
