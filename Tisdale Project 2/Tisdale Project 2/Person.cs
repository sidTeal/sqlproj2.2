using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tisdale_Project_2
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private DateTime dateOfBirth;

        protected string FirstName
        {
            get => firstName;
            set {
                if (!value.Any(char.IsDigit) && value.Length > 1)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name must be at least two letters long and cannot contain any digits.");
                 }
            }
        }

        protected string LastName
        {
            get => lastName;
            set
            {
                if (!value.Any(char.IsDigit) && value.Length > 1)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name must be at least two letters long and cannot contain any digits.");
                 }
            }
        }

        protected string Address
        {
            get => address;
            set
            {
                if (value.Length > 5)
                {
                    address = value;
                }
                else
                {
                    throw new ArgumentException("Address name must be at least 6 characters long.");
                }
            }
        }

        protected DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        
        protected Person(string firstName, string lastName, string address, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
    }
}
