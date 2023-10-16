using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
        //categorı ile ilgili  Dış dünyaya neyi servis etmek istorsam onu buraya yazarım
    {
       IDataResult< List<Category>> GetAll();

       IDataResult<  Category >GetById(int categoryId);


    }
}
