namespace JumpArena.View.Staff
{
    public class TicketItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; } = "Vé";
        public int Quantity { get; set; } = 1;
    }
}
