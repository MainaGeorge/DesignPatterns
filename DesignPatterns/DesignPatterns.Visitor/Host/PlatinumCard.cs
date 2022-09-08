using DesignPatterns.Visitor.Visitor;

namespace DesignPatterns.Visitor.Host
{
    public class PlatinumCard : BankCard
    {
        public PlatinumCard() : base("Platinum Card")
        {
        }

        public override string Accept(VisitorOffer offer)
        {
            return offer.GetCashBack(this);
        }
    }
}