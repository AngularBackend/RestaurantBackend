using System;
using System.Collections.Generic;
using System.Text;

namespace AngularProjesiCommon.Data_Contracts
{
    //IDisposable kullanmamızın sebebi işlem bittikten sonra RAM den atmamız gerek 
  public interface IUnitOfWork : IDisposable
    {
        void Save(); //Save İşlemlerimiz tek bir kanal(TRANSACTION)üzerinden yürütülmesini istediğim için void kullandık 
    }
}
