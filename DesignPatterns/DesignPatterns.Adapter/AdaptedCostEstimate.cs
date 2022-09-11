namespace DesignPatterns.Adapter;

public class AdaptedCostEstimate : IAdapterInterface
{
    public ThirdPartyCostEstimator? ThirdPartyCostEstimator { get; private set; }

    public AdaptedCostEstimate()
    {
    }

    public double Estimate(double amountPerPerson, int numberOfRegisteredPeople)
    {
        ThirdPartyCostEstimator = new ThirdPartyCostEstimator(numberOfRegisteredPeople, amountPerPerson);
        return ThirdPartyCostEstimator.ExecuteEstimation();
    }

}