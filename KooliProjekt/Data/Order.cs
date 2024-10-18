using Microsoft.AspNetCore.Identity;

namespace KooliProjekt.Data
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        //seob kasutaja tellimusega
        public IdentityUser User { get; set; }
        public string UserId { get; set; }

        // mis tooted tellib klient
        public IList<OrderLine> Lines { get; set; }

        public Order()
        {
            Lines = new List<OrderLine>();
        }
    }
}
