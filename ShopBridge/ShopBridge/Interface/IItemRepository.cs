using ShopBridge.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Interface
{
    /// <summary>
    /// Item repository
    /// </summary>
    public interface IItemRepository : IRepository
    {
        #region Methods

        Task<List<Item>> GetAllItemAsync(string searchText);
        Task<Item> GetItemAsync(string itemId);
        Task<Item> UpdateItemAsync(Item item);
        Task<Item> AddItemAsync(Item item);
        Task<bool> DeleteItemAsync(string itemId);
        Task<bool> IsItemExistsAsync(string itemId);

        #endregion
    }
}
