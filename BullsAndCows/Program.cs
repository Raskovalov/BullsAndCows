using System;
using BullsAndCows;

namespace BullsAndCows
{
    class BullCows
    {
        Random rand = new Random();

        public int number;
        public int bulls;
        public int cows;

        public BullCows()
        {
            this.number = rand.Next(0, 100);
            this.bulls = 0;
            this.cows = this.number.ToString().Length;
        }

        List<int> BullsCows(int num)
        {
            List<int> BullsCows = new List<int>();
            int x = 0;

            foreach(char i in Convert.ToString(num)) 
            {
                foreach(char u in Convert.ToString(this.number)) 
                {
                    if (u == i)
                    {
                        x += 1;
                        break;
                    }
                }
            }

            BullsCows.Add(x);
            BullsCows.Add(this.cows - x);

            return BullsCows;
        }

        int ReadNumber()
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        void go()
        {
            int x = 0;

            Console.WriteLine($"Коров: {this.cows}");
            while (true)
            {
                int ev = 1;
                int num = ReadNumber();
                List<int> bullsCows = new List<int>();
                bullsCows = BullsCows(num);

                if (bullsCows[1] == 0) { 
                    if (num == this.number)
                    {
                        Console.WriteLine($"Игра закончена, Вы выйграли, отгаданное число: {this.number},   Попыток: {x}");
                        ev = 0;
                        break;
                    }
                }

                if(ev == 1)
                {
                    Console.WriteLine($"Коров: {bullsCows[1]}, Быков: {bullsCows[0]}, Попытка: {x}");
                }

                x += 1;
            }
        }

        static void Main()
        {
            BullCows b = new BullCows();
            b.go();

            Console.WriteLine("Победа!!");
            Console.ReadLine();
        }
    }
}

