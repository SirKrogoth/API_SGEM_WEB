using API.Model.Class;
using API.Model.Context;
using API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Implementation
{
    public class ItemLogRepository : IItemLog
    {
        private MysqlContext _context;

        public ItemLogRepository(MysqlContext context)
        {
            _context = context;
        }

        public void Add(ItemLog itemLog)
        {
            _context.ItemLog.Add(itemLog);
        }

        public void Create(ItemLog itemLog)
        {
            _context.ItemLog.Add(itemLog);
        }

        public async Task<bool> SaveChange()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
