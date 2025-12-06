namespace HexagonalSample.Application.DtoClasses.Orders
{
    public class OrderResult
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public int? AppUserId { get; set; }
        public string? AppUserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
