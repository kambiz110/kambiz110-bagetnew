using Domain.Attributes;
using Domain.Catalogs;
using Domain.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Baskets
{
    [Auditable]
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; private set; }
        private readonly List<BasketItem> _items = new List<BasketItem>();

        /// <summary>
        /// مبلغ تخفیف
        /// </summary>
        public int DiscountAmount { get; private set; } = 0;
        public Discount AppliedDiscount { get; private set; }
        public int? AppliedDiscountId { get; private set; }


        public ICollection<BasketItem> Items => _items.AsReadOnly();
        public Basket(string buyerId)
        {
            this.BuyerId = buyerId;
        }
        /// <summary>
        /// افزودن محصول به سبد خرید
        /// </summary>
        /// <param name="catalogItemId"></param>
        /// <param name="quantity"></param>
        /// <param name="unitPrice"></param>
        public void AddItem(int catalogItemId, int quantity, int unitPrice)
        {
            if (!Items.Any(p => p.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem(catalogItemId, quantity, unitPrice));
                return;
            }
            var existingItem = Items.FirstOrDefault(p => p.CatalogItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }
        /// <summary>
        /// محاسبه قیمت محصول های موجود در سبد با اعمال تخفیف
        /// </summary>
        /// <returns></returns>
        public int TotalPrice()
        {
            int totalPrice = _items.Sum(p => p.UnitPrice * p.Quantity);
            totalPrice -= AppliedDiscount.GetDiscountAmount(totalPrice);
            return totalPrice;
        }
        /// <summary>
        /// محاسبه قیمت محصول های داخل سبد بدون اعمال تخفیف
        /// </summary>
        /// <returns></returns>
        public int TotalPriceWithOutDiescount()
        {
            int totalPrice = _items.Sum(p => p.UnitPrice * p.Quantity);
            return totalPrice;
        }
        /// <summary>
        /// اعمال تخفیف به سبد خرید
        /// </summary>
        /// <param name="discount"></param>
        public void ApplyDiscountCode(Discount discount)
        {
            this.AppliedDiscount = discount;
            this.AppliedDiscountId = discount.Id;
            this.DiscountAmount = discount.GetDiscountAmount(TotalPriceWithOutDiescount());
        }
        /// <summary>
        /// حذف تخفیف 
        /// </summary>
        public void RemoveDescount()
        {
            AppliedDiscount = null;
            AppliedDiscountId = null;
            DiscountAmount = 0;
        }

    }


    [Auditable]
    public class BasketItem
    {
        public int Id { get; set; }
        public int UnitPrice { get; private set; }
        /// <summary>
        /// تعداد محصول
        /// </summary>
        public int Quantity { get; private set; }
        public int CatalogItemId { get; private set; }
        public CatalogItem CatalogItem { get; private set; }
        public int BasketId { get; private set; }
        public BasketItem(int catalogItemId, int quantity, int unitPrice)
        {
            CatalogItemId = catalogItemId;
            UnitPrice = unitPrice;
            SetQuantity(quantity);
        }
        /// <summary>
        /// افزودن و یا کاهش تعداد محصول انتخابی
        /// </summary>
        /// <param name="quantity"></param>
        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }
        /// <summary>
        /// مقدار دهی تعداد محصول
        /// </summary>
        /// <param name="quantity"></param>
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
