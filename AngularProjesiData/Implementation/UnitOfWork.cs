using AngularProjesiCommon.Data_Contracts;
using AngularProjesiData.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularProjesiData.Implementation
{
    public class UnitOfWork : IUnitOfWork
    { 

    private readonly AngularProjesiDbContext _db; 
    public UnitOfWork(AngularProjesiDbContext db)
    {
            _db = db;
        
    }

    
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
           _db.SaveChanges();  //Tüm aksiyonlarımız db SaveChanges üzerinden türeyecektir
        }
    }
}
