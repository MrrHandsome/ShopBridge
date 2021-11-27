using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using ShopBridge.Extensions;
using ShopBridge.Interface;
using ShopBridge.Entities;
using System.Threading.Tasks;

namespace ShopBridge.DbContexts
{
    /// <summary>
    /// Database context of ShopBridge
    /// </summary>
    public class ShopBridgeDatabaseContext : DbContext, IShopBridgeDatabaseContext
    {
        #region Private Member

        private readonly ConfigurationStoreOptions _storeOptions;

        #endregion

        #region Public Property
        public DbSet<Item> Items { get; set; }

        #endregion

        #region Public Constructor

        /// <summary>
        ///  Initialize database connectionString
        /// </summary>
        public ShopBridgeDatabaseContext() : this("server=(local)\\SQLEXPRESS2012;database=shopbridgedb;trusted_connection=yes;".StrToContextOptions<ShopBridgeDatabaseContext>(),
            new ConfigurationStoreOptions())
        {
        }

        /// <summary>
        /// Initialize datacontxtoptions and configurations
        /// </summary>
        /// <param name="options">Databasecontextoptions</param>
        /// <param name="storeOptions">Configurationstoreoptions</param>
        public ShopBridgeDatabaseContext(DbContextOptions<ShopBridgeDatabaseContext> options, ConfigurationStoreOptions storeOptions)
            : base(options)
        {
            _storeOptions = storeOptions;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Save the at the end of each operation
        /// </summary>
        /// <returns>Returns the result</returns>
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        #endregion

        #region Protected Override Method

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureShopBridgeContext();
        }

        #endregion
    }
}
