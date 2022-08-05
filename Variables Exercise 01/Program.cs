using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts
            const string firstName = "Joshua";
            const int yearOfBirth = 1998;
            const string lastName = "Moore";

            System.Console.WriteLine($"{firstName}");
            System.Console.WriteLine($"{lastName}");
            System.Console.WriteLine(yearOfBirth);
            #region Types
            // string
            // char
            // bool
            // int
            // double
            // decimal
            #endregion

            string a;
            char b;
            bool c;
            int d;
            double e;
            decimal f;

            a = "Hello";
            b = 'J';
            c = false;
            d = 7;
            e = 3.14;
            f = 3.14m;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            System.Console.WriteLine(e);
            System.Console.WriteLine(f);

            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 

            // TODO: Initialize each of the variables with a value

            // TODO: Write out each of the variables to the Console 
        }

    }
}
