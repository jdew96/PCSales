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
            
            if (systemsForSale.FirstOrDefault(s => s.SystemName == systemForSale.SystemName) == null) // There are no matches
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

        public SystemForSale GetSystem(int sysId)
        {
            return _context.SystemsForSale.FirstOrDefault(s => s.SystemId == sysId);
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

        // Modify parts attached to system
        public int UpdatePartsList(CompositeList partsToSubmit)
        {
            IEnumerable<SystemToPart> s2p = _context.SystemToPart.Where(s => s.SystemId == partsToSubmit.parts[0].systemId);
            if(s2p.Count() != 0) // Need to delete any existing record before addig new 
            {
                foreach(var s in s2p) 
                    _context.SystemToPart.Remove(s);
            }

            foreach (var p in partsToSubmit.parts) // Add records for systemToParts
                _context.SystemToPart.Add(new SystemToPart()
                {
                    SystemId = p.systemId,
                    PartNum = p.partNumber,
                    PartTypeId = p.partTypeId
                });


            return _context.SaveChanges();
        }

        public class partToSubmit
        {
            public int partNumber { get; set; }
            public int partTypeId { get; set; }
            public int systemId { get; set; }
        }

        public class CompositeList
        {
            public List<partToSubmit> parts { get; set; }
        }
    }
}
