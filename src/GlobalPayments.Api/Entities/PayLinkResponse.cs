﻿using GlobalPayments.Api.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPayments.Api.Entities
{
    public class PayLinkResponse
    {
        /// <summary>
        /// A unique identifier generated by Global Payments to identify the link.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A meaningful label for the merchant account set by Global Payments.
        /// </summary>
        public string AccountName;

        /// <summary>
        /// The URL that the customer should be redirected to in order to make their payment.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Indicates where a link is in its lifecycle.
        /// </summary>
        public PayLinkStatus? Status { get; set; }

        /// <summary>
        /// Describes the type of link that will be created.
        /// </summary>
        public PayLinkType? Type { get; set; }

        /// <summary>
        /// Indicates whether the link can be used once or multiple times
        /// </summary>
        public PaymentMethodUsageMode? UsageMode { get; set; }

        /// <summary>
        /// The number of the times that the link can be used or paid.
        /// </summary>
        public int UsageLimit { get; set; }

        /// <summary>
        /// Merchant defined field to reference the transaction.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// A descriptive name for the link. This will be visible to the customer on the payment page.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A detailed description of your link that will be visible to the customer on the payment page.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates if you want to capture the customers shipping information on the hosted payment page.
        /// If you enable this field you can also set an optional shipping fee in the shipping_amount.
        /// </summary>
        public bool? IsShippable { get; set; }

        /// <summary>
        /// The number of times a link has been viewed.
        /// </summary>
        public string ViewedCount { get; set; }

        /// <summary>
        /// Indicates the date and time after which the link can no longer be used or paid.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Images that will be displayed to the customer on the payment page.
        /// </summary>
        public byte[] Images { get; set; }

        public List<PaymentMethodName> AllowedPaymentMethods { get; set; }
    }
}
