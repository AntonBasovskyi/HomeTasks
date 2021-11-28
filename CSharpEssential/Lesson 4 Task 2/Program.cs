using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3
метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop()
соответственно.
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
Написать программу, которая выполняет проигрывание и запись.

 */

namespace Lesson_4_Task_2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Запись проигрывается");
        }

        public void Pause(bool isIPlayable = true)
        {
            if (isIPlayable)
                (this as IPlayable).Pause();
            else
                (this as IRecordable).Pause();
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Запись приостановлена для интерфейса IPlayable");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Запись приостановлена для интерфейса Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Запись завершена");
        }

        public void Record()
        {
            Console.WriteLine("Запись пошла");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string action = default;
            Player player = new Player();

            IPlayable playable = player;
            IRecordable recordable = player;

            while (action != "стоп")
            {
                Console.WriteLine("Выберите действие:\n" +
                                  "воспроизвести | записать | пауза | стоп");

                action = Console.ReadLine();
                if (action == "воспроизвести")
                    player.Play();
                else if (action == "записать")
                    player.Record();
                else if (action == "пауза")
                    player.Pause();
                else if (action == "стоп")
                    player.Stop();
            }

            Console.ReadKey();
        }
    }
}
