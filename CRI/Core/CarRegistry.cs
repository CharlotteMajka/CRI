namespace CRI.Core
{
    public class CarRegistry : ICarRegistryInfo
    {
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

        public bool validateNumberPlate(string numberPlate)
        {

            string url = $"http://api.nrpla.de/{numberPlate}?api_token=[API_TOKEN]";
            return true;    
        }
    }
}
