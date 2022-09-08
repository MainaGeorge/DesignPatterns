using DesignPatterns.Visitor.Host;
using DesignPatterns.Visitor.Visitor;

namespace DesignPatterns.Tests
{
    public class VisitorPatternTests
    {
        [Fact]
        public void VisitorCalculatesCashBackCorrectly()
        {
            var goldCard = new GoldCard();
            var platinumCard = new PlatinumCard();

            var gasOffer = new GasOffer();
            var hotelOffer = new HotelBookingOffer();

            var expectedGasOfferGoldCard = gasOffer.GetCashBack(goldCard);
            var expectedGasOfferPlatinumCard = gasOffer.GetCashBack(platinumCard);

            var expectedHotleOfferGoldCard = hotelOffer.GetCashBack(goldCard);
            var expectedHotleOfferPlatinumCard = hotelOffer.GetCashBack(platinumCard);

            var actualGasOfferGoldCard = goldCard.Accept(gasOffer);
            var actualGasOfferPlatinumCard = platinumCard.Accept(gasOffer);

            var actualHotelOfferGoldCard = goldCard.Accept(hotelOffer);
            var actualHotelOfferPlatinumCard = platinumCard.Accept(hotelOffer);

            Assert.Equal(expectedGasOfferPlatinumCard, actualGasOfferPlatinumCard);
            Assert.Equal(expectedGasOfferGoldCard, actualGasOfferGoldCard);
            Assert.Equal(expectedHotleOfferGoldCard, actualHotelOfferGoldCard);
            Assert.Equal(expectedHotleOfferPlatinumCard, actualHotelOfferPlatinumCard);
        }
    }
}
