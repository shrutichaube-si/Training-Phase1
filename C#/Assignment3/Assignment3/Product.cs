using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Product
    {
        public int OrderNo { get; set; }
        public string CustomerName { get; set; }
        public int QuantityOrder { get; set; }


        public Product(int orderNo, string customerName, int quantityOrder)
        {
            OrderNo = orderNo;
            CustomerName = customerName;
            QuantityOrder = quantityOrder;
        }

        public double totalPrice(int QuantityOrder, double price = 19.95)
        {
            double TotalPrice = QuantityOrder * price;
            return TotalPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderNo, OrderNo);
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
            double TotalPrice = totalPrice(QuantityOrder);
            return $"OrderNo : {OrderNo}, CustomerName : {CustomerName}, QuantityOrder: {QuantityOrder}, TotalPrice : {TotalPrice}";
        }

    }
}
    

