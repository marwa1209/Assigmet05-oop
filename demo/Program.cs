namespace demo
{
    #region  overloading
    class Complex
    {
        public int? Real { get; set; }
        public int? Img { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        #region operator overloadig
        #region binary operator overloading
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0)
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
        #endregion
        #region unary operator overloading
        public static Complex operator ++(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real ?? 0) + 1,
                Img = (c?.Img ?? 0)
            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real ?? 0) - 1,
                Img = (c?.Img ?? 0)
            };
        }
        #endregion
        #region relational operators < ,>,>=,<=,!=,==
        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Img > right.Img;
            }
            else
            {
                return left.Real > right.Real;
            }

        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Img < right.Img;
            }
            else
            {
                return left.Real < right.Real;
            }

        }

        #endregion
        #endregion
        #region casting operator overloading
        public static explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }
        public static implicit operator string?(Complex c)
        {
            return c?.ToString() ?? string.Empty;
        }
        #endregion
    }
    #endregion
    #region Casting operator overloading[model]
    class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Passowrd { get; set; }
        public Guid SecuirityStamp { get; set; }

        public static explicit operator UserViewModel(User user)
        {
            string[]? Names = user?.FullName?.Split(" ");
            return new UserViewModel
            {
                FirstName = Names.Length > 0 ? Names[0] : string.Empty,
                LastName = Names.Length > 0 ? Names[1] : string.Empty,
                Email = user.Email,

            };
        }

    }
    class UserViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

    }
    #endregion
    #region abstraction
    abstract class shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal CalcArea();
        public abstract decimal Premiter { get;  }

    }
    abstract class Recbase : shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Rectagle : Recbase
    {
        public override decimal Premiter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

    }
    class Square : Recbase
    {
        public Square(decimal Dim)
        {
            Dim02 = Dim;
            Dim01 = Dim;
        }
        public override decimal Premiter
        {
            get { return (Dim01) * 4; }
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  operator overloading

            Complex c01 = new Complex() { Real = 12, Img = 6 };
            Console.WriteLine(c01);

            Complex c02 = new Complex() { Img = 4, Real = 9 };
            Console.WriteLine(c02);
            Complex c03 = default;
            #region binary operator overloading
            c03 = c01 + c02;
            Console.WriteLine(c03);
            c03 = c01 - c02;
            Console.WriteLine(c03);
            #endregion
            #region unary operator overloading
            c03++;
            Console.WriteLine(c03);
            c03--;
            Console.WriteLine(c03);
            #endregion
            #region relational operators < ,>,>=,<=,!=,==
            if (c01 > c02)
                Console.WriteLine("c01>c02");
            else if (c01 < c02)
                Console.WriteLine("c01 < c02");

            #endregion
            #endregion

            #region casting operator overloading
            Complex C05 = new Complex() { Real = 2, Img = 4 };

            //int Y = (int)C01; // Invalid 
            //                  // Explicit Casting[Recommended]
            //                  // (int) -> XXXX Complex > Int

            Console.WriteLine(C05);
            //Console.WriteLine(Y);

            string S01 = C05.ToString(); // Valid 
                                         // Implicit Casting
                                         // (string) => XXXX complex -> string
            Console.WriteLine(C05);
            Console.WriteLine(S01);

            ///model from dataabse
            User user = new User()
            {
                Id = 1,
                FullName = "Marwa Mahmoud",
                Email = "mm3@gmail.com",
                Passowrd = "password",
                SecuirityStamp = Guid.NewGuid(),
            };
            UserViewModel userViewModel = (UserViewModel)user;
            Console.WriteLine(userViewModel.FirstName);
            //mappig
            #endregion
            #region abstraction
            Rectagle rectagle = new Rectagle();
            rectagle.Dim01= 10;
            rectagle.Dim02= 20;
            decimal RectArea=rectagle.CalcArea();
            Console.WriteLine(RectArea);
            Console.WriteLine(rectagle.Premiter);

            Square square = new Square(7);
            Console.WriteLine(square.CalcArea());
            Console.WriteLine(square.Premiter);
            #endregion
        }
    }
}
