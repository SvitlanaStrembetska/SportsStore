using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.WebUI.Models
{
    public class ProductsListViewModel {

        public IEnumerable<Product> Products { get; internal set; }

        public PagingInfo PagingInfo { get; internal set; }
    }
}