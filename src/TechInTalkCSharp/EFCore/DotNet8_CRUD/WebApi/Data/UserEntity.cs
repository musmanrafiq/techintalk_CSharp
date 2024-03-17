namespace WebApi.Data
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserAdressEntity? UserAdressEntity { get; set; }

        public ICollection<Device> Devices { get; set; } = new List<Device>();

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
