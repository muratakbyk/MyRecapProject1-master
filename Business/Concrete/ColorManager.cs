﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            
            _colorDal.Add(color);
            return new Result(true, Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return  new SuccessDataResult<List<Color>>( _colorDal.GetAll(),Messages.ColorsListed);
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            return  new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == ColorId));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, Messages.ColorUpdated);
        }
    }
}
