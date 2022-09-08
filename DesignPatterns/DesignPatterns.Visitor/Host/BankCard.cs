using DesignPatterns.Visitor.Visitor;

namespace DesignPatterns.Visitor.Host
{
    public abstract class BankCard
    {
        public string Name { get; protected set; }

        public abstract string Accept(VisitorOffer offer);

        protected BankCard(string name)
        {
            Name = name;
        }
    }
}