using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_13_02_21
{
    class Client
    {
        public static List<Client> ClientList = new List<Client>();

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
        public static void Select()
        {
            
        }
        public static void Insert()
        {
            Console.WriteLine("Enter FirstName: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter MiddleName: ");
            string MiddleName = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            var Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter PassportNO: ");
            var PassportNO = Console.ReadLine();
        }
    }
}
