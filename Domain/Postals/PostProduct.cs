﻿using Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Postals
{
   public class PostProduct
    {
        public int Id { get; set; }
        public string AdminUserId { get; set; }
        public PostalCompany PostalCompane { get; set; }
        public string TrackingNumber { get; set; }
        public PostalType PostalType { get; set; }
        public PostalStatus PostalStatus { get; set; }
        public Order.Order Order { get;  set; }
        public int OrderId { get;  set; }
        public string PostOfficeName { get;  set; }
        public DateTime InsertDate { get; set; }
        public DateTime ReciveDate { get; set; } 
    }
    public enum PostalType
    {
        /// <summary>
        /// مرجوع و دریافت محصول
        /// </summary>
        ResivetPostal = 0,
        /// <summary>
        ///  ارسال محصول
        /// </summary>
        SendPoatal = 1,


    }
    public enum PostalCompany
    {
        /// <summary>
        /// الوپیک
        /// </summary>
        alopeyk = 1,
        /// <summary>
        ///  تیپاکس
        /// </summary>
        tipax = 2,
        /// <summary>
        ///  پست ایران
        /// </summary>
        post_ir = 3,


    }
    public enum PostalStatus
    {
        /// <summary>
        /// منتظر تحویل به کارمند پست
        /// </summary>
        WaitingForPost = 0,
        /// <summary>
        ///  تحویل  کارمند پست شد
        /// </summary>
        Parid = 1,
        /// <summary>
        /// تحویل انجام شد
        /// </summary>
        Delivered = 2,
        /// <summary>
        /// مشتری یافت نشد
        /// </summary>
        NotFountAdress = 3

    }
}
