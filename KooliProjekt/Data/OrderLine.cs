namespace KooliProjekt.Data
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        // tellimus: tooted
        public Order Order { get; set; }
        public int OrderId { get; set; }

        //toode
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
