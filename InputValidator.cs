using System;


namespace Labb4
{
    public class InputValidator
    {
        // method to validate main menu input 
        public int GetValidUserInput()
        {
            // while loop until user enter a valid input for menu choice 
            while (true)
            {
                // if statement to check that input is a number 
                int userInput;
                Console.Write($"Enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out userInput))

                {
                    Console.WriteLine("\n!!! -Invalid input-!!!\nOnly enter a number\n\n### Try again! ###\n");
                    continue;
                }
                // if statement to check that input is a valid choice 1-3 
                else if (userInput > 3 || userInput < 1)
                {

                    Console.WriteLine("\n!!! -Invalid input-!!!\nWrong number\n\n### Try again! ###\n");
                    continue;
                }
                // return the valid value of userInput and exit loop 
                Console.Clear();
                return userInput;
            }
        }
        

        // method to validate Gender input 
        public int GetValidGender()
        {
            while (true)
            {

                Console.WriteLine("Add a new person below:\n");
                Console.Write("Gender: \n0 = Man\n1 = Woman\n2 = Non Binary\n3 = Other\nEnter number ");
                // declaring input to a variable and null check 
                string input = (Console.ReadLine() ?? "").Trim();

                // if statement to check that input is one character only and between 0-3 
                if (input.Length == 1 && int.TryParse(input, out int genderNumber) && genderNumber >= 0 && genderNumber <= 3)
                {
                    // return the valid value of genderNumber and exit loop 
                    return genderNumber; 
                }
                else
                {
                    // error message inside the loop to make let the user try again 
                    Console.WriteLine("\n!!! -Invalid Input- !!!\n\nEnter a valid number: [0, 1, 2 or 3]\n\n       ### Try again! ###\n");
                }
            }
        }

        // method for BirthDate input 
        public DateTime GetValidBirthDate()
        {
            while (true)
            {

                Console.Write("Enter date of birth (yyyy-mm-dd): ");
                string input = Console.ReadLine() ?? ""; // a null check  

                // validation of the input to match datetime format
                if (DateTime.TryParse(input, out DateTime dateOfBirth))
                {
                    return dateOfBirth;
                }

                // error message inside the loop to make let the user try again 
                Console.WriteLine("\n!!! -Invalid date format- !!!\n\n       ### Try again! ###\n");
            }
        }

        // method for Eyecolour input
        public string GetValidEyeColour()
        {

            while (true)
            {
                // a null check + converting input to lower casing just for aesthetic 
                Console.Write("\n*Eye colour*\nEnter eye colour: ");
                string eyeColour = (Console.ReadLine() ?? "").Trim().ToLower(); 

                // validation of the input, cant be an empty string or numbers
                if (!string.IsNullOrWhiteSpace(eyeColour) && !double.TryParse(eyeColour, out _))
                {
                    // return the valid eyecolour 
                    return eyeColour;

                }
                // error message inside the loop to make let the user try again 
                Console.WriteLine("\n!!! -Ivalid Input- !!!\nCant be empty or a number!\n\n       ### Try again! ###");

            }
        }


        // method for haircolour input 
        public string GetValidHairColour()
        {
            while (true)
            {
                // a null check + converting input to lower casing just for aesthetic 
                Console.Write("\n*Hair colour*\nEnter hair colour: ");
                string hairColour = (Console.ReadLine() ?? "").Trim().ToLower(); 

                // validation of the input, check for empty string, numbers
                if (!string.IsNullOrWhiteSpace(hairColour)
                       && !double.TryParse(hairColour, out _))
                    {
                    // return the input if it passes the if statement 
                    return hairColour;

                    }
                // error message inside the loop to make let the user try again 
                Console.WriteLine("\n!!! -Invalid number- !!!\nCant be empty or a number!\n\n       ### Try again! ###\n\n");
            }
               

        }
        
        // method for hairlength input 
        public string GetValidHairLength()
        {
            while (true)
            {
                // a null check of the input + trim method to remove any whitespace + converting the input to lower casing to match the if statements below 
                Console.Write("\n*Hair length*\n---short, medium or long---\nEnter hair length: ");
                string hairLength = (Console.ReadLine() ?? "").Trim().ToLower();

                // validation of the input, check for empty string, numbers + also 3 specifc right answers 
                if (!string.IsNullOrWhiteSpace(hairLength)
                    && !int.TryParse(hairLength, out _) 
                    && (hairLength == "short" ||  hairLength == "medium" || hairLength == "long"))
                {
                    return hairLength;
                }
                // error message inside the loop to make let the user try again 
                Console.WriteLine();
                Console.WriteLine("\n!!! -Invalid Input- !!!\n\n*Hair length*\nMust be:\nshort, medium or long.\n\n### Try again! ###\n\n");

            }
        }



    }
}
