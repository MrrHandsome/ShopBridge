using AutoMapper;

namespace ShopBridge.Mapper
{
    /// <summary>
    /// Item mapper profile
    /// </summary>
    public class ItemMapperProfile : Profile
    {
        #region Public Constructor

        /// <summary>
        /// Create mapping between models and entities
        /// </summary>
        public ItemMapperProfile()
        {
            CreateMap<Models.Item, Entities.Item>();
            CreateMap<Entities.Item, Models.Item>();
        }

        #endregion
    }
}
