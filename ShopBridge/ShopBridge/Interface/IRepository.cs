using System.Threading.Tasks;

namespace ShopBridge.Interface
{
    /// <summary>
    /// Repository
    /// </summary>
    public interface IRepository
    {
        void Save();
        Task SaveAsync();
    }
}
