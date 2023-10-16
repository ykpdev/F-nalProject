using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[]logics) //params ile istediğimiz kadar IResult virgül ile döndürebiliyoruz
        {
            foreach (var logic in logics)//tüm kuralları gez kurala uymayan varsa onu döndür
            {
                if (!logic.Success) //başarısız ise logic (iş kodu döndür)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
