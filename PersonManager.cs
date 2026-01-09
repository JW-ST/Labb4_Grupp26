using System;
using System.Collections.Generic;


namespace Labb4
{


    public class PersonManager
    {
        // a list of the person class to store the added person objects 
        private readonly List<Person> listOfPersons = new List<Person>(); 

        // method to add persons to the list 
        public void addPerson(Person p)
        {

            listOfPersons.Add(p);

        }

        // method to show the list 
        public void ListPersons()
        {

            if (listOfPersons.Count == 0)
            {
                Console.WriteLine("\nThe list is empty - add a person\n");
                return;
            }
                foreach (var p in listOfPersons)
                {
                    Console.WriteLine($"+++ Person Data +++\n\n" +
                        $" {p}\n\n _______________________\n\n ");

                }
        }



    }
}
    
