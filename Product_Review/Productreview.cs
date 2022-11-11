using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    public class Productreview
    {
        public int ProductID 
        { 
            get; 
            set; 
        }
        public int UserID
        {
            get;
            set;
        }
        public double Rating
        {
            get;
            set;
        }
        public string Review
        {
            get;
            set;
        }
        public bool is_Like
        {
            get;
            set;
        }
    }
}
