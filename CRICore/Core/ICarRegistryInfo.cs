namespace CRICore.Core
{
    public interface ICarRegistryInfo
    {
        bool validateNumberPlateAsync(string numberPlate);

        string[] getModelInfo(string numberPlate);

        string getFuelType(string numberPalte);

        int getWeight(string numberPalte);

        int[] getEngineAmdTopSpeed(string numberPlate);
    }
}
