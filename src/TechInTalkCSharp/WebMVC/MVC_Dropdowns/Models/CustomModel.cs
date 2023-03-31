namespace MVC_Controls.Models
{
    public class CustomModel
    {
        public int SelectedCountry { get; set; }
        public int SelectedCity { get; set; }   
        public List<CountryModel> Countries { get; set; }
        public List<CityModel> Cities { get; set; }
    }

    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CityModel
    {
        public int CountryId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
