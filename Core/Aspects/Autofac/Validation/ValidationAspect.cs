using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception  // => Aspect tir (metotun sonunda başında hata verdiğinde çalışacak yapıdır )
    {
        private Type _validatorType; 
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrılama sınıfı değildir");
            }

            _validatorType = validatorType;
        }                        // Onbefore başında çalışır nedeni validation doğrulama yapar sadece metotun başında çalışır 
        protected override void OnBefore(IInvocation invocation)
        {
            //sadece onbefore çalışır nedeni MethodInterception da ki onbefore u yazdık
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }  
    }
}
