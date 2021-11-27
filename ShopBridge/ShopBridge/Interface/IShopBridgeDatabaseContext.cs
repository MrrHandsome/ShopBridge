using Microsoft.EntityFrameworkCore;
using ShopBridge.Entities;
using System;
using System.Threading.Tasks;

namespace ShopBridge.Interface
{
    /// <summary>
    /// Shop bridge database context
    /// </summary>
    public interface IShopBridgeDatabaseContext : IDisposable
    {
        #region Public Property

        public DbSet<Item> Items { get; set; }

        #endregion

        #region Methods

        int SaveChanges();
        Task<int> SaveChangesAsync();

        #endregion
    }
}
