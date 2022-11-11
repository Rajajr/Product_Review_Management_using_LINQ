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

    }
}
