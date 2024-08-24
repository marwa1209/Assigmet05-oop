namespace demo
{
    #region operator overloading
    class Complex
    {
        public int? Real { get; set; }
        public int? Img { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real??0) + (right?.Real??0),
                Img = (left?.Img??0) + (right?.Img??0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)
            };
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operator overloading
            Complex c01 = new Complex() { Real = 2, Img = 6 };
            Console.WriteLine(c01);

            Complex c02 = new Complex() { Img = 4, Real = 9 };
            Console.WriteLine(c02);

            Complex c03 = default;
            c03 = c01 + c02;
            Console.WriteLine(c03);
            c03 = c01 - c02;
            Console.WriteLine(c03);
            #endregion
        }
    }
}
