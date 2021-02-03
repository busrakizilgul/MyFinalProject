﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint - Generic Kısıt
    //class: referans tip olabilir anlamına gelir
    //IEntity: ya IEntity olabilir ya da IEntity den implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmalı. 

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
