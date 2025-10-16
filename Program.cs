using System;
using System.Collections.Generic; // Needed for List<T>
using System.Linq; // Needed for .Max(), .Min(), etc.

namespace ProgrammingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call each subroutine to run the task.
            // Students can comment out the ones they aren't working on.
            // Task1_PersonalGreeter();
            // Task2_SimpleCalculator();
            // Task3_GradeDeterminer();
            // Task4_TimesTableGenerator();
            // Task5_NumberGuessingGame();
            // Task6_ListAnalysis();
            Task7_PalindromeChecker();
            // Task8_FunctionBasedWordCounter();
            // Task9_SimpleContactBook();
            // Task10_BubbleSortAlgorithm();
        }

        /// <summary>
        /// Task 1: Ask for the user's name and age, then print a personalized message.
        /// </summary>
        public static void Task1_PersonalGreeter()
        {
            Console.WriteLine("--- Task 1: Personal Greeter ---");

            // 1. Ask the user for their name and store it in a string variable.
            // 2. Ask the user for their age and store it in an int variable.
            // 3. Print a message like, "Hello [Name], you are [Age] years old!"

            Console.WriteLine("\n"); // Adds a blank line for spacing

            String name; //declares a string name
            Console.Write("name? "); //promps user for name entrance
            name = Console.ReadLine(); //stores name into variable
            Console.Write("age? "); //same for age
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {name}, you are {age} years old!");

            Console.WriteLine("\n"); // Adds a blank line for spacing
        }

        /// <summary>
        /// Task 2: Create a simple calculator.
        /// </summary>
        public static void Task2_SimpleCalculator()
        {
            Console.WriteLine("--- Task 2: Simple Calculator ---");

            // 1. Ask the user to enter their first number.
            // 2. Ask the user to enter their second number.
            // 3. Ask the user to enter an operator (+, -, *, /).
            // 4. Use an if/else if/else statement to perform the correct calculation.
            // 5. Print the result. Remember to handle division by zero.

            Console.WriteLine("\n");
            int num1, num2;
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            num2 = int.Parse(Console.ReadLine());
            char Operation;
            Console.Write("enter a character: ");
            Operation = Console.ReadKey().KeyChar;
            switch (Operation)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("undefined");
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                    }

                    break;
                default:
                    Console.WriteLine("Operation not found");
                    break;
            }

            Console.WriteLine("\n");
        }


        /// <summary>
        /// Task 3: Determine a student's grade from their score.
        /// </summary>
        public static void Task3_GradeDeterminer()
        {
            Console.WriteLine("--- Task 3: Grade Determiner ---");

            // 1. Ask the user for a numerical score (0-100).
            // 2. Use if-else if-else statements to determine the grade:
            //    - 90-100: A
            //    - 80-89:  B
            //    - 70-79:  C
            //    - 60-69:  D
            //    - Below 60: F
            // 3. Print the letter grade.

            Console.WriteLine("\n");

            int Grade;
            Console.Write("Enter a grade: ");
            Grade = int.Parse(Console.ReadLine());
            if (Grade < 60)
            {
                Console.WriteLine("F");
            }
            else if (60 <= Grade && Grade < 70)
            {
                Console.WriteLine("D");
            }
            else if (70 <= Grade && Grade < 80) 
            {
                Console.WriteLine("C");
            }
            else if (80 <= Grade && Grade < 90) 
            {
                Console.WriteLine("B");
            }
            else if (90 <= Grade && Grade <= 100) 
            {
                Console.WriteLine("A");
            }
        }

        /// <summary>
        /// Task 4: Generate a multiplication table.
        /// </summary>
        public static void Task4_TimesTableGenerator()
        {
            Console.WriteLine("--- Task 4: Times Table Generator ---");

            // 1. Ask the user to input a number.
            // 2. Use a 'for' loop to iterate from 1 to 12.
            // 3. Inside the loop, calculate the product of the user's number and the loop counter.
            // 4. Print the result in the format: "7 x 3 = 21".

            Console.WriteLine("\n");
            int multiple;
                Console.Write("Enter a number: ");
                multiple = int.Parse(Console.ReadLine());
                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine(multiple*i);
                }
                
        }

        /// <summary>
        /// Task 5: Create a number guessing game.
        /// </summary>
        public static void Task5_NumberGuessingGame()
        {
            Console.WriteLine("--- Task 5: Number Guessing Game ---");

            // 1. Generate a random number between 1 and 100.
            //    - Random rand = new Random();
            //    - int secretNumber = rand.Next(1, 101);
            // 2. Use a 'while' loop that continues as long as the user's guess is not correct.
            // 3. Inside the loop, ask the user for their guess.
            // 4. Use an 'if' statement to check if the guess is too high, too low, or correct.
            // 5. Print a hint ("Too high" or "Too low").
            // 6. Once the user guesses correctly, print a success message and exit the loop.

            Console.WriteLine("\n");
            
            Random Random = new Random();
            int secretNum = Random.Next(1, 101);
            int guess = 0;
            while (guess!=secretNum)
            {
                Console.WriteLine("Enter a number: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == secretNum)
                {
                    Console.WriteLine("sucess!");
                }
                else if (guess > secretNum)
                {
                    Console.WriteLine("too high!");
                }
                else
                {
                    Console.WriteLine("too low!");
                }
            }
        }

        /// <summary>
        /// Task 6: Analyze a list of numbers.
        /// </summary>
        public static void Task6_ListAnalysis()
        {
            Console.WriteLine("--- Task 6: List Analysis ---");

            // 1. Create an empty list of integers: List<int> numbers = new List<int>();
            // 2. Use a loop to ask the user to enter numbers. Let them type "done" to finish.
            // 3. For each entry, check if it's "done". If not, convert it to an integer and add it to the list.
            // 4. After the loop, calculate and print the Sum, Average, Maximum, and Minimum of the numbers.
            //    (Hint: You can use the built-in .Sum(), .Average(), .Max(), .Min() methods).

            Console.WriteLine("\n");
            List<int> numbers = new List<int>();
            string UserChoice = "";
            while (UserChoice != "done")
            {
                Console.Write("enter a number, or 'done' to exit: ");
                UserChoice = Console.ReadLine();
                if (UserChoice != "done")
                {
                    numbers.Add(int.Parse(UserChoice));
                }

                
            }
            Console.WriteLine(numbers.Sum());
            Console.WriteLine((numbers.Average()));
            Console.WriteLine((numbers.Max()));
            Console.WriteLine((numbers.Min()));
            
        }

        /// <summary>
        /// Task 7: Check if a word is a palindrome.
        /// </summary>
        public static void Task7_PalindromeChecker()
        {
            Console.WriteLine("--- Task 7: Palindrome Checker ---");

            // 1. Ask the user to enter a word.
            // 2. Create a reversed version of the user's word. A 'for' loop that counts backwards is a good way to do this.
            // 3. Compare the original word (ignoring case) with the reversed word.
            // 4. Print whether the word is a palindrome or not.
            //    (Hint: Use .ToLower() to make the comparison case-insensitive).

            Console.WriteLine("\n");
            
            Console.Write("enter a word: ");
            string UserWord = Console.ReadLine();
            string ReverseWord = "";
            for (int i = UserWord.Length - 1; i >= 0; i--)
            {
                ReverseWord = UserWord[i].ToString();
            }
            Console.WriteLine(ReverseWord);
        }

        // This is the helper function for Task 8.
        public static int CountWords(string sentence)
        {
            // 1. Split the sentence into an array of words using sentence.Split(' ').
            // 2. Return the length of the resulting array.
            return 0; // Placeholder
        }

        /// <summary>
        /// Task 8: Call a function to count words in a sentence.
        /// </summary>
        public static void Task8_FunctionBasedWordCounter()
        {
            Console.WriteLine("--- Task 8: Function-Based Word Counter ---");

            // 1. Ask the user to enter a sentence.
            // 2. Call the 'CountWords' function, passing the user's sentence to it.
            // 3. Store the returned value in a variable.
            // 4. Print the result, e.g., "The sentence has X words."

            Console.WriteLine("\n");
        }

        // Define the struct for Task 9 here.
        public struct Contact
        {
            public string Name;
            public string PhoneNumber;
        }

        /// <summary>
        /// Task 9: Create a simple contact book.
        /// </summary>
        public static void Task9_SimpleContactBook()
        {
            Console.WriteLine("--- Task 9: Simple Contact Book ---");
            List<Contact> contacts = new List<Contact>();

            // 1. Create a loop that displays a menu: "1. Add Contact", "2. Display Contacts", "3. Exit".
            // 2. If the user chooses 1:
            //    a. Create a new Contact struct.
            //    b. Ask for a name and phone number and store them in the new struct.
            //    c. Add the struct to the 'contacts' list.
            // 3. If the user chooses 2:
            //    a. Loop through the 'contacts' list and print each contact's details.
            // 4. If the user chooses 3, exit the loop.

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Task 10: Implement the Bubble Sort algorithm.
        /// </summary>
        public static void Task10_BubbleSortAlgorithm()
        {
            Console.WriteLine("--- Task 10: Bubble Sort Algorithm ---");
            int[] numbersToSort = { 5, 1, 4, 2, 8 };
            Console.WriteLine("Original array: " + string.Join(", ", numbersToSort));


            // 1. Create a nested 'for' loop to iterate through the array.
            //    The outer loop will go from the start to the end.
            //    The inner loop will compare adjacent elements.
            // 2. In the inner loop, if element [j] is greater than element [j+1], swap them.
            //    - You'll need a temporary variable to hold one value during the swap.
            // 3. After the loops complete, print the sorted array.


            Console.WriteLine("Sorted array: " + string.Join(", ", numbersToSort));
            Console.WriteLine("\n");
        }
    }
}