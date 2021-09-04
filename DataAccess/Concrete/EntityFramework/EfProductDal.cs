using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{//NuGet: Başkalrında yazdığı kodların bulunduğu ortam
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        // EfProductDal içinde bütün veri tsbsnı operasyonları hazır 
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId=p.ProductId,ProductName=p.ProductName,
                                 CategoryName=c.CategoryName,UnitInStock=p.UnitsInStock};
                return result.ToList();
            }
        }

        
    }
}
