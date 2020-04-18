using System;
using System.Collections.Generic;
using System.Linq;
using PcSales.Models.Interfaces;

namespace PcSales.Models.Repositories
{
    public class PartSpecRepository : IPartSpecRespository
    {
        private readonly AppDbContext _context;

        public PartSpecRepository(AppDbContext context)
        {
            _context = context;
        }

        public int AddCaseSpec(CaseSpec spec)
        {
            _context.CaseSpec.Add(spec);
            return _context.SaveChanges();
        }


        public IEnumerable<CaseSpec> GetAllCaseSpecs()
        {
            List<CaseSpec> specs = _context.CaseSpec.ToList();
            return specs;
        }

        public CaseSpec GetCaseSpec(int partNum)
        {
            return _context.CaseSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        // Copty these for every other part spec type 

    }
}