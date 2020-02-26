using ShopStore.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Service.Context
{
    class ShopStoreDbContext : DbContext
    {
        public DbSet<Activity> ActivityContext { get; set; }
        public DbSet<ActivityType> ActivityTypeContext { get; set; }
        public DbSet<Brands> BrandsContext { get; set; }
        public DbSet<Colors> ColorsContext { get; set; }
        public DbSet<PriceDiscounts> PriceDiscountsContext { get; set; }
        public DbSet<Product> ProductContext { get; set; }
        public DbSet<ProductBatchDefinitions> ProductBatchDefinitionsContext { get; set; }
        public DbSet<ProductBatches> ProductBatchesContext { get; set; }
        public DbSet<ProductBatchItems> ProductBatchItemsContext { get; set; }
        public DbSet<ProductCategories> ProductCategoriesContext { get; set; }
        public DbSet<ProductDetailsTypes> ProductDetailsTypesContext { get; set; }
        public DbSet<ProductDetailsTypesDetails> ProductDetailsTypesDetailsContext { get; set; }
        public DbSet<ProductPrices> ProductPricesContext { get; set; }
        public DbSet<ProductTypes> ProductTypesContext { get; set; }
        public DbSet<Sizes> SizesContext { get; set; }
        public DbSet<Units> UnitsContext { get; set; }
        public DbSet<Articles> ArticlesContext { get; set; }
        public DbSet<FAQs> FAQsContext { get; set; }
        public DbSet<ProductComments> ProductCommentsContext { get; set; }
        public DbSet<ContactUs> ContactUsContext { get; set; }
        public DbSet<Cities> CitiesContext { get; set; }
        public DbSet<Country> CountryContext { get; set; }
        public DbSet<Loggers> LoggersContext { get; set; }
        public DbSet<MailingLists> MailingListsContext { get; set; }
        public DbSet<Stock> StockContext { get; set; }
        public DbSet<StockHistory> StockHistoryContext { get; set; }
        public DbSet<Warehouse> WarehouseContext { get; set; }
        public DbSet<Order> OrderContext { get; set; }
        public DbSet<OrderAddress> OrderAddressContext { get; set; }
        public DbSet<OrderHistory> OrderHistoryContext { get; set; }
        public DbSet<OrderItem> OrderItemContext { get; set; }
        public DbSet<Payment> PaymentContext { get; set; }
        public DbSet<PaymentDetails> PaymentDetailsContext { get; set; }
        public DbSet<PaymentProvider> PaymentProviderContext { get; set; }
        public DbSet<Vendor> VendorContext { get; set; }
        public DbSet<VendorCategory> VendorCategoryContext { get; set; }
        public DbSet<WishList> WishListContext { get; set; }
        public DbSet<WishListItem> WishListItemContext { get; set; }
        public DbSet<Shipment> ShipmentContext { get; set; }
        public DbSet<ShipmentItem> ShipmentItemContext { get; set; }
        public DbSet<Review> ReviewContext { get; set; }
        public DbSet<Reply> ReplyContext { get; set; }
        public DbSet<Address> AddressContext { get; set; }
        public DbSet<CustomerGroup> CustomerGroupContext { get; set; }
        public DbSet<CustomerGroupUser> CustomerGroupUserContext { get; set; }
        public DbSet<Role> RoleContext { get; set; }
        public DbSet<UserAddress> UserAddressContext { get; set; }
        public DbSet<User> UserContext { get; set; }
        public DbSet<UserRole> UserRoleContext { get; set; }
       }

}
