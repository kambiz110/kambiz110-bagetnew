
using Application.Banners;
using Application.BasketsService;
using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalogTypes.Query;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Catalogs.GetMenuItem;
using Application.Comments.Command;
using Application.Comments.Query;
using Application.Discounts;
using Application.HomePageService;
using Application.Interfaces.Contexts;
using Application.Orders;
using Application.Orders.CustomerOrdersServices;
using Application.Payments;
using Application.ProductListPageService;
using Application.Returneds.Command;
using Application.Returneds.Query;
using Application.Tickets.Command;
using Application.Tickets.Query;
using Application.Users;
using Application.Users.Command;
using Application.Users.Token;
using Application.Visitors.SaveVisitorInfo;
using Application.Visitors.VisitorOnline;
using DNTCaptcha.Core;
using Domain.Users;
using EndPoint.Site.Useful.Ultimite;
using Infrastructure.IdentityConfigs;
using Infrastructure.MappingProfile;
using Infrastructure.SMS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Contexts;
using Persistence.Contexts.MongoContext;
using Persistence.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Configurations;
using WebSite.EndPoint.Hubs;
using WebSite.EndPoint.Utilities.Filters;
using WebSite.EndPoint.Utilities.Middlewares;

namespace WebSite.EndPoint
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSession();
            services.AddSeoTags(seoInfo =>
            {
                seoInfo.SetSiteInfo(
                    siteTitle: "لوازم یدکی خودرو زنجانی"
                );
            });

            services.AddDNTCaptcha(options =>
        options.UseCookieStorageProvider()
       .ShowThousandsSeparators(true)
        );

            #region  Connection String
            services.AddTransient<IDataBaseContext, DataBaseContext>();
            services.AddTransient<IIdentityDatabaseContext, IdentityDatabaseContext>();

            string connection = Configuration["ConnectionString:SqlServer"];
            services.AddDbContext<DataBaseContext>(option => option.UseSqlServer(connection));
            services.AddDbContext<InMemoryContext>(option => option.UseInMemoryDatabase("OnlineVisitor"));
            services.AddScoped<InMemoryContext>();

            services.AddIdentityService(Configuration);
           // services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomUserClaimsPrincipalFactory>();
            services.AddAuthorization();
            services.ConfigureApplicationCookie(option =>
            {
                option.ExpireTimeSpan = TimeSpan.FromDays(2);
                option.LoginPath = "/account/login";
                option.AccessDeniedPath = "/Account/AccessDenied";
                option.SlidingExpiration = true;
            });
            #endregion
            services.AddTransient(typeof(IMongoDbContext<>), typeof(MongoDbContext<>));
            services.AddTransient<ISaveVisitorInfoService, SaveVisitorInfoService>();
            services.AddTransient<IIVisitorOnlineService, VisitorOnlineService>();
            services.AddTransient<IGetMenuItemService, GetMenuItemService>();
            services.AddTransient<IGetCatalogIItemPLPService, GetCatalogIItemPLPService>();
            services.AddTransient<IUriComposerService, UriComposerService>();
            services.AddTransient<IGetCatalogItemPDPService, GetCatalogItemPDPService>();
            services.AddTransient<IBasketService, BasketService>();
            services.AddTransient<IUserAddressService, UserAddressService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IDiscountService, DiscountService>();
            services.AddTransient<IDiscountHistoryService, DiscountHistoryService>();
            services.AddTransient<ICatalogItemService, CatalogItemService>();
            services.AddTransient<ICustomerOrdersService, CustomerOrdersService>();
            services.AddTransient<IHomePageService, HomePageService>();
            services.AddTransient<IMenuCatolgType, MenuCatolgType>();
            services.AddTransient<IGetBanerHomePage, GetBanerHomePage>();
            services.AddTransient<IGetDiscountInHomePage, GetDiscountInHomePage>();
            services.AddTransient<IGetCatalogeTypeHomePage, GetCatalogeTypeHomePage>();
            services.AddTransient<IRenderCategoriesMenuService, RenderCategoriesMenuService>();
            services.AddTransient<IRightSildMultiEntityFilter, RightSildMultiEntityFilter>();
            services.AddTransient<IGetCategoreTypeHeaderSearchKey, GetCategoreTypeHeaderSearchKey>();
            services.AddTransient<ILoginWithSmsCodeServices, LoginWithSmsCodeServices>();
            services.AddTransient<ISmsServices, SmsServices>();
            services.AddTransient<IGeneritTokenUser, GeneritTokenUser>();
            services.AddTransient<IReturnedOrderItemService, ReturnedOrderItemService>();
            services.AddTransient<IReturnedForCustomerService, ReturnedForCustomerService>();
            services.AddTransient<IAddTicketService, AddTicketService>();
            services.AddTransient<ICustomerGetTickets, CustomerGetTickets>();
            services.AddTransient<IAddCommentService, AddCommentService>();
            services.AddTransient<IGetCommentForView, GetCommentForView>();
            services.AddScoped<SaveVisitorFilter>();

            services.AddSignalR();

            //mapper
            services.RegisterAutoMapper();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Seed data on application startup
            //using (var serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    var dbContext = serviceScope.ServiceProvider.GetRequiredService<DataBaseContext>();
            //    var identityDatabase = serviceScope.ServiceProvider.GetRequiredService<IdentityDatabaseContext>();
            //    dbContext.Database.Migrate();
            //    identityDatabase.Database.Migrate();
            //    new ApplicationDbContextSeeder().SeedAsync(dbContext, identityDatabase, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            //}
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSetVisitorId();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                              name: "default",
                              pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
              name: "ProductDetails",
              pattern: "product/{car}/{catalogtype}/pid-{id}/{slug?}",
                defaults: new { controller = "product", action = "Details" });

                endpoints.MapHub<OnlineVisitorHub>("/chathub");
            });
        }
    }
}
