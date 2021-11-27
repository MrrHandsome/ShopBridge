using System;
using System.Collections.Generic;

namespace ShopBridge.Models
{
    /// <summary>
    /// Pagination
    /// </summary>
    /// <typeparam name="T">Class</typeparam>
    public class PaginatedList<T>
    {
        #region Public Property
        public int Page { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalCount { get; private set; }
        public List<T> Items { get; private set; }

        #endregion

        #region Public Constructor

        /// <summary>
        /// Initilize value
        /// </summary>
        /// <param name="items">Number of item</param>
        /// <param name="count">Total count</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page Size</param>
        public PaginatedList(List<T> items, int count, int page, int pageSize)
        {
            Page = page;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            Items = items;
            TotalCount = count;
        }

        #endregion
    }
}
