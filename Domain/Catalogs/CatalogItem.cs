using Domain.Attributes;
using Domain.Discounts;
using Domain.Order;
using System.Collections.Generic;

namespace Domain.Catalogs
{
    [Auditable]
    public class CatalogItem
    {
        public CatalogItem(int pris , string name , string descript , string slug
            , int catalogCompanyId , int catalogTypeId , int catalogBrandId , int catologCarId, int availableStock
            , int restockThreshold, int maxStockThreshold)
        {
            this._price = pris;
            this.Name = name;
            this.Description = descript;
            this.Slug = slug;
            this.CatalogCompanyId = catalogCompanyId;
            this.CatalogTypeId = catalogTypeId;
           this.CatalogBrandId =catalogBrandId;
            this.AvailableStock = availableStock;
            this.MaxStockThreshold = maxStockThreshold;
            this.RestockThreshold = restockThreshold;
            this.CatologCarId = catologCarId;
        }
        public CatalogItem()
        {

        }
        private int _price = 0;
        private int? _oldPrice = null;


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Slug { get; set; }

        public int Price
        {
            get
            {
                return GetPrice();
            }
            set
            {
                Price =  _price;
            }
        }
        public int? OldPrice
        {
            get
            {
                return _oldPrice;
            }
            set
            {
                OldPrice = _oldPrice;
            }
        }
        public int?  PercentDiscount { get; set; }
        public int CatalogCompanyId { get; set; }
        public CatalogCompany CatalogCompany { get; set; }
        public int CatalogTypeId { get; set; }
        public CatalogType CatalogType { get; set; }
        public int CatalogBrandId { get; set; }
        public CatalogBrand CatalogBrand { get; set; }

        public int CatologCarId { get; set; }
        public CatologCar CatologCar { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }
        public int VisitCount { get; set; } = 0;
        public ICollection<CatalogItemFeature> CatalogItemFeatures { get; set; }
        public ICollection<CatalogItemImage> CatalogItemImages { get; set; }
        public ICollection<Discount> Discounts { get; set; }
        public ICollection<CatalogItemFavourite> CatalogItemFavourites { get; set; }
        public ICollection<OrderItem>  OrderItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetPrice()
        {
            var dis = GetPreferredDiscount(Discounts, _price);
            if (dis != null)
            {
                var discountAmount = dis.GetDiscountAmount(_price);
                int newPrice = _price - discountAmount;
                _oldPrice = _price;
                PercentDiscount = (discountAmount * 100) / _price;
                return newPrice;
            }
            return _price;
        }

        /// <summary>
        /// دریافت بیشترین تخفیف
        /// </summary>
        /// <param name="discounts"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        private Discount GetPreferredDiscount(ICollection<Discount> discounts, int price)
        {
            Discount preferredDiscount = null;
            decimal? maximumDiscountValue = null;
            if (discounts != null)
            {
                foreach (var discount in discounts)
                {
                    var currentDiscountValue = discount.GetDiscountAmount(price);
                    if (currentDiscountValue != decimal.Zero)
                    {
                        if (!maximumDiscountValue.HasValue || currentDiscountValue > maximumDiscountValue)
                        {
                            maximumDiscountValue = currentDiscountValue;
                            preferredDiscount = discount;
                        }
                    }
                }
            }

            return preferredDiscount;
        }
    }
}
