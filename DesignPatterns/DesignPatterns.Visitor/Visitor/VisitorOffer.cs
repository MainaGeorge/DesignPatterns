using DesignPatterns.Visitor.Host;

namespace DesignPatterns.Visitor.Visitor
{
    public abstract class VisitorOffer
    {
        protected string Name { get; set; }

        protected VisitorOffer(string name)
        {
            Name = name;
        }

        public abstract string GetCashBack(PlatinumCard card);
        public abstract string GetCashBack(GoldCard card);


    }
}