using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotsoftaskspascal
{
    class Program
    {
        static void task1()
        {
            System.Console.WriteLine("Hello world!");
        }
        static void task2()
        {
            System.Console.WriteLine("Вывести на экран три введенных числа в порядке обратном их вводу. \nВведите три числа через пробел");
            string[] temp = Console.ReadLine().Split(' ');
            int a, b, c;
            a = Int32.Parse(temp[0]);b = Int32.Parse(temp[1]); c = Int32.Parse(temp[2]);
            Console.WriteLine(c + " " + b + " " + a);
            //Stack<int> st = new Stack<int>();
            //string[] temp = Console.ReadLine().Split(' ');
            //foreach(string str in temp)
            //{
            //    st.Push(Int32.Parse(str));
            //}
            //Console.WriteLine();
            //while(st.Count() != 0)
            //{
            //    Console.Write(st.Pop() + " ");
            //}
        }
        static void task3()
        {
            Console.WriteLine("Вернуть квадрат числа");
            Console.WriteLine("Введите число");
            int num;
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num * num);
        }
        static void task4()
        {
            Console.WriteLine("Вернуть реверснутую версию трехзначного числа");
            Console.WriteLine("Вводи число");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine((num % 10) + "" + ((num / 10) % 10)+ ""+ ((num / 100)));
        }
        static void task5()
        {
            Console.WriteLine("Получить количество единичных разрядо в двоичной системе введенного числа");
            Console.WriteLine("Введите число");
            string temp = Convert.ToString(Int32.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Эквивалент в двоичной системе: " + temp);
            int result=0;
            foreach(char ch in temp)
            {
                if (ch == '1')
                    result++;
            }
            Console.WriteLine("Result: " + result);
        }
        static void task6()
        {
            Console.WriteLine("Вывести наиб. число");
            Console.WriteLine("Введите числа через пробел");
            int max = 0;
            foreach (string st in Console.ReadLine().Trim().Split(' '))
            {
                if (Convert.ToInt32(st) > max)
                    max = Convert.ToInt32(st);
            }
            Console.WriteLine("Max: " + max);
        }
        static void task8()
        {
            Console.WriteLine("Вывести название дня недели по его номеру");
            Console.WriteLine("Номер дня: ");
            int num = Int32.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("DUNNO");
                    break;

            }
        }
        static void task9()
        {
            Console.WriteLine("Проверить является ли 4х значное число палиндромом");
            string num;
            num = Console.ReadLine();
            if ((num[0] == num[3]) && (num[1] == num[2]))
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void task10()
        {
            Console.WriteLine("Дано четырехзначное число. Проверить, является ли оно «счастливым билетом».");
            string temp = Console.ReadLine();
            int left=0, right=0;
            for(int i=0; i<temp.Length/2;i++)
            {
                left += int.Parse(temp[i].ToString());
                right += int.Parse(temp[temp.Length - i - 1].ToString());
            }
            Console.WriteLine("left " + left + " right " + right);
            Console.WriteLine(left == right);

        }
        static void task11()
        {
            Console.WriteLine("Дано число, проверить является ли его двоичное представление полиндромом.");
            string n = Convert.ToString(int.Parse(Console.ReadLine()),2);
            Console.WriteLine("Двоичное представление: " + n);
            bool bl = true;
            for(int i=0;i<n.Length/2;i++)
            {
                if (int.Parse(n[i].ToString()) != (int.Parse(n[n.Length - i - 1].ToString())))
                    bl = false;
            }
            Console.WriteLine(bl);
        }
        static void task12()
        {
            Console.WriteLine("Решить квадратное уравнение, давай сюда ABC");
            string[] temp = Console.ReadLine().Split(' ');
            double A = double.Parse(temp[0]), B = double.Parse(temp[1]), C = double.Parse(temp[2]) ;
            double D;
            D = Math.Pow(B, 2) - 4 * A * C;
            if (D < 0)
            {
                Console.WriteLine("No solutions");
            }
            else if (D == 0)
            {
                Console.WriteLine("Ur solution is X=" + ((-B) / (2 * A)));
            } else
            {
                Console.WriteLine("2 Solutions X1=" + (((-B) + Math.Sqrt(D)) / (2 * A)) + " X2=" + (((-B) - Math.Sqrt(D)) / (2 * A)));
            }
        }
        static void task13()
        {
            Console.WriteLine("Вывести все числа до заданного");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<= n;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void task14()
        {
            Console.WriteLine("Вывести наибольший делитель");
            int n = int.Parse(Console.ReadLine()), i;
            for(i = n-1;n%i != 0;i--)
            {
            }
            Console.WriteLine("Твой делитель, ёба " + i);
        }
        static void task15()
        {
            Console.WriteLine("Вывести наименьший делитель");
            int n = int.Parse(Console.ReadLine()), i;
            for (i = 2; n % i != 0; i++)
            {
            }
            Console.WriteLine("Твой делитель, ёба " + i);
        }
        static void task16()
        {
            Console.WriteLine("Подсчитать кол-во делителей");
            int n = int.Parse(Console.ReadLine()), count=0;
            for(int i = 1; i<= n;i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Кол-во делителей: " + count);
        }
        static void task17()
        {
            Console.WriteLine("Является ли число простым");
            int n = int.Parse(Console.ReadLine()), count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count == 2 ? true : false);
        }
        static void task18()
        {
            Console.WriteLine("Вывести все простые числа до заданного");
            Stack<int> kek = new Stack<int>();
            int n = int.Parse(Console.ReadLine()), count = 0;
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    kek.Push(j);
                }
                count = 0;
            }
            while(kek.Count != 0)
            {
                Console.WriteLine(kek.Pop());
            }
        }
        static void task19()
        {
            Console.WriteLine("Вывести N простых чисел");
            Stack<int> kek = new Stack<int>();
            int n = int.Parse(Console.ReadLine()), count = 0;
            for (int j = 1; kek.Count != n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    kek.Push(j);
                }
                count = 0;
            }
            while (kek.Count != 0)
            {
                Console.WriteLine(kek.Pop());
            }
        }
        static void task20()
        {
            Console.WriteLine("Подсчитать кол-во делителей");
            int n = int.Parse(Console.ReadLine()), sum=0;
            Stack<int> kek = new Stack<int>();
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    kek.Push(i);
                }
            }
            while(kek.Count != 0)
            {
                sum += kek.Pop();
            }
            Console.WriteLine(sum == n ? true : false);
        }

        static void Main(string[] args)
        {
            int decision = 0;
            string tryagainchar;
            bool tryagain = false;
            while (decision != 69)
            {
                Console.Clear();
                if (!tryagain)
                {
                    Console.WriteLine("Для проверки задания введите его номер (1-20).");
                    decision = Int32.Parse(Console.ReadLine());
                }
                switch (decision)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    case 7:
                        task6();
                        break;
                    case 8:
                        task8();
                        break;
                    case 9:
                        task9();
                        break;
                    case 10:
                        task10();
                        break;
                    case 11:
                        task11();
                        break;
                    case 12:
                        task12();
                        break;
                    case 13:
                        task13();
                        break;
                    case 14:
                        task14();
                        break;
                    case 15:
                        task15();
                        break;
                    case 16:
                        task16();
                        break;
                    case 17:
                        task17();
                        break;
                    case 18:
                        task18();
                        break;
                    case 19:
                        task19();
                        break;
                    case 20:
                        task20();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Try again? y/Y or n/N");
                tryagainchar = Console.ReadLine();
                if (tryagainchar.Equals("y") || tryagainchar.Equals("Y"))
                {
                    tryagain = true;
                }
                else tryagain = false;

            }
        }
    }
}
