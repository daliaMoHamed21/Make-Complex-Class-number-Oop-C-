namespace Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 4);
            Complex c2 = new Complex(3, 7);

            // operator overloads
            Complex c3 = c1 - c2;
            Console.WriteLine(c3);

            c3 = 7 - c2;
            Console.WriteLine(c3);

            c3 = c2 - 7;
            Console.WriteLine(c3);

            c1 -= c2;
            Console.WriteLine(c1);

            Complex C = -c1;
            Console.WriteLine(C);

            bool isEqual = c1 == c2;
            Console.WriteLine(isEqual);

            bool notEqual = c1 != c2;
            Console.WriteLine(notEqual);

            bool greaterThan = c1 > c2;
            Console.WriteLine(greaterThan);

            bool greaterOrEqual = c1 >= c2;
            Console.WriteLine(greaterOrEqual);

            bool less = c1 < c2;
            Console.WriteLine(less);

            bool lessOrEqual = c1 <= c2;
            Console.WriteLine(lessOrEqual);

            int intValue = (int)c1;
            Console.WriteLine(intValue);

            string stringValue = (string)c1;
            Console.WriteLine(stringValue);

            bool boolValue = (bool)c1;
            Console.WriteLine(boolValue);
        }
    }
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex()
        {
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex()
            {
                Real = c1.Real - c2.Real,
                Imaginary = c1.Imaginary - c2.Imaginary
            };
        }

        public static Complex operator -(int c1, Complex c2)
        {
            return new Complex()
            {
                Real = c1 - c2.Real,
                Imaginary = c1 - c2.Imaginary

            };
        }

        public static Complex operator -(Complex c1, int c2)
        {
            return new Complex()
            {
                Real = c1.Real - c2,
                Imaginary = c1.Imaginary - c2
            };
        }

        public static Complex operator -(Complex c1)
        {
            return new Complex()
            {
                Real = -c1.Real,
                Imaginary = -c1.Imaginary
            };
        }
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        public static bool operator >(Complex c1, Complex c2)
        {
            return c1.Real > c2.Real && c1.Imaginary > c2.Imaginary;
        }
        public static bool operator >=(Complex c1, Complex c2)
        {
            return c1.Real >= c2.Real && c1.Imaginary >= c2.Imaginary;
        }

        public static bool operator <(Complex c1, Complex c2)
        {
            return c1.Real < c2.Real && c1.Imaginary < c2.Imaginary;
        }

        public static bool operator <=(Complex c1, Complex c2)
        {
            return c1.Real >= c2.Real && c1.Imaginary >= c2.Imaginary;
        }

        public static implicit operator int(Complex c)
        {
            return c.Real;
        }
        // Explicit convert to string
        public static explicit operator string(Complex c)
        {
            return $"{c.Real} + {c.Imaginary}i";
        }

        // Explicit convert to bool
        public static explicit operator bool(Complex c)
        {
            return c.Real != 0 || c.Imaginary != 0;
        }




    }

}