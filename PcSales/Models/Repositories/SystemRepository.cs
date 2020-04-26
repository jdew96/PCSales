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

        public int Add(SystemForSale systemForSale)
        {
            List<SystemForSale> systemsForSale = _context.SystemsForSale.ToList();
            if (systemsForSale.Where(s => s.SystemName == systemForSale.SystemName).Any())
            {
                _context.SystemsForSale.Add(systemForSale);
                return _context.SaveChanges();
            }
            else
            {
                return -1;
            }

        }

        public int Delete(String systemName)
        {
            SystemForSale sys = _context.SystemsForSale.FirstOrDefault(s => s.SystemName == systemName);
            if (sys != null)
            {
                _context.SystemsForSale.Remove(sys);
                return _context.SaveChanges();
            }

            return -1;
        }

        public IEnumerable<SystemForSale> GetAll()
        {
            List<SystemForSale> systemsForSale = _context.SystemsForSale.ToList();
            return systemsForSale;
        }

        public SystemForSale GetSystem(String systemName)
        {
            return _context.SystemsForSale.FirstOrDefault(s => s.SystemName == systemName);
        }

        public int Update(SystemForSale systemChanges)
        {
            SystemForSale sys = _context.SystemsForSale.FirstOrDefault(s => s.SystemId == systemChanges.SystemId);
            if (sys != null) // Record with matching systemId was found 
            {
                _context.Entry(sys).CurrentValues.SetValues(systemChanges);
                return _context.SaveChanges();
            }

            // Update failed 
            return -1;
        }
    }
}
