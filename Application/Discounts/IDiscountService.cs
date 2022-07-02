using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Discounts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
    public interface IDiscountService
    {
        /// <summary>
        /// بدست آوردن محصول ها با شرط جستجو
        /// </summary>
        /// <param name="searchKey">عبارت جستجو</param>
        /// <returns></returns>
         List<CatlogItemDto> GetCatalogItems(string searchKey, int categoryId, int brandId);
        /// <summary>
        /// اعمال تخفیف روی محصول های سبد خرید
        /// </summary>
        /// <param name="CoponCode"></param>
        /// <param name="BasketId"></param>
        /// <returns></returns>
        bool ApplyDiscountInBasket(string CoponCode, int BasketId);
        /// <summary>
        /// حذف تخفیف برای سبد خرید
        /// </summary>
        /// <param name="BasketId"></param>
        /// <returns></returns>
        bool RemoveDiscountFromBasket(int BasketId);
        /// <summary>
        /// اعتبار سنجی کد تخفیف
        /// </summary>
        /// <param name="couponCode">عبارت کوپن</param>
        /// <param name="user">کاربر</param>
        /// <returns></returns>
        BaseDto IsDiscountValid(string couponCode, User user);
    }

    public class DiscountService : IDiscountService
    {

        private readonly IDataBaseContext context;
        private readonly IDiscountHistoryService discountHistoryService;

        public DiscountService(IDataBaseContext context
            , IDiscountHistoryService discountHistoryService)
        {
            this.context = context;
            this.discountHistoryService = discountHistoryService;
        }
        /// <summary>
        /// اعمال تخفیف روی محصول های سبد خرید
        /// </summary>
        /// <param name="CoponCode"></param>
        /// <param name="BasketId"></param>
        /// <returns></returns>
        public bool ApplyDiscountInBasket(string CoponCode, int BasketId)
        {
            var basket = context.Baskets
                .Include(p => p.Items)
                .Include(p => p.AppliedDiscount)
                .FirstOrDefault(p => p.Id == BasketId);

            var discount = context.Discount.Where(p => p.CouponCode.Equals(CoponCode))
                .FirstOrDefault();
            if (discount!=null)
            {
                basket.ApplyDiscountCode(discount);
                context.SaveChanges();
                return true;
            }

            return false;
        }
        /// <summary>
        /// بدست آوردن محصول ها با شرط جستجو
        /// </summary>
        /// <param name="searchKey">عبارت جستجو</param>
        /// <returns></returns>
        public  List<CatlogItemDto> GetCatalogItems(string searchKey, int categoryId, int brandId)
        {
            var data =  context.CatalogItems.AsQueryable();
            if (!string.IsNullOrEmpty(searchKey))
            {
                data = data.Where(p => p.Name.Contains(searchKey)).AsQueryable();
            }
            if (categoryId!=0)
            {
                data = data.Where(p => p.CatalogTypeId== categoryId).AsQueryable();
            }
            if (brandId != 0)
            {
                data = data.Where(p => p.CatalogBrandId == brandId).AsQueryable();
            }
           
                return data.OrderByDescending(p => p.Id).Take(20).Select(p => new CatlogItemDto
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToList();
           
       
        }
        /// <summary>
        /// اعتبار سنجی کد تخفیف
        /// </summary>
        /// <param name="couponCode">عبارت کوپن</param>
        /// <param name="user">کاربر</param>
        /// <returns></returns>
        public BaseDto IsDiscountValid(string couponCode, User user)
        {
            var discount = context.Discount
                .Where(p => p.CouponCode.Equals(couponCode)).FirstOrDefault();
            if (discount == null)
            {
                return new BaseDto(IsSuccess: false,
                    Message: new List<string> { "کد تخفیف معتبر نمی باشد" });
            }

            var now = DateTime.UtcNow;
            if (discount.StartDate.HasValue)
            {
                var startDate = DateTime.SpecifyKind(discount.StartDate.Value, DateTimeKind.Utc);
                if (startDate.CompareTo(now) > 0)
                    return new BaseDto(false, new List<string>
                    { "هنوز زمان استفاده از این کد تخفیف فرا نرسیده است" });
            }
            if (discount.EndDate.HasValue)
            {
                var endDate = DateTime.SpecifyKind(discount.EndDate.Value, DateTimeKind.Utc);
                if (endDate.CompareTo(now) < 0)
                    return new BaseDto(false, new List<string> { "کد تخفیف منقضی شده است" });
            }

            var checkLimit = CheckDiscountLimitations(discount, user);

            if (checkLimit.IsSuccess == false)
                return checkLimit;
            return new BaseDto(true, null);

        }

        /// <summary>
        /// چک کردن محدودیت استفاده از کوپن تخفیف
        /// </summary>
        /// <param name="discount">تخفیف</param>
        /// <param name="user">کاربر</param>
        /// <returns></returns>
        private BaseDto CheckDiscountLimitations(Discount discount, User user)
        {
            switch (discount.DiscountLimitation)
            {
                case DiscountLimitationType.Unlimited:
                    {
                        return new BaseDto(true, null);
                    }
                case DiscountLimitationType.NTimesOnly:
                    {
                        var totalUsage = discountHistoryService.GetAllDiscountUsageHistory(discount.Id, null, 0, 1).Data.Count();
                        if (totalUsage < discount.LimitationTimes)
                        {
                            return new BaseDto(true, null);

                        }
                        else
                        {
                            return new BaseDto(false, new List<string> { "ظرفیت استفاده از این کد تخفیف تکمیل شده است" });

                        }
                    }
                case DiscountLimitationType.NTimesPerCustomer:
                    {
                        if (user != null)
                        {
                            var totalUsage = discountHistoryService.GetAllDiscountUsageHistory(discount.Id, user.Id, 0, 1).Data.Count();
                            if (totalUsage < discount.LimitationTimes)
                            {
                                return new BaseDto(true, null);
                            }
                            else
                            {
                                return new BaseDto(false, new List<string> { "تعدادی که شما مجاز به استفاده از این تخفیف بوده اید به پایان رسیده است" });
                            }
                        }
                        else
                        {
                            return new BaseDto(true, null);
                        }
                    }
                default:
                    break;
            }
            return new BaseDto(true, null);

        }
        /// <summary>
        /// حذف تخفیف برای سبد خرید
        /// </summary>
        /// <param name="BasketId"></param>
        /// <returns></returns>
        public bool RemoveDiscountFromBasket(int BasketId)
        {
            var basket = context.Baskets.Find(BasketId);

            basket.RemoveDescount();
            context.SaveChanges();
            return true;
        }
    }

    public class CatlogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
