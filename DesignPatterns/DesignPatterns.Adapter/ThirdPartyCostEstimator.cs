namespace DesignPatterns.Adapter
{
    public class ThirdPartyCostEstimator
    {
        public int NumberOfInvestors { get; }
        public double AmountInvestedPerInvestor { get; }

        public ThirdPartyCostEstimator(int numberOfInvestors, double amountInvestedPerInvestor)
        {
            NumberOfInvestors = numberOfInvestors;
            AmountInvestedPerInvestor = amountInvestedPerInvestor;
        }
        public double ExecuteEstimation()
        {
            return AmountInvestedPerInvestor * NumberOfInvestors;
        }
    }
}