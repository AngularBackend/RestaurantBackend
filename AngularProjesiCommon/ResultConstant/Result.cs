using System;
using System.Collections.Generic;
using System.Text;

namespace AngularProjesiCommon.ResultConstant
{
   public class Result<T> : IResult
    {
        

        public T Data { get; set; }
        public int TotalCount { get; set; }
        public bool IsSucces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Result(bool isSuccess, string Message) : this(isSuccess, Message, default(T))
        {
                
        }
        public Result(bool isSuccess, string Message, T data) : this(isSuccess, Message, data, 0)
        {

        }


    }
}
