using System;
using System.Collections.Generic;
using static PcSales.Models.Repositories.SystemRepository;

namespace PcSales.Models.Interfaces
{
    public interface ISystemRepository
    {
        SystemForSale GetSystem(int id);
        IEnumerable<SystemForSale> GetAll();
        int Add(SystemForSale sytem);
        int Update(SystemForSale systemChanges);
        int UpdatePartsList(CompositeList partsToSubmit); // Modify parts attached to system
        int Delete(String systemName);
    }
}
