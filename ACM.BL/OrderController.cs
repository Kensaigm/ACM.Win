﻿using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderController
    {
        private CustomerRepository customerRepository { get; set; }

        private OrderRepository orderRepository { get; set; }

        private InventoryRepository inventoryRepository { get; set; }

        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }

        public OperationResult PlaceOrder(Customer customer,
                                Order order,
                                Payment payment,
                                bool allowSplitOrders, bool emailReceipt )
        {
            if (customer == null) throw new ArgumentException("Customer instance is null");
            if (order == null) throw new ArgumentException("Order instance is null");
            if (payment == null) throw new ArgumentException("Payment instance is null");

            var op = new OperationResult();

            customerRepository.Add(customer);

            orderRepository.Add(order);
            
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmail();
                if (result.Success)
                {
                    customerRepository.Update();

                    emailLibrary.SendEmail(customer.EmailAddress,
                                        "Here is your receipt");
                }
                else
                {
                    // log the message
                }
                
            }
            return op;
        }
    }
}
