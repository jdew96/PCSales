using System;
using System.Collections.Generic;

namespace PcSales.Models.Interfaces
{
    public interface IPartSpecRespository
    {
        CaseSpec GetCaseSpec(int partNum);
        IEnumerable<CaseSpec> GetAllCaseSpecs();
        int AddCaseSpec(CaseSpec spec);


        // Copty these for every other part spec type 
    }
}
