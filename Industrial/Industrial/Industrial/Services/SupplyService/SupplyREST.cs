using Industrial.Models.SupplyDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Industrial.Services.SupplyService
{
    public class SupplyRest : ISupplyREST
    {
        private static string SUPPLIES_URI = Constants.REST_URL_PRINCIPAL + "/supplies";

        private static string AVAILABLE_URI = SUPPLIES_URI + "/available";
        private static string SEARCH_URI = SUPPLIES_URI + "/search";
        private static string FIND_SUPPLY_URI = SUPPLIES_URI + "/";
        private static string MODIFY_URI = SUPPLIES_URI + "/modify";

        HttpClient httpsClient;

        public List<Supply> supplies { get; private set; }

        public SupplyRest()
        {
            httpsClient = new HttpClient();
        }
        public async Task<List<Supply>> AvailableSuppliesAsync()
        {
            supplies = new List<Supply>();

            Uri uri = new Uri(string.Format(AVAILABLE_URI,string.Empty));

            try
            {
                HttpResponseMessage response = await httpsClient.GetAsync(uri);
                if (response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    supplies = JsonConvert.DeserializeObject<List<Supply>>(content);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return supplies;
        }

        public Task<List<Supply>> FindSupplyAsync(int SupplyID, string InternalCode, string supplyName)
        {
            throw new NotImplementedException();
        }

        public Task<Supply> getSupplyAsync(int SupplyID)
        {
            throw new NotImplementedException();
        }

        public Task SaveSupplyAsync(Supply supply, bool isNewSupply)
        {
            throw new NotImplementedException();
        }
    }
}
