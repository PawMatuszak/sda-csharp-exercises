using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    class OrderItemWithPackage : OrderItem
    {
        string packageName;
        public string PackageName => packageName;

        decimal packagePrice;
        public decimal PackagePrice => packagePrice;

        public OrderItemWithPackage(string productName, int quantity, decimal unitPrice,
            string packageName, decimal packagePrice)
            : base(productName, quantity, unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        public override decimal GetValue()
        {
            return base.GetValue() + Quantity * packagePrice;
        }

        public override string ToString()
        {
            return $"{ProductName}, cena: {UnitPrice} PLN, opakowanie: {PackageName}, " +
                $"cena opakowania: {packagePrice} PLN, {Quantity} szt, {GetValue()} PLN";
        }
    }
}
