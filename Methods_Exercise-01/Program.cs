using System;

namespace Methods_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE: For each method call the AddSpaces() method to separate the answers!

            // DONE: Call the PrintGreeting() method

            Console.WriteLine("---------------------------Print Greeting Method-------------------------");
            AddSpaces();
            PrintGreeting();
            AddSpaces();

            // DONE: Call the SayHello() method

            Console.WriteLine("---------------------------Say Hello Method-------------------------");
            AddSpaces();
            SayHello();
            AddSpaces();

            // TODO: Call the GreetUser() method

            Console.WriteLine("---------------------------Greet User Method-------------------------");
            AddSpaces();
            GreetUser();
            AddSpaces();

            // TODO: Call the Exponentiate() method and store the returned value in a variable called result
            // TODO: Write result out to the console (display the result creatively)

            Console.WriteLine("---------------------------Exponentiate Method-------------------------");
            AddSpaces();
            Exponentiate();
            AddSpaces();

            // TODO: Call the IsPrime() method and write out the result to the console
            // TODO: Creatively display the information to the console window

            Console.WriteLine("---------------------------Is Prime Method-------------------------");
            AddSpaces();
            IsPrime();
            AddSpaces();
        }

        // DONE: Create a public static method called AddSpaces() which creates 2 blank lines when called
        // and does NOT **return** anything

        public static void AddSpaces()
        {
            Console.WriteLine();
            Console.WriteLine();
        }


        // DONE: Create a public static method called PrintGreeting() with a return type of void that takes no parameters,
        // and writes to the console "Hello World!"

        public static void PrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }


        // DONE: Create a public static method called SayHello() with a return type of void which takes 2 parameters firstName & lastName,
        // and concatenates them into a sentence Ex: "Hello, John Smith!" then writes them to the console

        public static void SayHello()
        {
            Console.WriteLine("Please enter your first name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }



        // DONE: Create a method called GreetUser() that asks the user for their name
        // then greets them with that name to the console (don't forget to prompt the user to enter their name!)

        public static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}. It is nice to meet you.");
        }



        // DONE: Create a method called Exponentiate() that asks the user for a number and a powerOF
        // and then calculates the result of raising the first to the second (don't forget to prompt the user to enter the 2 numbers!)

        public static void Exponentiate()
        {
            Console.WriteLine("This calcuation raises your first number to the power of your second number.");
            Console.WriteLine("Please enter your first number:");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");
            double powerOf = Convert.ToDouble(Console.ReadLine());

            double answer = Math.Pow(number, powerOf);
            Console.WriteLine($"{number} raisded to the power of {powerOf} equals {answer}");
        }



        // DONE: Create a method called IsPrime() that asks the user for a number then returns true if the number is prime or false otherwise
        // (don't forget to prompt the user to enter the number!)
        //Note: I adjusted the true or false output to be a string that states if the value is prime or not.

        public static void IsPrime()
        {
            Console.WriteLine("Enter a number to check if it is a Prime number:");

            int num = Convert.ToInt32(Console.ReadLine());

            int flag = 0;
            int isPrime = num/2;
            
            for (int i = 2; i <= isPrime; i++)
            {                
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not prime.");
                    flag = 1;
                    break;
                }            
                              
            }

            if (flag == 0)
            {
                Console.WriteLine("Number is prime.");
            }                      


        }
    }
}
