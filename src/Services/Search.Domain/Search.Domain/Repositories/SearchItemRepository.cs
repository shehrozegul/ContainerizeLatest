using Microsoft.EntityFrameworkCore;
using Search.Api.Identity;
using Search.Domain.Data;
using Search.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Domain.Repositories
{

    public class SearchItemRepository : ISearchItemRepository
    {
        public readonly SearchDbContext _dbContext;
        public SearchItemRepository(SearchDbContext dbContext) => dbContext = _dbContext;
        public async Task<IEnumerable<Item>> GetFilteredItems(string name, string description, int relevance, DateTime? dateFrom, DateTime? dateTo)
        {
            var result =  _dbContext.Items?.Where(x=>x.Name == name || x.Description == description || (x.Date >= dateFrom ||x.Date <= dateTo));
            return result.ToList();
        }
    }
}
