namespace HexagonalSample.Application.DtoClasses.Requests
{
    public class CreateAppUserProfileRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int AppUserId { get; set; }
    }
}
