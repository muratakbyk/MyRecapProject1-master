﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity

    {
        [Key]
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
    }
}
