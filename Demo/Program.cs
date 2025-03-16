using Demo.Data;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Cross Join
            using NorthwindContext dbContext = new NorthwindContext();




            //var Result = from S in dbContext.Suppliers
            //             from P in dbContext.Products
            //             select new
            //             {
            //                 Supplier = S,
            //                 Product = P
            //             };

            //  Result = dbContext.Suppliers
            //         .SelectMany(S => dbContext.Products, (S, P) => new
            //         {
            //             Supplier = S,
            //             Product = P
            //         });





            #endregion


            #region Run SQL Query, Stored Procedures
            //// Execute Select Statement // 1. FromSqlRaw - 2. FromSqlInterpolated

            //var count = 3;
            //var result = dbContext.Categories.FromSqlRaw("select top({0}) * from Categories", count);

            //var categories = dbContext.Categories.FromSqlInterpolated($"select top({count}) * from Categories");

            //// Execute Insert, Update, Delete Statement // 1. FromSqlRaw - 2. FromSqlInterpolated

            //var catId = 1;
            //dbContext.Database.ExecuteSqlInterpolated($"update Categories set CategoryName='TestCat' where CategoryID={catId}");

            //NorthwindContextProcedures northwindContextProcedures = new NorthwindContextProcedures(dbContext);

            //var res = northwindContextProcedures.SalesByCategoryAsync("TestCat", "2018").Result;

            #endregion

        }
    }
}
