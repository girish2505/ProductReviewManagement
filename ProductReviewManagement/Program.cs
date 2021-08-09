using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Product Review Management");
            List<ProductReview> products = new List<ProductReview>();
            ProductReviewManager.AddProductReview(products);
        }
    }
}
