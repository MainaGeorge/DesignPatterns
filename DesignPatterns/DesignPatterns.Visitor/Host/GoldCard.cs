using DesignPatterns.Visitor.Visitor;

namespace DesignPatterns.Visitor.Host
{
    public class GoldCard : BankCard
    {
        public GoldCard() : base("Platinum Card")
        {
        }

        public override string Accept(VisitorOffer offer)
        {
            return offer.GetCashBack(this);
        }
    }
}