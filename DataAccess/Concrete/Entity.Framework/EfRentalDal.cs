﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity.Framework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyRecapContext>, IRentalDal
    {
        
            
    }
}
