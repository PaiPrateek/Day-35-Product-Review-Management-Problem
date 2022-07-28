using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem");

            //Adding default 25 values
            List<ProductReview> Product;
            Product = new List<ProductReview>
            {
                new ProductReview() { ProductId = 12, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 35, UserId = 111, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 167, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 16, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 15, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 96, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 50, UserId = 16, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 126, UserId = 111, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 100, UserId = 178, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 123, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 18, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 11, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 40, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 11, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 30, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 50, UserId = 11, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 60, UserId = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 19, Rating = 1, Review = "Good", isLike = true }
            };
            //Create DataTable and Add 25 dafault values
            List<ProductReview> DataTable = new List<ProductReview>
                {
                new ProductReview() { ProductId = 12, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 75, UserId = 10, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 35, UserId = 111, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 167, Rating = 5, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 108, UserId = 10, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 15, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 96, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 99, UserId = 10, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 126, UserId = 111, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 100, UserId = 178, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 123, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 18, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 39, UserId = 10, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 52, UserId = 10, Rating = 5, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 40, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 11, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 21, UserId = 10, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 30, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 50, UserId = 11, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 60, UserId = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 19, Rating = 1, Review = "Nice", isLike = true }
            };

            //Top 3 Records of High Rating
            ProductManagement.Top3Records(Product);

            //Retrieve all records who's Rating is Greater that 3 and Product ID is 1 or 4 or 9
            ProductManagement.RetriveAllRecordWhosRatingGreaterThan3(Product);

            //Retrieve count of review present for each Product ID
            ProductManagement.RetrieveCountofReviewForEachProiductId(Product);

            //Retrieve only Product Id and Review
            ProductManagement.RetrieveOnlyProductIdAndReview(Product);

            //Skip Top 5 Records 
            ProductManagement.SkipTop5Records(Product);

            //Retrieve only Product ID and Review
            ProductManagement.RetrieveOnlyProductIdandReview(Product);

            //Retrieve All Data Records who's IsLike is true
            ProductManagement.RetrieveAllRecordsOfIsLikeValues(DataTable);

            //Find Average RAting of Each Product ID
            ProductManagement.FindAverageRating(DataTable);

            //Retrieve All Data Records who's Review message contains nice
            ProductManagement.RetrieveAllRecordsWhosReviewMessageContainsNice(DataTable);

            //Retrieve all the records of User ID 10 and Order By Rating
            ProductManagement.OrderByRating(DataTable);
        }

    }
}
