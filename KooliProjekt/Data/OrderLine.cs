using System.Diagnostics.CodeAnalysis;

namespace KooliProjekt.Data
{
    public class OrderLine
    {
        [ExcludeFromCodeCoverage]
        public int Id { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        // tellimus: tooted
        public OrderLine User { get; set; }
        public int OrderLineId { get; set; }

        //toode
        public OrderLine Product { get; set; }
        public int ProductId { get; set; }
    }
}
