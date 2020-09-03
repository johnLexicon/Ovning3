using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Inkapsulering
{
    public class Person
    {
        private string fName;
        private string lName;
        private int age;
        private double height;
        private double weight;

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname cannot be null or empty");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Firstname must contain 2-10 characters");
                }
                fName = value;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lastname cannot be null or empty");
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Lastname must contain 3-15 characters");
                }
                lName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0) //Måste jämföra med value som innehåller värdet som kommer in annars jämför du med värdet du redan har.
                {
                    throw new ArgumentException("Age cannot be less than zero");
                }
                else
                {
                    age = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
