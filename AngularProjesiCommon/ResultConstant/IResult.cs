using System;
using System.Collections.Generic;
using System.Text;

namespace AngularProjesiCommon.ResultConstant
{
   public interface IResult
    {
        bool IsSucces{ get; set; }
        String Message { get; set; }
    }
}
