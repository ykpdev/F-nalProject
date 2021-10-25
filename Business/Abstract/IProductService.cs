using Core.Utilities.Results;
using Entites.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IProductService
    {    //IDataResult ile hem işlem sonucu hemde mesaj dödürülür
        IDataResult<List<Product>> GetAll();

       IDataResult< List<Product>> GetAllByCategoryId(int id);

        IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max);

       IDataResult< List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);

        IDataResult<Product> GetById(int productId);  

    }
}
