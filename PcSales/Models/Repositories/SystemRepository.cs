using System;
using System.Collections.Generic;
using System.Linq;
using PcSales.Models.Interfaces;

namespace PcSales.Models.Repositories
{
    public class SystemRepository : ISystemRepository
    {
        private readonly AppDbContext _context;

        public SystemRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(SystemForSale sytem)
        {
            _context.SystemsForSale.Add(sytem);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            SystemForSale sys = _context.SystemsForSale.FirstOrDefault(s => s.SystemId == id);
            if (sys != null)
                _context.SystemsForSale.Remove(sys);
            return _context.SaveChanges();
        }

        public IEnumerable<SystemForSale> GetAllSystems()
        {
            List<SystemForSale> systemsForSale = _context.SystemsForSale.ToList();
            return systemsForSale;
        }

        public SystemForSale GetSystem(int id)
        {
            return _context.SystemsForSale.FirstOrDefault(s => s.SystemId == id);
        }

        public int Update(SystemForSale systemChanges)
        {
            SystemForSale sys = _context.SystemsForSale.FirstOrDefault(s => s.SystemId == systemChanges.SystemId);
            if (sys != null)
            {
                _context.Entry(sys).CurrentValues.SetValues(systemChanges);
                return _context.SaveChanges();
            }

            // Update failed 
            return -1;
        }
    }
}
