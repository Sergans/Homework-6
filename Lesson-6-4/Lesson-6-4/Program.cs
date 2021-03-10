using System;

namespace Lesson_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Personcs[] person = new Personcs[5];
            person[0] = new Personcs("Аристов Сергей Иванович", "Директор", "sorok@mail.ru", 505001, 150000, 48);
            person[1] = new Personcs("Мясников Владимир Петрович", "Менеджер", "petr@mail.ru", 505002, 100000, 30);
            person[2] = new Personcs("Алексеев Сергей Иванович", "Торговый", "aleks@mail.ru", 505003, 70000, 27);
            person[3] = new Personcs("Мальгинов Иван Иванович", "Кладовщик", "mal@mail.ru", 505004, 50000, 39);
            person[4] = new Personcs("Спиридонов Константин Алексеевич", "Грузчик", "spir@mail.ru", 505005, 30000, 18);
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Age > 40)
                {
                    person[i].Info();
                }
            }
        }
    }
}
