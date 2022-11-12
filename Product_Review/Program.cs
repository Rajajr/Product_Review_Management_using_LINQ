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
            //UC-4 Retrieve count of review present for each productID
            Console.WriteLine("Welcom to Product Review Management Problem Statement");
            List<Productreview> productreviewlist = new List<Productreview>()
            {

                new Productreview() { ProductID = 1, UserID = 1, Rating = 3.6, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 2, UserID = 1, Rating = 3, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 3, UserID = 2, Rating = 4.2, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 2, UserID = 2, Rating = 6, Review = "Good", is_Like = true },
                new Productreview() { ProductID = 5, UserID = 3, Rating = 5.5, Review = "Good", is_Like = false },
                new Productreview() { ProductID = 5, UserID = 4, Rating = 2, Review = "Bad", is_Like = false },
                new Productreview() { ProductID = 7, UserID = 3, Rating = 3, Review = "nice", is_Like = false },
                new Productreview() { ProductID = 8, UserID = 3, Rating = 1, Review = "nice", is_Like = false },
                new Productreview() { ProductID = 9, UserID = 3, Rating = 4.5, Review = "nice", is_Like = false },
                new Productreview() { ProductID = 10, UserID = 10, Rating = 3, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 11, UserID = 10, Rating = 2, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 11, UserID = 10, Rating = 3, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 13, UserID = 10, Rating = 4, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 14, UserID = 10, Rating = 2, Review = "nice", is_Like = true },
                new Productreview() { ProductID = 15, UserID = 10, Rating = 2, Review = "nice", is_Like = true },

            };
           
            Management management = new Management();
            Console.WriteLine("Select The Programe");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1.Retrieve Top3 Records\n2:Retrieve Records\n3:Rereieve Count Of Records");
            Console.WriteLine("Enter the Number: ");
            var Option=Convert.ToInt32(Console.ReadLine());

            switch(Option)
            {
                case 1:
                    
                    management.Top3Records(productreviewlist);

                    break;

                case 2:
                    management.SelectRecords(productreviewlist);

                    break;

                case 3:

                    management.RereieveCountOfRecords(productreviewlist);
                    break;

                default:

                    Console.WriteLine("Select The Number The Within Range ");
                    break;
            }


            Console.ReadLine();
        }
    }
}
