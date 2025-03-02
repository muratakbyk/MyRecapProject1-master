﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;



namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails( Expression<Func<CarDetailDto, bool>> filter = null);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carid);
        IDataResult<List<CarDetailDto>> GetFilteredCars(int brandid,int colorid);
        IDataResult<Car> GetById(int Id);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IResult AddTransactionalTest(Car car);


    }
}
