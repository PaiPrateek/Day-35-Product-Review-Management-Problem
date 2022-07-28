using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductManagement
    {
        //Top 3 Records of High Rating
        public static void Top3Records(List<ProductReview> Product)
        {
            var result = (from PM in Product orderby PM.Rating descending select PM).Take(3);
            Console.WriteLine("\nTop 3 Records are :");
            foreach(ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating + 
                                    "\nReview: "+ pm.Review +
                                    "\nIS Liked : "+pm.isLike);
            }
        }
        //Retrieve all records who's Rating is Greater that 3 and Product ID is 1 or 4 or 9
        public static void RetriveAllRecordWhosRatingGreaterThan3(List<ProductReview> Product)
        {
            var result = (from PM in Product where (PM.ProductId > 3) && (PM.ProductId == 1 || PM.ProductId == 4 || PM.ProductId == 9) select PM).ToList();
            Console.WriteLine("\nRetrieve all records who's Rating is Greater than 3 and Product ID is 14 or 4 or 9 :");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating +
                                    "\nReview: " + pm.Review +
                                    "\nIS Liked : " + pm.isLike);
            }

        }
        //Retrieve count of review present for each Product ID
        public static void RetrieveCountofReviewForEachProiductId(List<ProductReview> Product)
        {
            var result = Product.GroupBy(P=> P.ProductId).Select(Pi=> new { ProductId = Pi.Key, count = Pi.Count() });
            Console.WriteLine("\nRetrieve count of review present for each Product ID :");
            foreach (var pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nReview Count : " + pm.count );
            }
        }

        //Retrieve only Product Id and Review 
        public static void RetrieveOnlyProductIdAndReview(List<ProductReview> Product)
        {
            var result = (from PM in Product orderby PM.ProductId select PM).ToList();
            Console.WriteLine("\nRetrieve only Product Id and Review :");
            foreach (var pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nReview : " + pm.Review);
            }

        }
        //Skip Top 5 Records 
        public static void SkipTop5Records(List<ProductReview> Product)
        {
            var result = (from PM in Product select PM).Skip(5);
            Console.WriteLine("\nSkipping Top 5 Records :");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating +
                                    "\nReview: " + pm.Review +
                                    "\nIS Liked : " + pm.isLike);
            }
        }
        //Retrieve only Product ID and Review
        public static void RetrieveOnlyProductIdandReview(List<ProductReview> Product)
        {
            var result = (from PM in Product select PM);
            Console.WriteLine("\nRetrieve product ID and Review:");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nReview: " + pm.Review );
            }
        }

        //Create DataTable and Add 25 dafault values
        public static void CreateDataTableAndAddDefault25VAlues()
        {
            Console.WriteLine("Creating DataTable and Adding 25 dafault values");
            List<ProductReview> DataTable = new List<ProductReview>
                {
                new ProductReview() { ProductId = 12, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 16, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 35, UserId = 111, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 167, Rating = 5, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 15, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 96, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 10, UserId = 16, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 126, UserId = 111, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 100, UserId = 178, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 123, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 18, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 11, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 5, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 40, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 11, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 30, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 50, UserId = 11, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 60, UserId = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 19, Rating = 1, Review = "Nice", isLike = true }
            };
            foreach(var datatable in DataTable)
            {
                Console.WriteLine("\nProduct ID: " + datatable.ProductId +
                                    "\nUser ID: " + datatable.UserId +
                                    "\nRating: " + datatable.Rating +
                                    "\nReview: " + datatable.Review +
                                    "\nIS Liked : " + datatable.isLike);
            }
        }
    }
}
