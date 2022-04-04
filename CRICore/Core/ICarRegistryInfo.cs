namespace CRICore.Core
{
    public interface ICarRegistryInfo
    {
        bool validateNumberPlate(string numberPlate);

        string[] getModelInfo(string numberPlate);

        string getFuelType(string numberPlate);

        int getWeight(string numberPlate);

        int[] getEngineAndTopSpeed(string numberPlate);
    }
}
