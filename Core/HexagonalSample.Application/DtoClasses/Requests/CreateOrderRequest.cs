namespace HexagonalSample.Application.DtoClasses.Requests
{
    public class CreateOrderRequest
    {
        public string ShippingAddress { get; set; } = string.Empty;
        public int? AppUserId { get; set; }
    }
}
