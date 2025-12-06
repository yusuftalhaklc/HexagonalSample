namespace HexagonalSample.Application.DtoClasses.Requests
{
    public class UpdateOrderRequest
    {
        public string ShippingAddress { get; set; } = string.Empty;
        public int? AppUserId { get; set; }
    }
}
