using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class news
    {
        public int OrderNo { get; set; }
        public string CustomerName { get; set; }
        public int QuantityOrder { get; set; }
        private double TotalPrice { get; }

        public news(int orderNo, string customerName, int quantityOrder)
        {
            OrderNo = orderNo;
            CustomerName = customerName;
            QuantityOrder = quantityOrder;
        }

        public double totalPrice(int QuantityOrder, double price = 19.95)
        {
            this.TotalPrice = QuantityOrder * price;
            return this.TotalPrice;
        }

        public override int GetHashCode()
        {
            return combine()
        }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Product other = obj as Product;
                if (this.OrderNo == other.OrderNo)
                {
                    return true;
                }

            }
            return false;
        }

        public override string ToString()
        {
            totalPrice(QuantityOrder);
            return $"OrderNo : {OrderNo}, CustomerName : {CustomerName}, QuantityOrder: {QuantityOrder}, TotalPrice : {TotalPrice}";
        }

    }
}
}
