using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Lesson_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo[] a = new ToDo[5];
            string workDir = @"C:\Users\GANS\Desktop\Catalog\Catalog1\Catalog2\ToDo.json";
            Console.WriteLine(File.Exists(workDir));
            int nomber = 0;
            if (File.Exists(workDir))
            {
                string json = File.ReadAllText(workDir);
                a = JsonSerializer.Deserialize<ToDo[]>(json);
                OutToDo(a, nomber);
            }
            else
            {
                Console.WriteLine("Список задач");
                //ToDo[] a = new ToDo[5];
                a[0] = new ToDo("Сходить в магазин", true);
                a[1] = new ToDo("Купить хлеб", true);
                a[2] = new ToDo("Купить молоко", true);
                a[3] = new ToDo("Вернуться домой", true);
                a[4] = new ToDo("Положить продукты в холодильник", true);
                OutToDo(a, nomber);
                //string json = File.ReadAllText(workDir);
                //a = JsonSerializer.Deserialize<ToDo>(json);
            }


            do
            {

                Console.WriteLine("Введите номер задачи чтобы ее отметить выполненной. Введите 0, чтобы сохранить и выйти.");
                nomber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                OutToDo(a, nomber);
            } while (nomber != 0);
        }
        public static void OutToDo(ToDo[] a, int nomb)
        {
            for (int j = 0; j < a.Length; j++)
            {
                switch (nomb)
                {
                    case 0:
                        string json = JsonSerializer.Serialize(a);
                        string workDir1 = @"C:\Users\GANS\Desktop\Catalog\Catalog1\Catalog2\";
                        string wok = Path.Combine(workDir1, "ToDo.json");
                        File.WriteAllText(wok, json);
                        break;
                    case 1:
                        a[0].IsDone = false;
                        break;
                    case 2:
                        a[1].IsDone = false;
                        break;
                    case 3:
                        a[2].IsDone = false;
                        break;
                    case 4:
                        a[3].IsDone = false;
                        break;
                    case 5:
                        a[4].IsDone = false;
                        break;
                }
            }
            for (int i = 0, j = 1; i < a.Length; i++, j++)
            {
                Console.WriteLine($"Задача {j}:{a[i].Info()}");
            }
        }
    }
}
