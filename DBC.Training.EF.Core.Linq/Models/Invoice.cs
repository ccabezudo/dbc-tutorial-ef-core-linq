namespace DBC.Training.EF.Core.Linq.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string Title { get; set; }
        public double Total { get; set; }
        public bool Payed { get; set; }
    }
}
