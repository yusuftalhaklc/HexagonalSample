namespace HexagonalSample.Application.DtoClasses.OrderDetails
{
    public class OrderDetailResult
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
