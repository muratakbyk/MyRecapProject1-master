﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.Entity.Framework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MyRecapContext>, IUserDal

    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MyRecapContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                             return result.ToList();

            }
        }
    }
}
