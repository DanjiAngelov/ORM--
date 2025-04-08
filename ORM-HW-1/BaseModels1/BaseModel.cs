namespace ex88.BaseModels
{
    public class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; } = DateTimeOffset.UtcNow;

        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset DeletedAt { get; set; }
        public DateTimeOffset CreayedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
