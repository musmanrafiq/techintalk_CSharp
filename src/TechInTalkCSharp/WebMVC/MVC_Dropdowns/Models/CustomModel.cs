namespace MVC_Controls.Models
{
    public class CustomModel
    {
        public int SelectedCountry { get; set; }
        public List<CountryModel> Countries { get; set; }
    }

    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
