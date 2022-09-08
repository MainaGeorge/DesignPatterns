using DesignPatterns.Visitor.Host;

namespace DesignPatterns.Visitor.Visitor
{
    public class HotelBookingOffer : VisitorOffer
    {
        public HotelBookingOffer() : base("Hotel Booking Offer")
        {
        }

        public override string GetCashBack(PlatinumCard card)
        {
            return $"cash back on {Name} for {card.Name} is 5%";
        }

        public override string GetCashBack(GoldCard card)
        {
            return $"cash back on {Name} for {card.Name} is 10%";
        }

    }
}