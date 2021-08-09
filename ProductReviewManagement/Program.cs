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


            }
        }
    }
}
