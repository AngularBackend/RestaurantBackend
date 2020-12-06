using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AngularProjesiCommon.Data_Contracts
{
   public interface IRepository<T> where T : class ,new()
    {
        //Birden çok data dönecek ise:IQueryable tipinde değişken tanımladık
        //IQueryable tipinde değişken tanımlamamızın sebebi ise: Uzak sunucuya sorgularımızı göndermek için
        IQueryable<T> Include<T1>(Expression<Func<T, T1>> selector); //Expression kullanmamızın sebebi birbirine bağlı dataları getir.
        T Get(int id);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);

        //Tek bir data için yapılacak CRUD işlemleri
        //Veritabanızda tablolardaki CRUD işlemleri defalarca sorgu yazmayıp tek bir yerden Repository patternler sayesinde işlemlerimizi gerçekleştireceğiz

    }
}
