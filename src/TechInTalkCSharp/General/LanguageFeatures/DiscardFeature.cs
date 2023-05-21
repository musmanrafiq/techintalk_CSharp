namespace LanguageFeatures
{
    internal class DiscardFeature
    {

        public (string userName,  string password) GetDetails()
        {
            return ("Usman", "lfkdf");
        }

        public void MethodWithOutParams(out string userName,  out string password)
        {
            userName = "";
            password = "";
       
        }

        public void MethodWithSwitch(int number)
        {
            var value = number switch
            {
                1 => "This is first value",
                _ => "This is not first value"

            };
        }
    }

    public record User (string UserName, string Password);
}
