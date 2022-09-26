using Application.Interfaces.Contexts;
using Domain.Attributes;
using Domain.Banners;
using Domain.Baskets;
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
using Persistence.EntityConfigurations;
using Persistence.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<CatalogItemImage> CatalogItemImage { get; set; }
        public DbSet<CatologCar> CatologCars { get; set; }
        public DbSet<CatalogCompany> CatalogCompanes { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogItemFeature> CatalogItemFeatures { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<DiscountUsageHistory>  DiscountUsageHistories { get; set; }
        public DbSet<CatalogItemFavourite>   CatalogItemFavourites { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<CatalogTypeImage>  CatalogTypeImages { get; set; }
        public DbSet<Storeroom>  Storerooms { get; set; }
        public DbSet<PostProduct> PostProducts { get; set; }
        public DbSet<SmsCode> SmsCodes { get; set; }
        public DbSet<Nazarat> Nazarats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Returned> Returneds { get; set; }
        public DbSet<ReturnedProduct> ReturnedProducts { get; set; }
        public DbSet<ReturneOrderItem> ReturneOrderItems { get; set; }
        public DbSet<ReturnPaymentInvoice> ReturnPaymentInvoices { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MonthLog> MonthLogs { get; set; }
        public DbSet<DayLog> DayLogs { get; set; }
        
        public DbSet<Visitor> Visitors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>(b =>
            {
                b.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(3030, 1);
            });
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute), true).Length > 0)
                {
                    builder.Entity(entityType.Name).Property<DateTime>("InsertTime").HasDefaultValue(DateTime.Now);
                    builder.Entity(entityType.Name).Property<DateTime?>("UpdateTime");
                    builder.Entity(entityType.Name).Property<DateTime?>("RemoveTime");
                    builder.Entity(entityType.Name).Property<bool>("IsRemoved").HasDefaultValue(false);
                }
            }
            builder.Entity<Payment>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<CatalogType>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<Discount>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);

            builder.Entity<CatalogItemFeature>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<BasketItem>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<Basket>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);

            builder.Entity<CatalogCompany>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);

            builder.Entity<CatalogItemFavourite>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);

            builder.Entity<PostProduct>()
    .HasOne(a => a.Order)
    .WithOne(b => b.PostProduct);
            
            builder.Entity<ReturnedProduct>()
    .HasOne(a => a.Returned)
    .WithOne(b => b.ReturnedProduct);


            builder.ApplyConfiguration(new CatalogBrandEntityTypeConfiguration());
            builder.ApplyConfiguration(new CatalogTypeEntityTypeConfiguration());

          //  DataBaseContextSeed.CatalogSeed(builder);


            //
            builder.Entity<Order>().OwnsOne(p => p.Address);

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified ||
                p.State == EntityState.Added ||
                p.State == EntityState.Deleted
                );
            foreach (var item in modifiedEntries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());
                if (entityType != null)
                {
                    var inserted = entityType.FindProperty("InsertTime");
                    var updated = entityType.FindProperty("UpdateTime");
                    var RemoveTime = entityType.FindProperty("RemoveTime");
                    var IsRemoved = entityType.FindProperty("IsRemoved");
                    if (item.State == EntityState.Added && inserted != null)
                    {
                        item.Property("InsertTime").CurrentValue = DateTime.Now;
                    }
                    if (item.State == EntityState.Modified && updated != null)
                    {
                        item.Property("UpdateTime").CurrentValue = DateTime.Now;
                    }

                    if (item.State == EntityState.Deleted && RemoveTime != null && IsRemoved != null)
                    {
                        item.Property("RemoveTime").CurrentValue = DateTime.Now;
                        item.Property("IsRemoved").CurrentValue = true;
                        item.State = EntityState.Modified;
                    }
                }

            }
            return base.SaveChanges();
        }
    }
}
