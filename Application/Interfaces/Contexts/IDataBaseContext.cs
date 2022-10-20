using Domain.Banners;
using Domain.Baskets;
using Domain.Blogs;
using Domain.Catalogs;
using Domain.Comments;
using Domain.Discounts;
using Domain.Logs;
using Domain.Nazarats;
using Domain.Order;
using Domain.Payments;
using Domain.Postals;
using Domain.Tickets;
using Domain.Users;
using Domain.Visitors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<CatalogItemImage> CatalogItemImage { get; set; }
        DbSet<CatologCar> CatologCars { get; set; }
        DbSet<CatalogItemFeature> CatalogItemFeatures { get; set; }
        DbSet<CatalogCompany> CatalogCompanes { get; set; }
        DbSet<CatalogBrand> CatalogBrands { get; set; }
        DbSet<CatalogType> CatalogTypes { get; set; }
        DbSet<CatalogItem> CatalogItems { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<UserAddress> UserAddresses { get; set; }
        DbSet<CatalogTypeImage> CatalogTypeImages { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Discount> Discount { get; set; }
        DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        DbSet<CatalogItemFavourite> CatalogItemFavourites { get; set; }
        DbSet<Banner> Banners { get; set; }
        DbSet<Storeroom> Storerooms { get; set; }
        DbSet<PostProduct> PostProducts { get; set; }
        DbSet<SmsCode> SmsCodes { get; set; }
        DbSet<Nazarat> Nazarats { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        DbSet<Returned> Returneds { get; set; }
        DbSet<ReturnedProduct> ReturnedProducts { get; set; }
        DbSet<ReturneOrderItem> ReturneOrderItems { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<MonthLog> MonthLogs { get; set; }
        DbSet<Visitor> Visitors { get; set; }
        DbSet<UserLog> UserLogs { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<Domain.Payments.ReturnPaymentInvoice> ReturnPaymentInvoices { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        EntityEntry Entry([NotNullAttribute] object entity);
    }
}
