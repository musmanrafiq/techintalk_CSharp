namespace WebApi.Data
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int UserEntityId { get; set; }
        public UserEntity UserEntity { get; set; } = null!;
    }
}
