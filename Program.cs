using System;
using System.Collections.Generic;


namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declaring values for properties 
            string eyecolour = "Blue"; 
            Hair hair = new Hair { HairColour = "blond", HairLength = "short" }; 
            Gender gender = Gender.Woman; 
            DateTime dateofbirth = new DateTime(1990, 01, 01);

            // create and allocate a new person1 object and applying a constructor 
            Person person = new Person(dateofbirth, gender, hair, eyecolour);
            // create new object for PersonManager class
            var manager = new PersonManager();
            // create new object for InputValidator class
            var validator = new InputValidator();
            ///// 

            // call person.ToString method + add person to listofpersons 
            Console.WriteLine(person.ToString());
            manager.addPerson(person);
            Console.WriteLine();
            
            // while loop for main menu to keep it there
            while (true)
            {
                Console.WriteLine($"\n\n=== Menu ===\n");
                Console.WriteLine(
                    $"1: Add a person\n" +
                    $"2: See the list of persons\n" +
                    $"3: Exit the program");

                // input from user for new person through methods from InputValidator
                int userInput =  validator.GetValidUserInput();

                    //switch case for menu choices
                    switch (userInput)
                    {
                        // case 1 - add a new person 
                        case 1:
                     
                            // input from user for new person through methods from InputValidator
                            int genderNumber = validator.GetValidGender();
                            
                            DateTime dateOfBirth = validator.GetValidBirthDate();

                            string eyeColour = validator.GetValidEyeColour();

                            string hairColour = validator.GetValidHairColour();

                            string hairLength = validator.GetValidHairLength();


                            // create and declare another hair struct variable for new person
                            Hair hair2 = new Hair { HairColour = hairColour, HairLength = hairLength };
                            
                            // Cast the input to Gender enum
                            Gender genderInput = (Gender)genderNumber;
                       
                            // create and declare a new person object and add to the list 
                            Person newPerson = new Person(dateOfBirth, genderInput, hair2, eyeColour);
                            // add the person tp listofpersons through PersonManager
                            manager.addPerson(newPerson);

                            // clear console + print out the added person data 
                            Console.Clear();
                            Console.WriteLine($"{newPerson}\n\n" +
                            $"+++ Successfully added to the list! +++");
                            Console.WriteLine();
                            continue;

                    // case 2 - see the listed persons
                    // call the ListPersons method from personmanager class 
                    // back to menu 
                    case 2:
                        Console.Clear();
                        manager.ListPersons(); 
                        continue;              

                    // case 3 - exit
                    // break the loop 
                    case 3:
                        Console.WriteLine("You chose to exit the program, press any key to exit"); 
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }