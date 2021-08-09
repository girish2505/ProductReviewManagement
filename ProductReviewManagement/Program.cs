using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Product Review Management");
            Console.WriteLine("1.Adding a Prodcut Review In list");
            Console.WriteLine("2.retrive top three records");
            Console.WriteLine("3.retrive records whoes rating is greater than 7");
            Console.WriteLine("4.retrieving count grouping by Rating");
            Console.WriteLine("5.retrive id and review");
            Console.WriteLine("6.Skip top 5 records");
            Console.WriteLine("7.creating table");
            Console.WriteLine("8.retrive data using islike");
            Console.WriteLine("9.find avg for rating");
            Console.WriteLine("10.review of the product");
            Console.WriteLine("11.retrive data based on the user id and rating");
            List<ProductReview> products = new List<ProductReview>();
            int option = Convert.ToInt32(Console.ReadLine());
            ProductReviewManager.AddProductReview(products);
            switch (option)
            {
                case 1:
                    ProductReviewManager.AddProductReview(products);
                    break;
                case 2:
                    ProductReviewManager.RetrieveTopThreeRecords(products);
                    break;
                case 3:
                    ProductReviewManager.Retrieve(products);
                    break;
                case 4:
                    ProductReviewManager.RetrieveCount(products);
                    break;
                case 5:
                    ProductReviewManager.RetrieveIdAndReview(products);
                    break;
                case 6:
                    ProductReviewManager.SkipRecords(products);
                    break;
                case 7:
                    ProductTable.AddDetails(products);
                    break;
                case 8:
                    ProductTable.RetrieveBasedOnIsLike(products);
                    break;
                case 9:
                    ProductTable.AvgRating(products);
                    break;
                case 10:
                    ProductTable.Review(products);
                    break;
                case 11:
                    ProductTable.BasedOnUserId(products);
                    break;
            }
        }
    }
}
