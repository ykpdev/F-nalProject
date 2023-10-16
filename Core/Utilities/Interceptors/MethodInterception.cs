﻿using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        //invocation business metotudur
        protected virtual void OnBefore(IInvocation invocation) { }   //Biz bir aspect yazdığımız zaman onun nerede çalışmasını istıyorsak onun ilgili metotlarını virtual metotlarda çalıştırızz
        protected virtual void OnAfter(IInvocation invocation) { }    //invocation ise o anki metot add, update,delete...  
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
