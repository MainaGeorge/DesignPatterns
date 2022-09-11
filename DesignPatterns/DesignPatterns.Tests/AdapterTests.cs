using DesignPatterns.Adapter;

namespace DesignPatterns.Tests
{
    public class AdapterTests
    {
        [Fact]
        public void AdapterClass_CorrectlyAdaptsClient_ToUseThirdPartyService()
        {
            //this class hides the incompatibility of the client and  the third party library
            var adaptedCostEstimate = new AdaptedCostEstimate();
            var estimate = adaptedCostEstimate.Estimate(2, 200);

            Assert.Equal(400, estimate);
        }
    }
}
