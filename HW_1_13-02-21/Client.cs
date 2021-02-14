using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_13_02_21
{
    class Client
    {
        public static List<Client> ClientList = new List<Client>();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public decimal Balance { get; set; }
        public string PassportNO { get; set; }
        public Client(int id, string firstName, string lastName, string middleName, decimal balance, string passportNO)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Balance = balance;
            PassportNO = passportNO;
        }
        public static int ID = 0;
        public static void Select()
        {
            foreach (var item in ClientList)
            {
                Console.WriteLine($"Id: {item.Id} FirstName: {item.FirstName}, LastName: {item.LastName}, MiddleName: {item.MiddleName}, " +
                    $"Balace: {item.Balance}, PassportNO: {item.PassportNO}");
            }
        }
        public static void Insert()
        {
            Console.WriteLine("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());
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
            Client clients = new Client(Id,FirstName, LastName, MiddleName, Balance, PassportNO);
            ClientList.Add(clients);
        }
        public static void UpdateById()
        {
            Console.WriteLine("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());
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
            Client clients = new Client(Id, FirstName, LastName, MiddleName, Balance, PassportNO);
            foreach (var i in ClientList)
            {
                if (Id == i.Id)
                {
                    int index = ClientList.IndexOf(i);
                    ClientList[index] = clients;
                    break;
                }
            }
        }
        public static void DeleteById()
        {
            Console.Write("Id: "); 
            int Id = int.Parse(Console.ReadLine());
            foreach (var item in ClientList)
            {
                if (Id == item.Id)
                {
                    ClientList.Remove(item);
                    Console.WriteLine("Элемент удален из списка");
                    break;
                }
            }
        }
    }
}
