using DesignPatterns.Visitor.Host;
using DesignPatterns.Visitor.Visitor;

namespace DesignPatterns.Tests
{
    public class VisitorPatternTests
    {
        [Fact]
        public void VisitorCalculates_GasOfferCashBackCorrectly()
        {
            var goldCard = new GoldCard();
            var platinumCard = new PlatinumCard();
            var gasOffer = new GasOffer();

            var expectedGasOfferGoldCard = gasOffer.GetCashBack(goldCard);
            var expectedGasOfferPlatinumCard = gasOffer.GetCashBack(platinumCard);

            var actualGasOfferGoldCard = goldCard.Accept(gasOffer);
            var actualGasOfferPlatinumCard = platinumCard.Accept(gasOffer);

            Assert.Equal(expectedGasOfferPlatinumCard, actualGasOfferPlatinumCard);
            Assert.Equal(expectedGasOfferGoldCard, actualGasOfferGoldCard);
        }

        [Fact]
        public void VisitorCalculates_HotelOfferCashBackCorrectly()
        {
            var goldCard = new GoldCard();
            var platinumCard = new PlatinumCard();
            var hotelOffer = new HotelBookingOffer();

            var expectedHotleOfferGoldCard = hotelOffer.GetCashBack(goldCard);
            var expectedHotleOfferPlatinumCard = hotelOffer.GetCashBack(platinumCard);

            var actualHotelOfferGoldCard = goldCard.Accept(hotelOffer);
            var actualHotelOfferPlatinumCard = platinumCard.Accept(hotelOffer);

            Assert.Equal(expectedHotleOfferGoldCard, actualHotelOfferGoldCard);
            Assert.Equal(expectedHotleOfferPlatinumCard, actualHotelOfferPlatinumCard);
        }
    }
}
