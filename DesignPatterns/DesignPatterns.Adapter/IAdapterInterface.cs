namespace DesignPatterns.Adapter;

public interface IAdapterInterface
{
    ThirdPartyCostEstimator ThirdPartyCostEstimator { get; }
    double Estimate(double amountPerPerson, int numberOfRegisteredPeople);

}