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
    }

    public record User (string UserName, string Password);
}
