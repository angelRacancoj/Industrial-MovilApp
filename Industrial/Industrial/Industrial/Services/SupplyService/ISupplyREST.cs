using Industrial.Models.SupplyDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Industrial.Services.SupplyService
{
    public interface ISupplyREST
    {
        Task<List<Supply>> AvailableSuppliesAsync();

        Task<List<Supply>> FindSupplyAsync(int SupplyID, String InternalCode, String supplyName);

        Task<Supply> getSupplyAsync(int SupplyID);

        Task SaveSupplyAsync(Supply supply, bool isNewSupply);

    }
}
