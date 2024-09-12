using Newtonsoft.Json;

namespace _004_AsyncAwait_HttpClient
{
    //https://publicapi.dev/
    //https://api-colombia.com/swagger/index.html
    internal class Program
    {
        static void Main(string[] args)
        {
            var integrationService = new IntegrationService();

            var columbiaInfo = integrationService.GetColumbiaInfo().Result;
            Console.WriteLine(columbiaInfo.name);
            Console.ReadLine();
        }

        public class IntegrationService
        {
            public async Task<Country> GetColumbiaInfo()
            {
                using (var client = new HttpClient())
                {
                    var endpoint = $"https://api-colombia.com/api/v1/Country/Colombia";

                    var response = await client.GetAsync(endpoint);
                    response.EnsureSuccessStatusCode();
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Country>(content);
                }
            }
        }
    }
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string stateCapital { get; set; }
        public int surface { get; set; }
        public int population { get; set; }
        public List<string> languages { get; set; }
        public string timeZone { get; set; }
        public string currency { get; set; }
        public string currencyCode { get; set; }
        public string currencySymbol { get; set; }
        public string isoCode { get; set; }
        public string internetDomain { get; set; }
        public string phonePrefix { get; set; }
        public string radioPrefix { get; set; }
        public string aircraftPrefix { get; set; }
        public string subRegion { get; set; }
        public string region { get; set; }
        public List<string> borders { get; set; }
        public List<string> flags { get; set; }
    }
}
