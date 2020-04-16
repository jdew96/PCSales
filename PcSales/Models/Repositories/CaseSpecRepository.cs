using System;
using System.Collections.Generic;
using System.Linq;
using PcSales.Models.Interfaces;

namespace PcSales.Models.Repositories
{
    public class CaseSpecRepository : ICaseSpecRespository
    {
        private readonly AppDbContext _context;

        public CaseSpecRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(CaseSpec spec)
        {
            _context.CaseSpec.Add(spec);
            return _context.SaveChanges();
        }

        public int Delete(int partNum)
        {
            CaseSpec spec = _context.CaseSpec.FirstOrDefault(s => s.PartNum == partNum);

            if (spec != null)
            {
                _context.CaseSpec.Remove(spec);
                return _context.SaveChanges();
            }

            return -1;
        }

        public IEnumerable<CaseSpec> GetAll()
        { 
            List<CaseSpec> specs = _context.CaseSpec.ToList();
            return specs;
        }

        public CaseSpec GetCaseSpec(int partNum)
        {
            return _context.CaseSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        public int Update(CaseSpec specChanges)
        {
            CaseSpec spec = _context.CaseSpec.FirstOrDefault(s => s.PartNum == specChanges.PartNum);
            if (spec != null) // Record with matching systemId was found 
            {
                _context.Entry(spec).CurrentValues.SetValues(specChanges);
                return _context.SaveChanges();
            }

            // Update failed 
            return -1;
        }
    }
}