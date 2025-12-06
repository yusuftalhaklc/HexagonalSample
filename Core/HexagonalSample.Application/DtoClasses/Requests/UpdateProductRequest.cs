namespace HexagonalSample.Application.DtoClasses.Requests
{
    public class UpdateProductRequest
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
