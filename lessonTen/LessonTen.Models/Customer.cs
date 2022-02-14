using System;

namespace LessonTen.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public Customer(string firstName, string lastName, string fullName, string email, string homeAddress, string workAddress)
        {
            CustomerId = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Email = email;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
        }

        public Customer()
        {
        }
    }
}
