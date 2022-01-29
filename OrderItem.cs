using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItem
    {
        string productName;
        public string ProductName
        {
            get
            {
                return productName;
            }

        }
        int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
        }
        decimal unitPrice;
        public decimal UnitPrice => unitPrice;

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public virtual decimal GetValue()
        {
            return quantity * unitPrice;
        }
        public override string ToString()
        {
            return $"{productName}, cena: {unitPrice} PLN, {quantity} szt, {GetValue()} PLN";
        }
    }
}