using System;
using System.Linq;
using System.Text.RegularExpressions;
using static Linq02.ListGenerator;
namespace Linq02
{
    internal class Program
    {
        static void Main( )
        {
            #region Element Operator
            #region Fluent Syntax
            //var Result = ProductList.First();
            //Result = ProductList.Last();

            // List<Product> Test = new List<Product>();
            //var Result = ProductList.First();

            //First And List May Thow Eception

            //var Result = ProductList.FirstOrDefault(X=>X.ProductID==2);
            //Result = ProductList.LastOrDefault();

            //var Result = Test.FirstOrDefault();
            //Result = Test.LastOrDefault();

            //   var Result = ProductList.ElementAt(100);
            //var Result = ProductList.ElementAtOrDefault(100);

            // var Result = ProductList.Single();
            // var Result = ProductList.SingleOrDefault(X=>X.UnitPrice==10);

            #endregion

            #region  Query Syntax
            //var Result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select new
            //             {
            //                 p.ProductID,
            //                 p.ProductName,
            //                 p.UnitPrice,
            //             };


            //Hybride Syntax:
            //var Result = (from p in ProductList
            //              where p.UnitsInStock == 0
            //              select new
            //              {
            //                  p.ProductID,
            //                  p.ProductName,
            //                  p.UnitPrice,
            //              }).First();
            #endregion
            // Console.WriteLine(Result?.ProductName ?? "not found");
            //foreach(int item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Aggregate operators
            #region Count
            // var Result = ProductList.Count;
            //  var Result=ProductList.Count(X=>X.UnitsInStock==10);
            #endregion

            #region Max
            //var MinLeangth = ProductList.Min( P=>P.ProductName.Length);
            //var Result=(from p in ProductList
            //            where p.ProductName.Length == MinLeangth
            //            select p).FirstOrDefault();
            #endregion

            #region Sum & Average
            //var Result=ProductList.Sum(p=>p.UnitPrice);
            //  Result = ProductList.Average(p => p.UnitPrice);

            #endregion

            #region Aggregate [Important]
            //string[] Names = {"Omar","Ahmed","Mano","Moo"};
            //var Result = Names.Aggregate((str1, str2) =>$"{str1} {str2}");
            #endregion

            //   Console.WriteLine(Result);
            #endregion


            #region Casting Operator
            //List<Product> products =  ProductList.Where(X=>X.UnitsInStock==10).ToList(); //Casting 2 List
            //Product[] array = ProductList.Where(X => X.UnitsInStock == 0).ToArray();// Casting 2 array
            // Dictionary<long, string> products = ProductList.Where(X => X.UnitsInStock == 11).ToDictionary(X=>X.ProductID,X=>X.ProductName);
            // HashSet<Product> products=ProductList.Where(P=>P.UnitsInStock==0).ToHashSet();


            //ArrayList array=new ArrayList()
            //{
            //    "Ahmed",
            //    "Mohammed",
            //    "salah",
            //    1,
            //    2,
            //    3,
            //};
            // var Result=ProductList.OfType<string>();

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region Generation operators
            // The Only way To Call them is as methods from Enumerable Class
            // var Result = Enumerable.Range(0, 99);
            // var Result = Enumerable.Repeat(new Product(), 100);
            //var Result = Enumerable.Empty<Product>().ToArray();

            //foreach (var Item in Result)
            //{
            //    Console.Write ($"{Item} " );
            //}

            #endregion

            #region Set Operator

            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);
            // var Result=seq01.Union(seq02);
            //var Result = seq01.Concat(seq02); //Like Union but with duplication
            //  Result=Result.Distinct();// Remove duplication

            //var Result=seq01.Intersect(seq02);
            //var Result = seq01.Except(seq02);
            //foreach (var seq in Result)
            //{
            //    Console.Write($"{seq} ");
            //}
            #endregion

            #region Quantifier operators
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100); 

            //var Result = ProductList.Any();
            //Result=ProductList.Any(P=>P.UnitPrice==10);
            //Result=ProductList.Any(P=>P.UnitPrice==100);
            //Result=seq01.SequenceEqual(seq02);
            //Console.WriteLine(Result);
            #endregion

            #region Transformation operators
            //string[] Names = { "Ahmed", "Abdo", "Mano", "Moo" };
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] chars = { 'a', 'b', 'c', 'd', 'e' };

            //  var Result = NAmes.Zip(Numbers);
            // var Result = Names.Zip(Numbers, (Name, Number) =>new { index=Number,Name=Name});
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region Grouping Operators
            //var Result = from p in ProductList
            //             group p by p.Category;
            //Result = ProductList.GroupBy(P => P.Category);

            //var Result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category;
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //      .GroupBy(p => p.Category);

            //var Result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into category
            //             where category.Count()>10
            //             select category;
            //Result = ProductList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Where(p => p.Count() > 10);

            //foreach (var group in Result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach(var item in group)
            //    {
            //        Console.WriteLine($"       {item.ProductName}   ");
            //    }
            //}


            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Where(C => C.Count() > 10)
            //    .Select(X => new
            //    {
            //        Name = X.Key,
            //        Count = X.Count()
            //    });
            //Result = from P in ProductList
            //         where P.UnitsInStock > 0
            //         group P by P.Category
            //       into category
            //         where category.Count() > 10
            //         select new 
            //         {
            //             Name = category.Key,
            //            Count = category.Count(),
            //         };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Partitioning operators
            //var Result = ProductList.Where(P => P.UnitsInStock>0).Take(10);
            //  Result = ProductList.Where(P => P.UnitsInStock > 0).TakeLast(10);
            //Result=ProductList.Where(p=>p.UnitsInStock>0).Skip(10);
            //Result = ProductList.Where(p => p.UnitsInStock > 0).SkipLast(10);
            //Result = ProductList.Where(p => p.UnitsInStock > 0).Skip(10).Take(10);

            //int[] Numbers = { 3, 4, 5, 10, 12, 11, 9, 8, 7 };
            //var Result = Numbers.TakeWhile(p => p <= 10);
            //  Result = Numbers.SkipWhile(p => p <= 10);

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region Let&Into
            //string[] Names = { "Ahmed", "Abdo", "Mano", "Moonn", "Omarrr", "bahjat" };
            //var Result = from p in Names
            //             select Regex.Replace(p, "[AEIOUaeiou]", string.Empty)
            //             into nonVowel
            //             where nonVowel.Length > 3
            //             select nonVowel;

            //Result = from N in Names
            //             let nonvowel = Regex.Replace(N, "[AEIOUaeiou]", string.Empty)
            //          where nonvowel.Length > 3
            //             select nonvowel;
            //foreach (var Name in Result)
            //{
            //    Console.WriteLine(Name);
            //}

            #endregion
        }
    }
}
