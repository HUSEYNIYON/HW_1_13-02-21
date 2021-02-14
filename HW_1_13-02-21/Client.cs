using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_13_02_21
{
    class Client
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public decimal Balance { get; set; }
        public string PassportNO { get; set; }
        public Client(Guid id, string firstName, string lastName, string middleName, decimal balance, string passportNO)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Balance = balance;
            PassportNO = passportNO;
        }
    }
}
