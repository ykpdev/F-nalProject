using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface IProductDal :IEntityRepository<Product>
    {
        //yapılmasının sebebi IEntityRepository i Product için yapılandırdın demektir özel opesyonlar için kullanılır
        List<ProductDetailDto> GetProductDetails();

    }
}
