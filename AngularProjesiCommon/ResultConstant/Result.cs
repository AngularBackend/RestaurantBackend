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

        public Result(bool isSuccess, string message) : this(isSuccess, message, default(T))
        {
                
        }
        public Result(bool isSuccess, string message, T data) : this(isSuccess, message, data, 0)
        {

        }

        public Result(bool isSuccess, string message, T data,int totalCount)
        {
            IsSucces = isSuccess;
            Message = message;
            Data = data;
            TotalCount = totalCount;

        }
        

    }
}
