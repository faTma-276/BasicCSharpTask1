using System.ComponentModel;

namespace BasicCSharp.Task1Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Question1 Answer");
            #region question1
            Console.WriteLine(value: "My name is Fatma Elsayed Akl");
            Console.WriteLine(value: "I am 22 years old");
            Console.WriteLine(value: "My favourite hoppy is reading");
            #endregion

            Console.WriteLine();
            Console.WriteLine(value: "Question2 Answer");
            #region question2
            int intNum = 5;
            double doubleNum = 5.5;
            string name = "fatma";
            bool isTrue = true;
            Console.WriteLine(value: "int Numer is " + intNum);
            Console.WriteLine(value: "double Numer is " + doubleNum);
            Console.WriteLine(value: "string Value is " + name);
            Console.WriteLine(value: "boolean value is " + isTrue);
            #endregion

            Console.WriteLine();
            Console.WriteLine(value: "Question3 Answer");
            #region question3
            double temperature = 32;
            temperature = (temperature * 9 / 5) + 32;
            Console.WriteLine(value: "Temperature in Celsius is " + temperature);
            #endregion

            Console.WriteLine();
            Console.WriteLine(value: "Question4 Answer");
            #region question4
            Console.Write(value: "Enter number1:");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write(value: "Enter number2:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine(value: "summation of numbers is " + (num1 + num2));
            Console.WriteLine(value: "subtraction of numbers is " + (num1 - num2));
            Console.WriteLine(value: "multiplication of numbers is " + (num1 * num2));
            Console.WriteLine(value: "division of numbers is " + (num1 / num2));
            #endregion

            Console.WriteLine();
            Console.WriteLine(value: "Question5 answer");
            #region question5
            Console.Write(value: "Enter the length of the rectangle:");
            float length = float.Parse(Console.ReadLine());
            Console.Write(value: "Enter the width of the rectangle:");
            float width = float.Parse(Console.ReadLine());
            float area = length * width;
            Console.WriteLine(value: "the area of the rectangle is : " + area);
            #endregion


            Console.WriteLine();
            Console.WriteLine(value: "Question6 answer");
            #region question6
            Console.Write(value: "Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(value: "The number is even");
            else
                Console.WriteLine(value: "The number is odd");
            #endregion

            Console.WriteLine();
            Console.WriteLine(value: "Question7 answer");
            #region question7
            Console.Write(value: "please enter your age : ");
            uint age = uint.Parse(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine(value: "You are eligible to vote");
            else
                Console.WriteLine(value: "You are not eligible to vote");
            #endregion

            Console.WriteLine();
            Console.WriteLine(value: "Question8 answer");
            #region question8
            Console.Write(value: "please enter a score : ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 0 && score <= 100)
            {
                if (score < 60)
                {
                    Console.WriteLine(value: "Your grade is F");
                }
                else if(score>=60 && score<=69) 
                {
                    Console.WriteLine(value: "Your grade is D");
                }else if (score >=70 && score <=79)
                {
                    Console.WriteLine(value: "Your grade is C ");
                }else if (score >= 80 && score <= 89)
                {
                    Console.WriteLine(value: "Your grade is B ");
                }else if (score >= 90 && score <= 100)
                {
                    Console.WriteLine(value: "Your grade is A  ");
                }
            }
            #endregion

            // Write a C# program that checks if a number entered by the user is positive, negative
            Console.WriteLine();
            Console.WriteLine(value: "Question9 answer");
            #region question9
            Console.Write(value: "Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
                Console.WriteLine(value: "The number is positive");
            else
                Console.WriteLine(value: "The number is negative");
            #endregion
            //Write a C# program that checks if a rectangle with given length and width is a square.
            Console.WriteLine();
            Console.WriteLine(value: "Question10 answer");
            #region question10
            Console.Write(value: "Enter the length of the rectangle:");
            float lengh = float.Parse(Console.ReadLine());
            Console.Write(value: "Enter the width of the rectangle:");
            float widh = float.Parse(Console.ReadLine());
            if (lengh == widh)
                Console.WriteLine(value: "this rectangle is a square ");
            else
                Console.WriteLine(value: "this rectangle is not a square ");

            #endregion


        }
    }
}
