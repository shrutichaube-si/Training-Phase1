using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Order
    {
       public int OrderNumber { get;set; }
        public String Customername { get; set; }
        public int Quantityordered { get; set; }
         private int totalprice{ get; }
                
            }
        public static void totalpricefield()
        {
           
        }


        public Order(int orderNumber, String customername, int quantityordered) {
              this.OrderNumber = orderNumber;
            this.Customername = customername;
            this.Quantityordered = quantityordered;
                
        }

    }
}
