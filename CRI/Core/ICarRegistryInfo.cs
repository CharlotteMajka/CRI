namespace CRI.Core
{
    public interface ICarRegistryInfo
    {
        bool validateNumberPlate(string numberPlate);

        string[] getModelInfo(string numberPlate);

        string getFuelType(string numberPalte);

        int getWeight(string numberPalte);

        int[] getEngineAmdTopSpeed(string numberPlate);
    }
}
