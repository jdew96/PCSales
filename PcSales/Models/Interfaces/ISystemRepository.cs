using System;
using System.Collections.Generic;

namespace PcSales.Models.Interfaces
{
    public interface ISystemRepository
    {
        SystemForSale GetSystem(int id);
        IEnumerable<SystemForSale> GetAllSystems();
        int Add(SystemForSale sytem);
        int Update(SystemForSale systemChanges);
        int Delete(int id);
    }
}
