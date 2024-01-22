using Search.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Domain.Repositories
{
    public interface ISearchItemRepository
    {
        public Task<IEnumerable<Item>> GetFilteredItems(string name, string description, int relevance, DateTime? dateFrom, DateTime? dateTo);
    }
}
