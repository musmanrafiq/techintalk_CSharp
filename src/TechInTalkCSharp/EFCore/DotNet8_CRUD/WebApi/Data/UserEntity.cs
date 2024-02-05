namespace WebApi.Data
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserAdressEntity? UserAdressEntity { get; set; }
    }

    public class UserAdressEntity
    {
        public int Id { get; set; }
        public string AdressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        public int? UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
