﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public  class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }

        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public List<CarImage> CarImage { get; set; }


    }
}
