using Industrial.Models.SupplyDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Industrial.Services.SupplyService
{
    public class SupplyManager
    {
        ISupplyREST supplyRest;

        public SupplyManager(ISupplyREST supplyRest)
        {
            this.supplyRest = supplyRest;
        }

        public Task<List<Supply>> AvailableSuppliesAsync()
        {
            return supplyRest.AvailableSuppliesAsync();
        }
        /*
        public Task<List<Supply>> FindSupplyAsync(int SupplyID, String InternalCode, String supplyName)
        {
            return supplyRest.AvailableSuppliesAsync(SupplyID, InternalCode, supplyName);
        }

        Task<Supply> getSupplyAsync(int SupplyID);

        Task SaveSupplyAsync(Supply supply, bool isNewSupply);
        */
    }
}
