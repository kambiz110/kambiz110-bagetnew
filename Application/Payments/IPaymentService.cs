using Application.Interfaces.Contexts;
using Domain.Order;
using Domain.Payments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Payments
{
    public interface IPaymentService
    {
        PaymentOfOrderDto PayForOrder(int OrderId);
        PaymentDto GetPayment(Guid Id);
        PaymentToCheckoutPageDto GetPaymentWithOrderForCheckoutPage(string Id, string userId);
        bool VerifyPayment(Guid Id, string Authority, long RefId);

    }

    public class PaymentService : IPaymentService
    {
        private readonly IDataBaseContext context;
        private readonly IIdentityDatabaseContext identityContext;
        public PaymentService(IDataBaseContext context, IIdentityDatabaseContext identityDatabaseContext)
        {
            this.context = context;
            identityContext = identityDatabaseContext;
        }

        public PaymentDto GetPayment(Guid Id)
        {
            var payment = context.Payments
                 .Include(p => p.Order)
                 .ThenInclude(p => p.OrderItems)
                 .Include(p=> p.Order)
                 .ThenInclude(p=> p.AppliedDiscount)
                 .SingleOrDefault(p => p.Id == Id);

            var user = identityContext.Users.SingleOrDefault(p => p.Id == payment.Order.UserId);

            string description = $"پرداخت سفارش شماره {payment.OrderId} " + Environment.NewLine;
            description += "محصولات" + Environment.NewLine;
            foreach (var item in payment.Order.OrderItems.Select(p => p.ProductName))
            {
                description += $" -{item}";
            }

            PaymentDto paymentDto = new PaymentDto
            {
                Amount = payment.Order.TotalPriceWithPostalDelivery(),
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Userid = user.Id,
                Id = payment.Id,
                Description = description,
            };
            return paymentDto;
        }

        public PaymentToCheckoutPageDto GetPaymentWithOrderForCheckoutPage(string Id ,string userId)
        {
            var user = identityContext.Users.SingleOrDefault(p => p.Id == userId);
            if (user!=null )
            {
                var payment = context.Payments.Where(p => p.Id == new Guid(Id) && p.IsPay == false )
                 .Include(p => p.Order).FirstOrDefault();
                if (payment.Order.UserId==user.Id)
                {
                    return new PaymentToCheckoutPageDto { 
                    payAddress=new PayAddress() {
                        City= payment.Order.Address.City,
                        PhoneNumber= payment.Order.Address.PhoneNumber,
                    PostalAddress= payment.Order.Address.PostalAddress,
                        ReciverName= payment.Order.Address.ReciverName }
                    ,Amount= payment.Amount,
                    Id=payment.Id,
                     Userid=user.Id
                    
                    };
                }
                return null;
            }


            return null;
        }

        /// <summary>
        /// ثبت برای ارسال به درگاه پرداخت
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public PaymentOfOrderDto PayForOrder(int OrderId)
        {
            var order = context.Orders
                    .Include(p => p.OrderItems)
                    .Include(p=>p.AppliedDiscount)
                    .SingleOrDefault(p => p.Id == OrderId);
            if (order == null)
                throw new Exception("");
            var payment = context.Payments.SingleOrDefault(p => p.OrderId == order.Id);

            if (payment == null)
            {
                payment = new Payment(order.TotalPriceWithPostalDelivery(), order.Id);
                context.Payments.Add(payment);
                context.SaveChanges();
            }

            return new PaymentOfOrderDto()
            {
                Amount = payment.Amount,
                PaymentId = payment.Id,
                PaymentMethod = order.PaymentMethod,
            };


        }
        /// <summary>
        /// ثبت نهایی خرید
        /// </summary>
        /// <param name="Id">شناسه یکتای خرید</param>
        /// <param name="Authority">از بانک دریافت می شود</param>
        /// <param name="RefId">از بانک در یافت می شود</param>
        /// <returns></returns>
        public bool VerifyPayment(Guid Id, string Authority, long RefId)
        {
            var payment = context.Payments
       .Include(p => p.Order)
       .SingleOrDefault(p => p.Id == Id);

            if (payment == null)
                throw new Exception("payment not found");

            payment.Order.PaymentDone();
            payment.PaymentIsDone(Authority, RefId);

            context.SaveChanges();
            return true;
        }
    }



    public class PaymentOfOrderDto
    {
        public Guid PaymentId { get; set; }
        public int Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    /// <summary>
    /// اطلاعات لازم برای درگاه زرین پال
    /// </summary>
    public class PaymentDto
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public string Userid { get; set; }
    }
    public class PaymentToCheckoutPageDto
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public string Userid { get; set; }
        public PayAddress payAddress { get; set; }
    }
    public class PayAddress
    {
        public string State { get;  set; }
        public string City { get;  set; }

        public string PostalAddress { get;  set; }
        public string ReciverName { get;  set; }
        public string PhoneNumber { get;  set; }
    }
    }
