﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koi.Repositories.Base;
using Koi.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Koi.Repositories.Models;

namespace Koi.Repositories.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private readonly KoiFishGameContext _context;

        public ItemRepository(KoiFishGameContext context) : base(context)
        {
            _context = context;
        }

             

        public Task<IEnumerable<Item>> GetByTypeAsync(ItemType itemType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetItemsByTypeAsync(ItemType itemType)
        {
            return await _context.Items
                                 .Where(i => i.Type == itemType)
                                 .ToListAsync();

        }


    }
}
