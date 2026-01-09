using System;
using System.Collections.Generic;


namespace Labb4
{
    public class Person
    {

        // properties for Person 

        public Hair Hair { get; private set; }

        public Gender Gender { get; private set; }

        public string EyeColour { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        // Creating a constructor for Person object 
        public Person(DateTime dateofbirth, Gender gender, Hair hair, string eyecolour)

        {
            Hair = hair;
            Gender = gender;
            DateOfBirth = dateofbirth;
            EyeColour = eyecolour;

        }

        // custom string to convert and format a summary of Person 
        public override string ToString()
        {
            return
                $"Listed Person:\n" + 
                $"\nDate of birth: {DateOfBirth:yyyy/MM/dd}" +
                $"\nGender is: {Gender}" +
                $"\nHair is: {Hair.HairColour} & {Hair.HairLength} in length" +
                $"\nEye colour is: {EyeColour}";


        }
       

    }

}

 
    

