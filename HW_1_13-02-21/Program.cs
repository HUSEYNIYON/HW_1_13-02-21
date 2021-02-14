using System;
using System.Collections.Generic;
using System.Threading;

namespace HW_1_13_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Client.Insert();
                        break;
                    case 2:
                        Client.Select();
                        break;
                    case 3:
                        Client.UpdateById();
                        break;
                    case 4:
                        Client.DeleteById();
                        break;
                    default:
                        return;
                        break;
                }
            }
            //Client.Insert();
            //Client.Select();
            //Client.Update();
            //Client.Select();
            //Client.UpdateById();
            //Client.DeleteById();
        }
    }
}
