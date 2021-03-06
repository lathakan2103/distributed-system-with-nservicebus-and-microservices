﻿using System;
using Shared.ViewModels;

namespace Shared.Commands
{
    public class ForwardOrderForShippingCommand
    {
        public Guid OrderId { get; set; }
        public OrderState State { get; set; }
        public int ProductId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
