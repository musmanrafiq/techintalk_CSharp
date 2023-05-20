namespace LanguageFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // local function example
                /*var localFunction = new LocalFunction();
                localFunction.Example();
                */

            // discard function example
            DiscardFeature discardFeature = new DiscardFeature();


            // #1 method returning multiple values
            var (userName, _ ) = discardFeature.GetDetails();

            // #2 method with out params
            discardFeature.MethodWithOutParams(out string userName1, out string _);

            // #3 object distructuring 

            // #4 switch statement ignore case



             
        }
    }
}