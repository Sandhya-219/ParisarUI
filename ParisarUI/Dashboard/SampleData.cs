using System;
using System.Collections.Generic;

namespace ParisarUI.Dashboard
{
    public static class SampleData
    {
        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    CustomerName = "John",
                    Country = "India",
                    OrderDate = DateTimeOffset.Now,
                    OrderType = OrderType.Web,
                    GrossValue = 1000,
                    DiscountPercentage = 10
                },
                new Order
                {
                    CustomerName = "David",
                    Country = "USA",
                    OrderDate = DateTimeOffset.Now,
                    OrderType = OrderType.Contract,
                    GrossValue = 2000,
                    DiscountPercentage = 5
                },
                new Order
                {
                    CustomerName = "Ravi",
                    Country = "India",
                    OrderDate = DateTimeOffset.Now,
                    OrderType = OrderType.Phone,
                    GrossValue = 1500,
                    DiscountPercentage = 8
                },
                new Order
                {
                    CustomerName = "Sara",
                    Country = "UK",
                    OrderDate = DateTimeOffset.Now,
                    OrderType = OrderType.Mail,
                    GrossValue = 1800,
                    DiscountPercentage = 12
                }
            };
        }
    }
}