namespace WebApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public UserAdressModel? UserAdressModel { get; set; }
    }

    public class UserAdressModel
    {
        public int Id { get; set; }
        public string AdressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        public int? UserId { get; set; }
        public UserModel? User { get; set; }
    }

}
