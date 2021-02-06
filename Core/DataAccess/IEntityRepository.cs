using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


//namespace=Classları interfaceleri belirli bir isim uzayının içine bırakıyoruz.
//Core bizim evrensel katmanımız. Tüm .net projelerinde kullanılabilr anlamına gelir. 
//Core katmanı diğer katmanları referans almaz. 
namespace Core.DataAccess 
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
