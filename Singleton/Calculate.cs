namespace Singleton
{
    public sealed class Calculate
    {
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        private static Calculate _instance;
        private Calculate() { }


        public static Calculate GetInstance()
        {
            return _instance ?? (_instance = new Calculate());
        }

        public double Addition()
        {
            return ValueOne + ValueTwo;
        }
        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }
        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }
        public double Division()
        {
            return ValueOne / ValueTwo;
        }
    }
}
