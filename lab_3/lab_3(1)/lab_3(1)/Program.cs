using System;

namespace lab_3_1_
{
    internal class Program
    {
        static void Main()
        {
            Office.Workers.AddRange(new Employee[] {
                new Trainee() { Name = "Bob Brown" },
                new Engineer(900) { Name = "Max Green" },           //додаємо працівників ло списку
                new Engineer(1200) { Name = "Elly Easycot" },      //перед цим створивши класи кожної професії
                new Engineer(2000) { Name = "Josh Wellington" },
                new Manager(1500) { Name = "Paris Scott" },
            });

            Office.PrintAllWorkers();                     //отримуємо інфо про кожного працівника

            ((Manager)Office.Workers[4]).Fire(Office.Workers[2]);   //виконуємо метод для звільненя працівника
            Console.WriteLine(Office.Workers[2].GetWorkerInfo());
            Console.WriteLine(" ");

            ((PaidWorker)Office.Workers[1]).PayRise(1200);          //виконуємо метод підвищення зарплатні для працівника
            Console.WriteLine(Office.Workers[1].GetWorkerInfo());

            Console.WriteLine();
            Office.PrintAllWorkers();                  //виводимо оновлену інфо про всіх працівників 

            Console.ReadKey();
        }
    }
    
}
    

