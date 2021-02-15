using System;
using System.Collections.Generic;
using System.Threading;

namespace HW_1_13_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(Client.FindUpdatedBalance);
            Timer timer = new Timer(timerCallback, Client.ClientList, 0, 1000);
            while (true)
            {
                Console.WriteLine(@"Выбирите комманду:
                        1. Вставить ---> 1
                        2. Выбрать  ---> 2
                        3. Изменить ---> 3
                        4. Удалять  ---> 4");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Thread insert = new Thread(new ThreadStart(Client.Insert));
                        insert.Start(); insert.Join();
                        break;
                    case 2:
                        Thread select = new Thread(new ThreadStart(Client.Select));
                        select.Start(); select.Join();
                        break;
                    case 3:
                        Thread update = new Thread(new ThreadStart(Client.UpdateById));
                        update.Start(); update.Join();
                        break;
                    case 4:
                        Thread delete = new Thread(new ThreadStart(Client.DeleteById));
                        delete.Start(); delete.Join();
                        break;
                    default:
                        Console.WriteLine("Не правильная команда!");
                        break;
                }
            }   
        }
    }
}
