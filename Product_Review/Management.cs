using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    public class Management
    {
        public readonly DataTable datatable = new DataTable();
        private object x;

        //creating a method
        public void Top3Records(List<Productreview>listproductreview)
        {
            var recordedData = (from Productreviews in listproductreview
                                orderby Productreviews.Rating descending
                                select Productreviews).Take(3);

            Console.WriteLine("Top Three Records : ");
            
            foreach(var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + 
                                     "Review:-" + list.Review + " " + "is_Like:-" + list.is_Like);
                Console.WriteLine("------------------------------------------------------------------------------------------------");
            }
        }
        public void SelectRecords(List<Productreview> listproductreview)
        {
            var ProductData = from Productreviews in listproductreview
                               where (Productreviews.ProductID==1 || Productreviews.ProductID==4 || Productreviews.ProductID==9)
                               && Productreviews.Rating>3
                               select Productreviews;

            Console.WriteLine("Retrieving Record Who's Rating Greater Then 3 :");

            foreach (var list in ProductData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " +
                                     "Review:-" + list.Review + " " + "is_Like:-" + list.is_Like);
                Console.WriteLine("------------------------------------------------------------------------------------------------");
            }

        }

        public void RereieveCountOfRecords(List<Productreview> listproductreview)
        {
            var ProductData = listproductreview.GroupBy (x => x.ProductID).Select( x=> new { ProductID = x.Key, Count=x.Count() });

            foreach (var list in ProductData)
            {
                Console.WriteLine(list.ProductID+"------"+list.Count);
                Console.WriteLine("------------------------------------------------------------------------------------------------");
            }

        }
    }
}
