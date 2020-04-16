using System;
using System.Collections.Generic;

namespace PcSales.Models.Interfaces
{
    public interface ICaseSpecRespository
    {
        CaseSpec GetCaseSpec(int partNum);
        IEnumerable<CaseSpec> GetAll();
        int Add(CaseSpec spec);
        int Update(CaseSpec specChanges);
        int Delete(int partNum);
    }
}
