namespace project78.BaseModels
{
    public interface IBaseModel
    {
        public int Id { get; set; }
        public DateTimeOffset CreayedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset DeletedAt { get; set; }
    }
}
