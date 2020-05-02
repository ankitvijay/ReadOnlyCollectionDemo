﻿using System.Collections.Generic;

namespace Demo.Version5
{
    public class OrderDto
    {
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }

    public class OrderItemDto
    {

        public int OrderId { get; set; }


        public string OrderName { get; set; }
    }
}
