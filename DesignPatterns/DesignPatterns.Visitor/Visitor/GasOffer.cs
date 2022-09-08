using DesignPatterns.Visitor.Host;

namespace DesignPatterns.Visitor.Visitor
{
    public class GasOffer : VisitorOffer
    {
        public GasOffer() : base("Gas Offer")
        {
        }

        public override string GetCashBack(PlatinumCard card)
        {
            return $"cash back on {Name} for {card.Name} is 2%";
        }

        public override string GetCashBack(GoldCard card)
        {
            return $"cash back on {Name} for {card.Name} is 3%";
        }
    }
}