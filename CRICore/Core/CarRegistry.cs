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

            if (result == null || result.top_speed == 0 || result.engine_power == 0)
            {
                throw new Exception("Data cannot be found");
            }

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

            if (result.fuel_type == null)
            {
                throw new Exception("Fuel type not found");
            }

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

            if (result == null)
            {
                var returnValueNull = new string[] { };
                return returnValueNull;   
            }
            var returnvalue = new string[] { result.brand, result.model, result.version };
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

            if (result.vehicle_weight == 0 || result == null)
            {
                return 0;
            }

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
