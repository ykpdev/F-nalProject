using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
  public static class Messages
    {
        // basit bir mesaj yazılacağı için new gerek yok o yüzden static yazılır
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="ürünler listelendi";
        public  static string ProductCountOfCategoryError="Bir Kategoridde en fazla 10 ürün olablir  ";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded = "Kategory limiti aşıldığı için ürün eklenemiyor";
    }
}
