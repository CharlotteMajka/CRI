using CRICore.Model;
using RestSharp;
using System.Text.Json;

namespace CRICore.Core
{
    public class CarRegistry : ICarRegistryInfo
    {
        private readonly string API_TOKEN = "";
        private RestClient _restClient;
        public CarRegistry(RestClient restClient)
        {
            _restClient = restClient;
        }

        public int[] getEngineAndTopSpeed(string numberPlate)
        {
            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[{API_TOKEN}]";
            var request = new RestRequest(url);
            request.Method = Method.Get;

            var response = _restClient.ExecuteAsync<data>(request).Result;

            if (!response.IsSuccessful)
            {
                throw new Exception("error");
            }

            var result = JsonSerializer.Deserialize<data>(response.Content);

            var returnvalue = new int[] {result.engine_power, result.top_speed};

            return returnvalue;
        }

        public string getFuelType(string numberPlate)
        {

            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[{API_TOKEN}]";
            var request = new RestRequest(url);
            request.Method = Method.Get;

            var response = _restClient.ExecuteAsync<data>(request).Result;

            if (!response.IsSuccessful)
            {
                throw new Exception("error");
            }

            var result = JsonSerializer.Deserialize<data>(response.Content);

            return result.fuel_type;
        }

        public string[] getModelInfo(string numberPlate)
        {

            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[{API_TOKEN}]";
            var request = new RestRequest(url);
            request.Method = Method.Get;

            var response = _restClient.ExecuteAsync<data>(request).Result;

            if (!response.IsSuccessful)
            {
                throw new Exception("error");
            }

            var result = JsonSerializer.Deserialize<data>(response.Content);

            var returnvalue = new string[] {result.brand, result.model, result.version};

            return returnvalue;
        }

        public int getWeight(string numberPlate)
        {
            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[{API_TOKEN}]";
            var request = new RestRequest(url);
            request.Method = Method.Get;

            var response = _restClient.ExecuteAsync<data>(request).Result;

            if (!response.IsSuccessful)
            {
                throw new Exception("error");
            }

            var result = JsonSerializer.Deserialize<data>(response.Content);

            return result.vehicle_weight;
        }

        public bool validateNumberPlate(string numberPlate)
        {
            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[{API_TOKEN}]";
            var request = new RestRequest(url);
            request.Method = Method.Get;

            var response = _restClient.ExecuteAsync<data>(request).Result;

            if (!response.IsSuccessful)
            {
                throw new Exception("error");
            }

            var result = JsonSerializer.Deserialize<data>(response.Content);

            if(result == null)
            {
                return false;
            }
            return true;    
        }
    }
}
