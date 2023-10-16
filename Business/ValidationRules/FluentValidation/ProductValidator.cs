using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class ProductValidator:AbstractValidator<Product>
    {  //IValidator Validate etmek istediğimiz ürünün özeliklerini tutan yer kural olan class
        public ProductValidator()
        {   // (Rulefor kim için kural)
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(P => P.UnitPrice).GreaterThanOrEqualTo(10).When(P=>P.CategoryId==1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı  ");
        }                                                //hata mesajı //

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
