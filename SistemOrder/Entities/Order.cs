﻿using System;
using System.Collections.Generic;
using System.Text;
using SistemOrder.Entities.Enums;

namespace SistemOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}