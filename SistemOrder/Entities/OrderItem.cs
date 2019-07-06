﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SistemOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }


        public OrderItem()
        {
        }

        public OrderItem(global::System.Int32 quantity, global::System.Double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}