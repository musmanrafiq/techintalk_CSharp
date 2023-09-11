namespace _11_Ecapsulation
{
    public class Animal
    {
        private int _noOfLegs;

        public string NoOfLegs
        {
            get
            {
                return $"No of legs are {_noOfLegs}";
            }
            private set
            {
                _noOfLegs = int.Parse(value);
            }
        }
    }
}
