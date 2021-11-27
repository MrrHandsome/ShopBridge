using Microsoft.EntityFrameworkCore;
using ShopBridge.Entities;

namespace ShopBridge.Extensions
{
    /// <summary>
    /// Shop bridge model builder extensions
    /// </summary>
    public static class ShopBridgeModelBuilderExtensions
    {
        #region Public Static Method

        /// <summary>
        /// Configure shop bridge context
        /// </summary>
        /// <param name="modelBuilder">Modelbuilder</param>
        public static void ConfigureShopBridgeContext(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(item =>
            {
                item.ToTable("Items");
                item.HasKey(i => i.Id);
                item.HasIndex(i => i.Name).IsUnique();
                item.Property(i => i.Name).IsRequired();
                item.Property(i => i.Price).IsRequired();
                item.Property(i => i.Quantity).IsRequired();

            });
        }

        #endregion
    }
}
