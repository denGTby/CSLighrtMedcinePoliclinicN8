using System;

namespace CSLighrtMedcinePoliclinicN8
{
    class Program
    {
        static void Main(string[] args)
        {
            int queueOldLadies;
            int timeReceipt = 10;
            int oneHour = 60;
            int hours;
            int minutes;

            Console.Write("Введите количество старушек: ");
            queueOldLadies = Convert.ToInt32(Console.ReadLine());

            hours = queueOldLadies * timeReceipt / oneHour;
            minutes = queueOldLadies * timeReceipt % oneHour;

            Console.WriteLine($"Вы должны отстоять в очереди: " +
                              $"{hours} часа и {minutes} минут.");
            Console.ReadLine();
        }
    }
}
