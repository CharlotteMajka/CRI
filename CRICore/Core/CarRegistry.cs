using RestSharp;
using System.Text.Json;

namespace CRICore.Core
{
    public class CarRegistry : ICarRegistryInfo
    {
        private RestClient _restClient;
        public CarRegistry(RestClient restClient)
        {
            _restClient = restClient;
        }

        public int[] getEngineAmdTopSpeed(string numberPlate)
        {
            throw new NotImplementedException();
        }

        public string getFuelType(string numberPalte)
        {
            throw new NotImplementedException();
        }

        public string[] getModelInfo(string numberPlate)
        {
            throw new NotImplementedException();
        }

        public int getWeight(string numberPalte)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> validateNumberPlateAsync(string numberPlate)
        {
            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[API_TOKEN]";
            var request = new RestRequest(url);
            request.Method = Method.Get;

            var response = await _restClient.ExecuteAsync<object>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception("error");
            }

            var result = JsonSerializer.Deserialize<object>(response.Content);

            if(result == null)
            {
                return false;
            }
            return true;    
        }
    }
}
