using System;

namespace CSLighrtMedcinePoliclinicN8
{
    class Program
    {
        static void Main(string[] args)
        {
            int queueOldLadies;
            int timeReceiptInMinutes = 10;
            int munutesPerHour = 60;
            int waitingTimeInHours;
            int waitingTimeInMinutes;

            Console.Write("Введите количество старушек: ");
            queueOldLadies = Convert.ToInt32(Console.ReadLine());

            waitingTimeInHours = queueOldLadies * timeReceiptInMinutes / munutesPerHour;
            waitingTimeInMinutes = queueOldLadies * timeReceiptInMinutes % munutesPerHour;

            Console.WriteLine($"Вы должны отстоять в очереди: " +
                              $"{waitingTimeInHours} часа и {waitingTimeInMinutes} минут.");
            Console.ReadLine();
        }
    }
}
