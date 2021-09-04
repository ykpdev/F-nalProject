
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{  //generic constraint
    //class demek referans tip demektir
    //IEntity demek IEntity olabilir veya implemnete eden bir nesne olabilir
    // new demek new'lenebilir olmalı (IEntity interface olduğu için newlenemez)
   public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //null verdi ise tüm datayı istiyor demektir
        T Get(Expression<Func<T, bool>> filter );  //filtre verilmesi zorunlu      //tek bir data getirmek için 

        void Add(T entity);

        void Update(T entity);


        void Delete(T entity);


      
    }
}
