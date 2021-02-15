using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_13_02_21
{
    class Client
    {
        public static List<Client> ClientList = new List<Client>();
        public static List<Client> CheckClientList = new List<Client>();
        
        public static int newID ;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public decimal Balance { get; set; }
        public string PassportNO { get; set; }
        public Client(int ID,string firstName, string lastName, string middleName, decimal balance, string passportNO)
        {
            Id = ID;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Balance = balance;
            PassportNO = passportNO;
        }

        public Client(string firstName, string lastName, string middleName, decimal balance, string passportNO)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Balance = balance;
            PassportNO = passportNO;
        }

        public static void Select()
        {
            foreach (var item in ClientList)
            {
                Console.WriteLine($"Id: {item.Id}|\t FirstName: {item.FirstName}|\t LastName: {item.LastName}|\t MiddleName: {item.MiddleName}|\t " +
                    $"Balace: {item.Balance}|\t PassportNO: {item.PassportNO}");
            }
        }
        public static void Insert()
        {
            Console.Clear();
            Console.Write("Enter FirstName: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter LastName: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter MiddleName: ");
            string MiddleName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            var Balance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter PassportNO: ");
            var PassportNO = Console.ReadLine();
            newID++;
            Client clients = new Client(newID,FirstName, LastName, MiddleName, Balance, PassportNO);
            ClientList.Add(clients);
            CheckClientList.Add(clients);
        }
        public static void UpdateById()
        {
            Console.Clear();
            Console.Write("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Enter FirstName: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter LastName: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter MiddleName: ");
            string MiddleName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            var Balance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter PassportNO: ");
            var PassportNO = Console.ReadLine();
            Client clients = new Client(Id,FirstName, LastName, MiddleName, Balance, PassportNO);
            foreach (var item in ClientList)
            {
                if (Id == item.Id)
                {
                    int index = ClientList.IndexOf(item);
                    ClientList[index] = clients;
                    break;
                }
            }
        }
        public static void DeleteById()
        {
            Console.Clear();
            Console.Write("Id: "); 
            int Id = int.Parse(Console.ReadLine());
            foreach (var item in ClientList)
            {
                if (Id == item.Id)
                {
                    CheckClientList.Remove(item);
                    ClientList.Remove(item);
                    GetRed(); Console.WriteLine("Элемент удален из списка!"); GetWhite();
                    break;
                }
            }
        }
        public static void FindUpdatedBalance(object objects)
        {
            List<Client> list = objects as List<Client>;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Balance > CheckClientList[i].Balance)
                {
                    Client.GetGreen();
                    Console.WriteLine($"ID:{list[i].Id}\nБаланс до изменения:{CheckClientList[i].Balance}\nБаланс после изменения:{list[i].Balance}\nРазница: +{list[i].Balance - CheckClientList[i].Balance}");
                    Client.GetWhite();
                    CheckClientList[i].Balance = list[i].Balance;
                }
                else if (list[i].Balance < CheckClientList[i].Balance)
                {
                    Client.GetRed();
                    Console.WriteLine($"ID:{list[i].Id}\nБаланс до изменения:{CheckClientList[i].Balance}\nБаланс после изменения:{list[i].Balance}\nРазница: {list[i].Balance - CheckClientList[i].Balance}");
                    Client.GetWhite();
                    CheckClientList[i].Balance = list[i].Balance;
                }
            }
        }
        public static void GetGreen() => Console.ForegroundColor = ConsoleColor.Green;
        public static void GetWhite() => Console.ForegroundColor = ConsoleColor.White;
        public static void GetRed() => Console.ForegroundColor = ConsoleColor.Red;
    }
}
