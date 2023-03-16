using list;

Guns gun = new();
bool c = true;

do
{
    int answer;
Start: Console.WriteLine("Выберите действие\n1) Вывести все \n2) удалить элементы\n3) добавить элементы  \n4) заменить элемент \n5) добавит элемент в определенное поле \n6) найти элемент с заданной длинной \n7) вывести элемент по его id");
  answer=int.Parse(  Console.ReadLine());
    switch (answer)
    {
        case 1:
            gun.GetAll(); Console.WriteLine("Продолжить операцию? 1/0");
            string da = Console.ReadLine();
            if (da == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }
            break;
        case 2:
            Console.WriteLine("Введите имя элемента который хотите удалить");
            string remove = Console.ReadLine();
            gun.Remove(remove); Console.WriteLine("Продолжить операцию? 1/0");
            string danswer = Console.ReadLine();
            if (danswer == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }
            break;
        case 3:
            bool bbc = true;
            do
            {
                Console.WriteLine("Добавьте элемент в список или закончить добавление?(вводите значения пока не введёте 0");

                while (bbc)
                {
                    string a = Console.ReadLine();
                    if (a != "0")
                    {

                        gun.Add(a);

                    }
                    else
                    {
                        bbc = false;
                    }
                }

            } while (bbc);
            Console.WriteLine("Продолжить операцию? 1/0");
            string dah = Console.ReadLine();
            if (dah == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }
            break;

        case 4:
            Console.WriteLine("Введите номер элемента которых хотите заменить и имя нового элемента");
            int ab = Convert.ToInt32(Console.ReadLine());
            string bb = Console.ReadLine();
            gun.Update(ab, bb); Console.WriteLine("Продолжить операцию? 1/0");
            string danswera = Console.ReadLine();
            if (danswera == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }

            break;
        case 5:
            Console.WriteLine("Введите номер элемента перед которым встанет новый и имя нового элемента");
            int abb = Convert.ToInt32(Console.ReadLine());
            string bbb = Console.ReadLine();
            gun.Insert(abb, bbb); Console.WriteLine("Продолжить операцию? 1/0");
            string dac = Console.ReadLine();
            if (dac == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }
            break;
        case 6:
            Console.WriteLine("Элемент какой длинны вы хотите найти?");
            int find = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gun.FindName(find, find)); Console.WriteLine("Продолжить операцию? 1/0");
            string dacc = Console.ReadLine();
            if (dacc == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }
            break;
        case 7:
            Console.WriteLine("Введите айди элемента который хотите вывести");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gun.GetById(id)); Console.WriteLine("Продолжить операцию? 1/0");
            string daccc = Console.ReadLine();
            if (daccc == "0")
            {
                c = false;
            }
            else
            {
                goto Start;
            }
            break;
    }
} while (c);
Console.WriteLine("До свидания");
