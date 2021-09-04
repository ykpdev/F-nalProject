using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
        //categorı ile ilgili  Dış dünyaya neyi servis etmek istorsam onu buraya yazarım
    {
        List<Category> GetAll();

       Category GetById(int categoryId);


    }
}
