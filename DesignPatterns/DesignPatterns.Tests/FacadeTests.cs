using DesignPatterns.Facade;

namespace DesignPatterns.Tests
{
    public class FacadeTests
    {
        [Theory]
        [InlineData("data retrieved", "You are not allowed to access the server")]
        public void Facade_ProvidesCommonInterface_ToHandleAllCasesRetrievingData(string expectedData, string expectedAuthenticationErrorMessage)
        {
            // provides common interface to perform complex operations as a single uniform operation
            IFacade facade = new FacadeService();


            var data = facade.ReadData("admin", "password1", "connectionString");
            Assert.Equal(expectedData, data);

            var error = Assert.Throws<InvalidOperationException>(() => facade.ReadData("admin", "passw0rd1", "connectionString"));
            Assert.Equal(expectedAuthenticationErrorMessage,error.Message);
        }
    }
}
