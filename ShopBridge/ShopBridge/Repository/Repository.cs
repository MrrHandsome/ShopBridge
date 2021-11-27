using ShopBridge.DbContexts;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    /// <summary>
    /// Repository
    /// </summary>
    public class Repository
    {
        #region Private Member

        private readonly ShopBridgeDatabaseContext _dbContext;

        #endregion

        #region Public Constructor

        /// <summary>
        /// Initialize database context
        /// </summary>
        /// <param name="dbContext">Shop bridge db context</param>
        public Repository(ShopBridgeDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Pubic Method

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public Task SaveAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        #endregion
    }
}
