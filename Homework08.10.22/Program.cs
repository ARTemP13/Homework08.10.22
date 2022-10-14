using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Homework08._10._22
{
    internal class Program
    {
        
        struct Student
        {
            
            public string name;
            public string suname;
            public int year;
            public string exam;
            public int points;

        }

        struct People
        {
            public int id;
            public string name;
            public byte NumberProblem;
            public string problem;
            public byte um;
            public byte temp;
        }
        static void Team(int[] a, int[] b)
        {
            int t = 0;
            int p = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 5)
                {
                    t++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 5)
                {
                    p++;
                }
            }
            if (p == t)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг -пончик! Ни для кого пива!");
            }

        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1.");
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            Student student1 = new Student();
            student1.name = "Артем";
            student1.suname = "Першунин";
            student1.year = 2004;
            student1.exam = "Физика";
            student1.points = 256;

            Student student2 = new Student();
            student2.name = "Илназ";
            student2.suname = "Мухетдинов";
            student2.year = 2003;
            student2.exam = "Информатика";
            student2.points = 263;

            Student student3 = new Student();
            student3.name = "Элина";
            student3.suname = "Галимова";
            student3.year = 2004;
            student3.exam = "Английский";
            student3.points = 262;

            Student student4 = new Student();
            student4.name = "Маша";
            student4.suname = "Головина";
            student4.year = 2004;
            student4.exam = "Английский";
            student4.points = 258;

            Student student5 = new Student();
            student5.name = "Азат";
            student5.suname = "Сайфуллин";
            student5.year = 2004;
            student5.exam = "Информатика";
            student5.points = 254;

            Student student6 = new Student();
            student6.name = "Аделина";
            student6.suname = "Гильфанова";
            student6.year = 2004;
            student6.exam = "Английский";
            student6.points = 253;

            Student student7 = new Student();
            student7.name = "Амир";
            student7.suname = "Сагдуллин";
            student7.year = 2004;
            student7.exam = "Информатика";
            student7.points = 250;

            Student student8 = new Student();
            student8.name = "Ильдар";
            student8.suname = "Ахметов";
            student8.year = 2004;
            student8.exam = "Информатика";
            student8.points = 249;

            Student student9 = new Student();
            student9.name = "Никита";
            student9.suname = "Богомолов";
            student9.year = 2004;
            student9.exam = "Информатика";
            student9.points = 245;
            Student student10 = new Student();
            student10.name = "Диана";
            student10.suname = "Хамидуллина";
            student10.year = 2004;
            student10.exam = "Английский";
            student10.points = 245;

            students.Add(student1.suname, student1);
            students.Add(student2.suname, student2);
            students.Add(student3.suname, student3);
            students.Add(student4.suname, student4);
            students.Add(student5.suname, student5);
            students.Add(student6.suname, student6);
            students.Add(student7.suname, student7);
            students.Add(student8.suname, student8);
            students.Add(student9.suname, student9);
            students.Add(student10.suname, student10);
            Console.WriteLine("Меню: \n Введите 'Новый студент' - чтобы добавить нового студента \n Введите 'Удалить' - чтобы удалить студента\n Введите 'Сортировать' - чтобы расставитьь студентов по балллам");
            string str = Console.ReadLine();
            switch (str)
            {
                case "Новый студент":
                    Student student11 = new Student();
                    Console.Write("Введите имя студента: ");
                    student11.name = Console.ReadLine();
                    Console.Write("Введите фамилию студента: ");
                    student11.suname = Console.ReadLine();
                    Console.Write("Введите год рождения студента: ");
                    student11.year = int.Parse(Console.ReadLine());
                    Console.Write("Введите экзамен студента: ");
                    student11.exam = Console.ReadLine();
                    Console.Write("Введите баллы студента: ");
                    student11.points = int.Parse(Console.ReadLine());
                    students.Add(student11.suname, student11);
                    Console.WriteLine("Cтудент добавлен");
                    break;
                case "Удалить":
                    Console.WriteLine("Введите фамилию студента: ");
                    string surname = Console.ReadLine();
                    students.Remove(surname);
                    Console.WriteLine("Cтудент удален!!!");
                    break;
                case "Сортировать":
                    var sorted = students.OrderBy(x => x.Value.points).ToDictionary(x => x.Key, x => x.Value.points);
                    Console.WriteLine(String.Join("\n", sorted));
                    break;
                    default:
                    Console.WriteLine("Ошибка!");
                    break;
                    
            }
            Console.ReadKey();


            Console.WriteLine("Задание 2.");
            Console.WriteLine("Введите кол-во учасников в 1 команде");
            int t = int.Parse(Console.ReadLine());
            int[] team1 = new int[t];
            Console.WriteLine("Введите кол-во учасников в 2 команде");
            int h = int.Parse(Console.ReadLine());
            int[] team2 = new int[h];
            Console.WriteLine("Введите баллы, которые собрали 1 команда");
            for (int i = 0; i < t; i++)
            {
                team1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите баллы, которые собрали 2 команда");
            for (int i = 0; i < h; i++)
            {
                team2[i] = int.Parse(Console.ReadLine());
            }
            Team(team1, team2);
            Console.ReadKey();


            Console.WriteLine("Задание 3.");
            Dictionary<int, People> people = new Dictionary<int, People>();
            People people1 = new People();
            people1.id = 1;
            people1.name = "Михаил";
            people1.NumberProblem = 1;
            people1.problem = "не могу оплатить квитанцию ";
            people1.um = 1;
            people1.temp = 4;
            People people2 = new People();
            people2.id = 2;
            people2.name = "Аркадий";
            people2.NumberProblem = 2;
            people2.problem = "не идет отопление";
            people2.um = 1;
            people2.temp = 1;
            People people3 = new People();
            people3.id = 3;
            people3.name = "Евпатий";
            people3.NumberProblem = 3;
            people3.problem = "просто так пришел";
            people3.um = 0;
            people3.temp = 10;
            People people4 = new People();
            people4.id = 4;
            people4.name = "Соня";
            people4.NumberProblem = 2;
            people4.problem = "батареи холодные, нет отопление";
            people4.um = 1;
            people4.temp = 7;
            People people5 = new People();
            people5.id = 5;
            people5.name = "Маша";
            people5.NumberProblem = 1;
            people5.problem = "не приходит квитанция";
            people5.um = 0;
            people5.temp = 2;
            people.Add(people1.id, people1);
            people.Add(people2.id, people2);
            people.Add(people3.id, people3);
            people.Add(people4.id, people4);
            people.Add(people5.id, people5);
            Console.WriteLine("Первый клиент " + people1.name);
            Console.WriteLine("Второй клиент " + people2.name);
            Console.WriteLine("Трейтий клиент " + people3.name);
            Console.WriteLine("Четвертый клиент " + people4.name);
            Console.WriteLine("Пятый клиент " + people5.name);

            List<People> peop = new List<People>();
            peop.Add(people5);
            peop.Add(people4);
            peop.Add(people3);
            peop.Add(people2);
            peop.Add(people1);
            List<string> Name = new List<string>();
            Name.Add(people5.name);
            Name.Add(people4.name);
            Name.Add(people3.name);
            Name.Add(people2.name);
            Name.Add(people1.name);


            int mesto = 0;
            LinkedList<string> cab1 = new LinkedList<string>();
            LinkedList<string> cab2 = new LinkedList<string>();
            LinkedList<string> cab3 = new LinkedList<string>();
            for (int i = 0; i < peop.Count; i++)
            {
                Console.ReadLine();
                Console.WriteLine("Здравствуйте, я Зина скажите как вас зовут и какая проблема?");
                Console.ReadLine();
                Console.WriteLine("Меня зовут " + peop[i].name + ". Я жалуюсь на то что " + peop[i].problem);
                Console.ReadLine();
                Console.WriteLine($"Зина показывает в сторону {peop[i].NumberProblem} кабинета");
                Console.ReadLine();


                switch (peop[i].NumberProblem)
                {
                    case 1:

                        if (peop[i].um == 0)
                        {
                            Console.WriteLine("Вы тупой и идете не в тот кабинет");
                            Console.WriteLine($"Вы встаете в очередь 2 кабинета");
                            cab2.AddLast(Name[i]);
                        }

                        if (peop[i].temp >= 5)
                        {
                            Console.WriteLine("Вы наглый капец какой и поэтому встаете первым");
                            cab1.AddFirst(Name[i]);
                        }
                        if (peop[i].um == 1 && peop[i].temp < 5)
                        {
                            cab1.AddFirst(Name[i]);
                        }
                        break;
                    case 2:

                        if (peop[i].um == 0)
                        {
                            Console.WriteLine("Вы тупой и идете не в тот кабинет");
                            Console.WriteLine($"Вы встаете в очередь 3 кабинета");
                            cab3.AddLast(Name[i]);
                        }
                        if (peop[i].temp >= 5)
                        {
                            Console.WriteLine("Вы наглый капец какой и поэтому встаете первым");
                            cab2.AddFirst(Name[i]);
                        }
                        if (peop[i].um == 1 && peop[i].temp < 5)
                        {
                            cab2.AddFirst(Name[i]);
                        }


                        break;
                    default:

                        if (peop[i].um == 0)
                        {

                            Console.WriteLine("Вы тупой и идете не в тот кабинет");
                            Console.WriteLine($"Вы встаете в очередь 3 кабинета");
                            cab1.AddLast(Name[i]);
                        }
                        if (peop[i].temp >= 5)
                        {
                            Console.WriteLine("Вы наглый капец какой и поэтому встаете первым");
                            cab3.AddFirst(Name[i]);
                        }
                        if (peop[i].um == 1 && peop[i].temp < 5)
                        {
                            cab3.AddFirst(Name[i]);
                        }


                        break;
                }
            }
            Console.WriteLine("Очередь в первый кабинет: ");
            foreach (var w in cab1)
            { Console.WriteLine(w); }
            Console.WriteLine("Очередь во второй кабинет: ");
            foreach (var w in cab2)
            { Console.WriteLine(w); }
            Console.WriteLine("Очередь в третий кабинет: ");
            foreach (var w in cab3)
            { Console.WriteLine(w); }


            Console.ReadKey();

        }
    }
}
