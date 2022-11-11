using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-1 Create a Review Class
            Console.WriteLine("Welcom to Product Review Management Problem Statement");
            List<Productreview> productreviewlist = new List<Productreview>()
            {

                new Productreview() { ProductID = 1, UserID = 1, Rating = 2, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 2, UserID = 2, Rating = 3, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 3, UserID = 3, Rating = 4.2, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 4, UserID = 4, Rating = 2, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 5, UserID = 5, Rating = 5.5, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 6, UserID = 1, Rating = 2, Review = "Bad", is_Like = true },
                new Productreview() { ProductID = 1, UserID = 2, Rating = 3, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 11, UserID = 3, Rating = 1, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 10, UserID = 4, Rating = 2, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 12, UserID = 5, Rating = 3, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 13, UserID = 1, Rating = 2, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 14, UserID = 2, Rating = 3, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 15, UserID = 3, Rating = 4, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 16, UserID = 4, Rating = 2, Review = "nice", is_Like = true },

            };
            //Console.WriteLine("Number of Rows in the Table");
            //foreach(var list in productreviewlist)
            //{
            //    Console.WriteLine("ProductID:-" +list.ProductID+ " " +"UserID:-"+list.UserID+" "+"Rating:-"+list.Rating+" "+"Review:-"+list.Review+" "+"is_Like:-"+list.is_Like);

           // }

            Management management = new Management();
            management.Top3Records(productreviewlist);

            Console.ReadLine();
        }
    }
}
