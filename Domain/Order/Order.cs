﻿using Domain.Attributes;
using Domain.Catalogs;
using Domain.Discounts;
using Domain.Payments;
using Domain.Postals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Order
{
    [Auditable]
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; private set; }
        public DateTime OrderDate { get; private set; } = DateTime.Now;
        public Address Address { get; private set; }
        public string FollowKey { get; set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
        /// <summary>
        /// مبلغ تخفیف
        /// </summary>
        public decimal DiscountAmount { get; private set; }
        public Discount AppliedDiscount { get; private set; }
        public int? AppliedDiscountId { get; private set; }
        public PostProduct PostProduct { get; private set; }
        public ReturnPaymentInvoice ReturnPaymentInvoice { get; private set; }
        public DateTime ZamanSabt { get; set; } = DateTime.Now;
        public DateTime? ZamanDelivered { get; set; }


        public Order(string userId, Address address,
            List<OrderItem> orderItems,
            PaymentMethod paymentMethod
            , Discount discount)
        {
            UserId = userId;
            Address = address;
            _orderItems = orderItems;
            PaymentMethod = paymentMethod;
            if (discount != null)
            {
                ApplyDiscountCode(discount);
            }
        }

        public Order()
        {

        }



        /// <summary>
        /// پرداخت انجام شد
        /// </summary>
        public void PaymentDone()
        {
            PaymentStatus = PaymentStatus.Paid;
        }


        /// <summary>
        /// کالا تحویل داده شد
        /// </summary>
        public void OrderDelivered()
        {
            ZamanDelivered = DateTime.Now;
            OrderStatus = OrderStatus.Delivered;
        }

        /// <summary>
        /// ثبت مرجوعی کالا
        /// </summary>
        //public void OrderReturned()
        //{
        //    OrderStatus = OrderStatus.Returned;
        //}
        /// <summary>
        /// سفر
        /// سفارش لغو شد
        /// </summary>
        public void OrderCancelled()
        {
            OrderStatus = OrderStatus.Cancelled;
        }

        /// <summary>
        /// پرداخت لغو شد
        /// </summary>
        public void PaymentCanceled()
        {
            PaymentStatus = PaymentStatus.Canceled;
        }
        /// <summary>
        /// لغو سفارش
        /// </summary>
        //public void OrderCancelled()
        //{
        //    OrderStatus = OrderStatus.Cancelled;
        //}
        /// <summary>
        /// درخواست مرجوعی سفارش
        /// </summary>
        //public void OrderRequestReturned()
        //{
        //    OrderStatus = OrderStatus.RequestReturned;
        //}
        /// <summary>
        /// درخواست لغو سفارش
        /// </summary>
        //public void OrderRequestCancelled()
        //{
        //    OrderStatus = OrderStatus.RequestCancelled;
        //}
        public void OrderPostOfficalDelivered()
        {
            OrderStatus = OrderStatus.PostOfficalDelivered;
        }
        public int TotalPrice()
        {
            int totalPrice = _orderItems.Sum(p => p.UnitPrice * p.Units);
            if (AppliedDiscount != null)
            {
                totalPrice -= AppliedDiscount.GetDiscountAmount(totalPrice);
            }
            return totalPrice;
        }
        public int TotalPriceWithPostalDelivery()
        {
            int totalPrice = _orderItems.Sum(p => p.UnitPrice * p.Units);
            if (AppliedDiscount != null)
            {
                totalPrice -= AppliedDiscount.GetDiscountAmount(totalPrice);
            }
            var postmony =60000;
            if (totalPrice < 400000)
            {
                postmony = 60000;
            }
            else if (totalPrice > 400000 && totalPrice < 600000)
            {
                postmony = 50000;
            }
            else if (totalPrice > 600000 && totalPrice < 800000)
            {
                postmony = 40000;
            }
            else if (totalPrice > 800000 && totalPrice < 1000000)
            {
                postmony = 25000;
            }
            else if (totalPrice > 1000000)
            {
                postmony = 0;
            }
            totalPrice = totalPrice + postmony;
            return totalPrice;
        }

        /// <summary>
        /// دریافت مبلغ کل بدون در نظر گرفتن کد تخفیف
        /// </summary>
        /// <returns></returns>
        public int TotalPriceWithOutDiescount()
        {
            int totalPrice = _orderItems.Sum(p => p.UnitPrice * p.Units);
            return totalPrice;
        }

        public void ApplyDiscountCode(Discount discount)
        {
            this.AppliedDiscount = discount;
            this.AppliedDiscountId = discount.Id;
            this.DiscountAmount = discount.GetDiscountAmount(TotalPrice());
        }

    }


    [Auditable]
    public class OrderItem
    {
        public int Id { get; set; }
        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUri { get; private set; }
        public int UnitPrice { get; private set; }
        public int Units { get; private set; }
        public OrderItemStatus OrderItemStatus { get; private set; }
        public OrderItem(int catalogItemId, string productName, string pictureUri, int unitPrice, int units)
        {
            CatalogItemId = catalogItemId;
            ProductName = productName;
            PictureUri = pictureUri;
            UnitPrice = unitPrice;
            Units = units;
        }

        /// <summary>
        /// ثبت مرجوعی کالا
        /// </summary>
        public void OrderItemReturned()
        {
            OrderItemStatus = OrderItemStatus.Returned;
        }
        /// <summary>
        /// ثبت مرجوعی کالا
        /// </summary>
        public void OrderItemSelered()
        {
            OrderItemStatus = OrderItemStatus.Selered;
        }
        //ef core
        public OrderItem()
        {

        }
    }

    public class Address
    {
        public string State { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string PostalAddress { get; private set; }
        public string ReciverName { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address(string city, string state, string zipCode, string postalAddress ,string phoneNumber)
        {
            this.City = city;
            State = state;
            ZipCode = zipCode;
            PostalAddress = postalAddress;
            PhoneNumber = phoneNumber;
        }
    }

    public enum OrderItemStatus
    {
        /// <summary>
        /// خریداری شده
        /// </summary>
        Selered = 0,
        /// <summary>
        /// مرجوع شده
        /// </summary>
        Returned = 1,
    }
    public enum PaymentMethod
    {
        /// <summary>
        /// پرداخت آنلاین
        /// </summary>
        OnlinePaymnt = 0,
        /// <summary>
        /// پرداخت در محل
        /// </summary>
        PaymentOnTheSpot = 1,
    }

    public enum PaymentStatus
    {
        /// <summary>
        /// منتظر پرداخت
        /// </summary>
        WaitingForPayment = 0,
        /// <summary>
        /// پرداخت انجام شد
        /// </summary>
        Paid = 1,
        /// <summary>
        /// پرداخت لغو شد
        /// </summary>
        Canceled = 2,
    }

    public enum OrderStatus
    {

        /// <summary>
        /// در حال پردازش
        /// </summary>
        Processing = 0,
        /// <summary>
        /// تحویل داده شد
        /// </summary>
        Delivered = 1,
        /// <summary>
        ///تحویل مامور پست گردید 
        /// </summary>
        PostOfficalDelivered = 2,
        /// <summary>
        /// در حال پردازش
        /// </summary>
        Cancelled = 3,
    }

}
