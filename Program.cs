// task 2
/* 
1. write a function that returns the largest element in a list
2. Write a function that reverses a list, preferably in place
3. Write a function that checks whether an element occurs in a list
4. Write a function that returns the elements on odd positions in a list
5. Write a function that computes the running total of a list
6. Write a function that tests whether a string is a palindrome
7. Write a function that computes the total sum of the numbers in a list using a for loop and a while loop 

*/

// no 1
using System;
using System.IO;
using System.Text;


namespace TeaTasks
{
    public class Program
    {

        public static void Main(string[] args)
        {

            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

        }


        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Largest Number Task");
            Console.WriteLine("2) Reverse List");
            Console.WriteLine("3) Search for Element in a List");
            Console.WriteLine("4) Odd indexed Elements");
            Console.WriteLine("5) Running Total of a List");
            Console.WriteLine("6) Palindrome String");
            Console.WriteLine("7) Total Sum of Numbers in a list");
            Console.WriteLine("8) Task 2, Guess my number game");
            Console.WriteLine("9) Task 3, Convert a number to it's word form");
            Console.WriteLine("10) Task 4, Program to register and retrieve student details by their IDs");
            Console.WriteLine("11) Exit");

            string? result = Console.ReadLine();


            if (result == "")
            {
                Console.WriteLine("Please choose an option between 1-8");
                return true;
            }

            else if (result == "1")
            {
                LargestNum();
                return true;
            }

            else if (result == "2")
            {
                ReverseList();
                return true;
            }

            else if (result == "3")
            {
                SearchElement();
                return true;
            }

            else if (result == "4")
            {
                OddPlace();
                return true;
            }

            else if (result == "5")
            {
                RunningTotal();
                return true;
            }

            else if (result == "6")
            {
                IsPalindrome();
                return true;
            }

            else if (result == "7")
            {
                TotalSum();
                return true;
            }

            else if (result == "8")
            {
                GuessMe();
                return true;
            }

            else if (result == "9")
            {
                NumberToWordForm();
                return true;
            }

            else if (result == "10")
            {
                StudentDatabase();
                return true;
            }

            else if (result == "12")
            {
                ConvertNumberToWords();
                return true;
            }

            else if (result == "11")
            {
                return false;
            }

            else
            {
                return true;
            }

        }


         // method to accept user input
        private static List<string> UserInput()
        {
            // i want to make it possible that the user can enter a list of items and i iterate through it and assign it to a list
            Console.WriteLine("Enter a list of items seperated by commas! ");
            string input = Console.ReadLine();

            string[] userInputs = input.Split(",");

            List<string> userList = new List<string>(userInputs);

            return userList;

            // end of the neccessary program

            Console.WriteLine(string.Join(",", userList));

            Console.ReadLine();

        }


        private static int FindMax(List<int> numbers)
        {
            // i want to return the max of number in a list

            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list cannot be null or empty.");
            }

            int max = numbers[0]; // Initialize max with the first element

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;

        }



        // method to convert string list to integer list

        private static List<int> IntList(List<string> stringList)
        {
            List<int> intList = new List<int>();

            foreach (string str in stringList)
            {
                int result;
                if (int.TryParse(str, out result))
                {
                    intList.Add(result);
                }
            }

            return intList;
        }



        private static List<string> ReverseList(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                return new List<string>(); // Return an empty list for null or empty input
            }

            List<string> reversedList = new List<string>(list.Count); // Create a new list with the same capacity
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }

            return reversedList;
        }



        // 1. write a function that returns the largest element in a list

        private static void LargestNum()
        {

            Console.Clear();
            Console.WriteLine("Looking for the largest number in a list? Enter your numbers");

            // i want to accept user input


            List<int> tempList = new List<int> (IntList(UserInput()));
            Console.WriteLine($"THis is the users list {string.Join(",",tempList)}");

            


            // List<int> userList = UserInput();
            // List<string> list = new List<string>();

            


            // var myList = new List<int> { 1, 4, 2, 4, 2, 5, 20, 34 };

            // int num = FindMax(myList);

            // Console.WriteLine($"this is different {num}");

            // find the largest number in the list

            Console.WriteLine($"Largest number in the list is {FindMax(tempList)}");
            Console.ReadLine();
        }


        // 2. Write a function that reverses a list, preferably in place

        private static void ReverseList()
        {

            Console.Clear();
            Console.WriteLine("only input numbers");
            List<string> myList = new List<string> (UserInput());
            // reversing the order of the list
            List<string> reversedList = new List<string>(myList);
            reversedList.Reverse();
            // Convert the list to readable string form
            Console.WriteLine($"This is the initial list {string.Join(",", myList)}\n");
            // display the reversed list
            Console.WriteLine("Reversed List");
            string listString = string.Join(",", reversedList);
            Console.WriteLine(listString); // Prints "1,2,3,4,5"

            Console.ReadLine();

        }



        public static void SearchElement()
        {
            Console.Clear();
            Console.Write("Please enter a list of items: ");
            Console.Write("Enter anything seperated by commas and then search for whatever you entered ");
            List<string> userList = new List<string> (UserInput());

            Console.WriteLine("\nThis is the search bar, what are you looking for: ");
            
            string searchTag = Console.ReadLine();

            // List<int> newInts = new List<int> { 1, 2, 3, 4, 5 };
            // int userInput = int.Parse(Console.ReadLine());

            foreach (string i in userList)
            {
                if (i == searchTag)
                {
                    Console.WriteLine($"the search tag \"{i}\" is in the list {string.Join(", ", userList)}");
                }
                // else
                // {
                //     Console.WriteLine("Not Found");
                // }

            }

            

            Console.ReadLine();


        }



        // 4. Write a function that returns the elements on odd positions in a list

        private static void OddPlace()
        {

            Console.Clear();
            List<string> ingredients = new List<string>(UserInput());
            
            List<string> oddElements = new List<string>();

            for (int i = 1; i < ingredients.Count; i += 2)
            {
                oddElements.Add(ingredients[i]);
            }

            Console.WriteLine($"This is the list of oddly indexed element {string.Join(", ", oddElements)}");

            Console.ReadLine();

        }



        // Write a function that computes the running total of a list
        private static void RunningTotal()
        {

            Console.Clear();
            List<int> priceOfGoods = new List<int> (IntList(UserInput()));
            int goodsTotalPrice = 0;



            for (int i = 0; i < priceOfGoods.Count; i++)
            {
                Console.WriteLine($"Running total of goods: N {goodsTotalPrice += priceOfGoods[i]}");
            }

            Console.WriteLine($"Total sum of goods bought: N {goodsTotalPrice} \nPrint receipt");

            Console.ReadLine();

        }



        // Write a function that tests whether a string is a palindrome

        private static void IsPalindrome()
        {
            
            // reverse the string in a text and see if it matches the original

            Console.Clear();
            Console.WriteLine("Input the text to check for palindrome");
            string text = Console.ReadLine();

            // Convert text to lowercase and remove non-alphanumeric characters
            string cleanText = new string(text.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());

            List<char> charList = cleanText.ToList();

            // Reverse the character list efficiently
            charList.Reverse();

            bool isPalindrome = true;

            // Check for palindrome (avoid unnecessary nested loop)
            for (int i = 0; i < charList.Count / 2; i++)
            {
                if (charList[i] != charList[charList.Count - 1 - i])
                {
                    isPalindrome = false;
                    break; // Exit the loop if a mismatch is found
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"The text '{text}', is a palindrome");
            }
            else
            {
                Console.WriteLine($"The text '{text}', is not a palindrome");
            }

            Console.ReadLine();
            


        }



        // Write a function that computes the total sum of the numbers in a list using a for loop and a while loop 
        private static void TotalSum()
        {
            Console.Clear();
            // i want to collect user input
            string addPrice = "n";
            List<string> prices = new List<string>();
            int totalSum = 0;

            while (addPrice == "n")
            {
                Console.WriteLine("Enter the price of the good");
                prices.Add(Console.ReadLine());

                // Console.Write("Are you done: y/n: ");
                // addPrice = Console.ReadLine();

                if (addPrice != "y")
                {
                    Console.Write("Are you done: please enter y/n: ");
                    addPrice = Console.ReadLine();
                }

                else if (addPrice != "n")
                {
                    Console.Write("Are you done: please enter y/n: ");
                    addPrice = Console.ReadLine();
                }
                else
                {
                    addPrice = "y";
                }
            }

            foreach (string price in prices)
            {
                totalSum += int.Parse(price);
            }

            Console.WriteLine($"These is the prices of the goods bought {string.Join(",", prices)}.");
            Console.WriteLine($"You are to pay N{totalSum}.");

            Console.ReadLine();


            //     List <int> prices = new List<int> { 10, 12, 30, 50, 34};
            //     int totalSum = 0;

            //     foreach (int price in prices)
            //     {
            //         totalSum += price;
            //     }

            //     Console.WriteLine($"{totalSum}");

            //     Console.ReadLine();
            // }


        }



        // Guess my number game
        private static void GuessMe()
        {
            Console.Clear();
            Random random = new Random(); // Create a Random object for number generation (better practice)
            int guessNumber = random.Next(1, 51); // Generate a random number between 1 and 50 (inclusive)
            int tries = 0; // Keep track of the number of guesses

            Console.WriteLine(@"It is time for a guessing game!
            The computer will automatically generate a number between 1 and 50. Can you guess the number?");

            while (true)
            {
                tries++; // Increment the number of tries

                Console.Write("Enter your guess here: ");
                string playerGuessString = Console.ReadLine();

                int playerGuess;
                if (int.TryParse(playerGuessString, out playerGuess)) // Check if input can be parsed to int
                {
                    if (playerGuess < 1 || playerGuess > 50) // Check if guess is within valid range
                    {
                        Console.WriteLine("Invalid guess. Please enter a number between 1 and 50.");
                        continue; // Skip to the next iteration of the loop
                    }

                    if (playerGuess == guessNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {tries} tries!");
                        break; // Exit the loop if guess is correct
                    }
                    else if (playerGuess < guessNumber)
                    {
                        Console.WriteLine("Your guess is too low. Try again.");
                    }
                    else if (playerGuess > guessNumber)
                    {
                        Console.WriteLine("Your guess is too high. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("Do you want to play again (y/n)?");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain == "y")
            {
                GuessMe(); // Call the function again for a new game
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
            Console.ReadLine();
        }



    // NUMBER TO WORD

        public static string ConvertNumberToWords()
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                return "Zero";
            }

            // Predefined number names
            string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] hundreds = { "", "Hundred", "Thousand", "Million", "Billion", "Trillion" };

            // Split the number into groups of 3 digits (reverse order)
            List<int> groups = new List<int>();
            while (number > 0)
            {
                groups.Insert(0, number % 1000);
                number /= 1000;
            }

            string result = "";
            for (int i = 0; i < groups.Count; i++)
            {
                int group = groups[i];

                // Convert the current group (3 digits) to words using a helper function
                string groupWords = ConvertGroup(group, units, tens, hundreds[i]);

                // Add the group words with appropriate separator and "and" before the last group (modified logic)
                if (!string.IsNullOrEmpty(groupWords))
                {
                string separator = (i > 0 && !string.IsNullOrEmpty(result.Trim())) ? (i == groups.Count - 1 ? " and " : ", ") : ""; // Use comma and space for middle groups, "and" for the last group
                result = result + separator + groupWords;
                }
            }

            return result.Trim(); // Remove any leading/trailing spaces
            }

            private static string ConvertGroup(int group, string[] units, string[] tens, string hundred)
            {
            string groupWords = "";

            // Handle hundreds digit
            if (group / 100 > 0)
            {
                groupWords += units[group / 100] + " " + hundred;
                group %= 100;
            }

            // Handle tens and units digits
            if (group > 0)
            {
                if (group < 20)
                {
                groupWords += (string.IsNullOrEmpty(groupWords) ? "" : " ") + units[group];
                }
                else
                {
                groupWords += (string.IsNullOrEmpty(groupWords) ? "" : " ") + tens[group / 10] + ((group % 10) > 0 ? " " + units[group % 10] : "");
                }
            }

            Console.WriteLine("THis is group words {0}", groupWords);
            Console.ReadLine();

            return groupWords;
        }





        private static void NumberToWordForm()
        {

            // we want to run for a thousand numbers

            Console.Write("Enter any number: ");
            string userInput = Console.ReadLine();

            int numberInput;
            int.TryParse(userInput, out numberInput);


            string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] hundreds = { "", "Hundred", "Thousand", "Million", "Billion", "Trillion" };


            string[] singleDigits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            string[] teenDigits = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            string[] doubleDigits = { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

            // string hundred = "Hundred";

            // string thousand = "Thousand";

            // string million = "Million";

            // string billion = "Billion";

            // i want to split the input into a list
            // so that i can then index it to serve as hundred tens unit
            List<string> inputCharacters = new List<string>();
            
            foreach (var word in userInput)
            {
                inputCharacters.Add(string.Join(",", word));
            }

            Console.WriteLine($"to string {string.Join(",", inputCharacters)} and {inputCharacters[0]}");



            StringBuilder wordForm = new StringBuilder();

            // create a method to handle the units

            string Unit (int indexLocation )
            {
               string output = singleDigits[indexLocation];
               return output;
            }

            string Teens (int indexLocation )
            {
                string output = teenDigits[indexLocation];
                return output;
            }

            string Tens (int indexLocation )
            {
                return doubleDigits[indexLocation];
            }

            string Hundred (int indexLocation )
            {
                string wordForm = singleDigits[int.Parse(inputCharacters[0])] + " Hundred";
                return wordForm;
            }

            int numberIndex = userInput.Count();

            // for single digits

            if (numberIndex == 1 )
            {
                Console.WriteLine(Unit(numberIndex - 1));
            }

            // tens and teens
            if (numberIndex == 2)
            {
                if (inputCharacters[0] == "1")
                {
                    Console.WriteLine(Teens(1));
                }
            }



            int i = 0;
            while ( i < numberIndex )
            {

                if ( ( numberIndex - i ) == 5 )
                {
            
                    if (inputCharacters[i] == "1")
                    {
                        Console.Write( Teens( int.Parse( inputCharacters[i + 1] ) ) + " ");
                    }

                    else
                    {
                        Console.Write( Tens( int.Parse( inputCharacters[i] ) ) + " " );
                    }

                }

                if ( ( numberIndex - i ) == 4 )
                {
                    
                    Console.Write(Unit( int.Parse( inputCharacters[i] ) ) + " Thousand " );
                }

                if ( ( numberIndex - i ) == 3 )
                {
                    Console.Write(Unit( int.Parse( inputCharacters[i] ) ) + " Hundred" );
                }

                // tens and teens
                if (( numberIndex - i ) == 2)
                {
                    if (inputCharacters[i] == "1")
                    {
                        Console.Write( " And " + Teens( int.Parse( inputCharacters[i + 1] ) ) );
                    }

                    else
                    {
                        Console.Write( " And " + Tens( int.Parse( inputCharacters[i] ) ) );
                    }
                }


                if ( ( numberIndex - i ) == 1 )
                {
                    if ( inputCharacters[i] == "0")
                    {
                        Console.Write(" ");
                    }
                    else 
                    {
                        Console.Write( " " + Unit( int.Parse( inputCharacters[i] ) ) );
                    }
                }

                
                i++;

            }



            

            // int i = 0;

            // while ( i < numberIndex )
            // {

            //     // this is for unit single digits
            //     if ( numberIndex == 1 )
            //     {
            //         wordForm.Append(singleDigits[numberInput]);
            //     }


            //     // this is for the teens and tens
            //     else if ( numberIndex == 2 )
            //     {
            //         if ( numberInput < 20)
            //         {
            //             wordForm.Append(teenDigits[int.Parse(inputCharacters[1])]);
            //             break;
            //         }

            //         else if ( numberInput < 100 && numberInput > 19)
            //         {
            //             if (int.Parse(inputCharacters[1]) == 0 )
            //             {
            //                 wordForm.Append(doubleDigits[int.Parse(inputCharacters[i]) - 1]);
            //                 break;
            //             }

            //             else
            //             {
            //                 wordForm.Append(doubleDigits[int.Parse(inputCharacters[i]) - 1]);
            //                 i++;
            //                 wordForm.Append(" " + singleDigits[int.Parse(inputCharacters[i])]);
                        
            //             }
            //         }
                    
            //     }


            //     // this is for the hundreds
            //     else if ( numberIndex == 3 )
            //     {
            //         // first check if the entered number is preceeded with 0 0 e.g 400

            //         // if (int.Parse(inputCharacters[numberIndex - 1]) == 0 /*&& int.Parse(inputCharacters[numberIndex - 2 ]) == 0 */ )
            //         // [
            //         //     wordForm.Append(singleDigits[int.Parse(inputCharacters[i])] + " Hundred");
            //         // ]

            //         // wordForm.Append(singleDigits[int.Parse(inputCharacters[i])] + " Hundred and ");
                    
            //         // want to deal with the tens

            //         // wordForm.Append(doubleDigits[int.Parse(inputCharacters[i]) - 1]);

            //         // deal with units
                

                    
                    
            //         if ( int.Parse(inputCharacters[1]) == 1)
            //         {
            //             wordForm.Append(teenDigits[int.Parse(inputCharacters[numberIndex])]);
            //             break;
            //         }

            //         else if ( numberInput < 100 && numberInput > 19)
            //         {
            //             if (int.Parse(inputCharacters[1]) == 0 )
            //             {
            //                 wordForm.Append(doubleDigits[int.Parse(inputCharacters[i]) - 1]);
            //                 break;
            //             }

            //             else
            //             {
            //                 wordForm.Append(doubleDigits[int.Parse(inputCharacters[i]) - 1]);
            //                 i++;
            //                 wordForm.Append(" " + singleDigits[int.Parse(inputCharacters[i])]);
                        
            //             }
            //         }
                    
                    
            //     }

            //     i++;

            // }



            Console.WriteLine(wordForm);

            Console.ReadLine();
        }






    // TASK 4
        // student database
        private static void StudentDatabase()
        {
            Console.Clear();
            string fileName = @"C:\Users\faith\Desktop\studentDetails.txt"; // Name of the text file

            // Function to add a student
            void AddStudent(string firstName, string lastName, int id)
            {
                string studentInfo = $"{firstName},{lastName},{id}";

                // Check if ID already exists
                if (IsIdExist(id))
                {
                    Console.WriteLine($"Student with ID {id} already exists. Please enter a unique ID.");
                    return; // Exit the function if ID exists
                }

                File.AppendAllText(fileName, studentInfo + Environment.NewLine); // Append student info with newline
                Console.WriteLine("Student added successfully!");
            }


            // Function to retrieve student information by ID
            void GetStudentInfo(int id)
            {
                string[] lines = File.ReadAllLines(fileName); // Read all lines from the file

                foreach (string line in lines)
                {
                    string[] studentData = line.Split(','); // Split each line by comma
                    if (int.Parse(studentData[2]) == id) // Check if ID matches
                    {
                        Console.WriteLine($"Student ID: {id}");
                        Console.WriteLine($"First Name: {studentData[0]}");
                        Console.WriteLine($"Last Name: {studentData[1]}");
                        return; // Exit the loop after finding the student
                    }
                }

                Console.WriteLine($"Student with ID {id} not found.");
            }

            // Function to check if ID exists
            bool IsIdExist(int id)
            {
                string[] lines = File.ReadAllLines(fileName); // Read all lines from the file

                foreach (string line in lines)
                {
                    string[] studentData = line.Split(','); // Split each line by comma
                    if (int.Parse(studentData[2]) == id) // Check if ID matches
                    {
                        return true; // ID exists
                    }
                }

                return false; // ID not found
            }

            // User interaction loop
            
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Get Student Information");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter Student ID: ");
                        int studentId;
                        if (int.TryParse(Console.ReadLine(), out studentId))
                        {
                            AddStudent(firstName, lastName, studentId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID. Please enter a number.");
                        }
                        break;
                    case "2":
                        Console.Write("Enter Student ID to retrieve information: ");
                        int searchId;
                        if (int.TryParse(Console.ReadLine(), out searchId))
                        {
                            GetStudentInfo(searchId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID. Please enter a number.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                    
                }

                
                
            }
            
        }

        // end of while loop


       
    }


    // public class MyMethods
    // {
        
    //     // i want to create a method for calculating the max of an object

    //     public static void Main()
    //     {

    //     }

    //     private static int FindMax(List<int> numbers)
    //     {
    //         // i want to return the max of number in a list

    //         if (numbers == null || numbers.Count == 0)
    //         {
    //             throw new ArgumentException("The list cannot be null or empty.");
    //         }

    //         int max = numbers[0]; // Initialize max with the first element

    //         for (int i = 1; i < numbers.Count; i++)
    //         {
    //             if (numbers[i] > max)
    //             {
    //                 max = numbers[i];
    //             }
    //         }

    //         return max;

    //     }

    // }

}