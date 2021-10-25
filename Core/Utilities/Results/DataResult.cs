using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ //DataResult aynı zaman da Result dır 
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }



        public T Data { get; }
    }
}
