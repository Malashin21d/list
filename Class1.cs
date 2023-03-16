
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
    {
        class Guns
        {
            List<string> guns = new List<string>();


            public void Add(string a)
            {
                guns.Add(a);

            }
            public void Remove(string p)
            {
                guns.Remove(p);
                Console.WriteLine("~Deleted");
            }
            public string GetById(int id)
            {
                return "Элемент с айди " + id + " " + guns[id];
            }
            public void Insert(int id, string p)
            {
                guns.Insert(id, p);

            }
            public void Update(int id, string p)
            {
                guns.RemoveRange(id, 1);
                guns.Insert(id, p);
            }
            public string FindName(int p, int condition)
            {
                if (guns.Exists(p => p.Length == condition))// проверяю есть ли элемент с заданным условием длинны
                {
                    return guns.Find(p => p.Length == condition);
                }
                else
                {
                    return "Такого оружия нет в списке";
                }

            }
            public void GetAll()
            {
                foreach (string p in guns)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }


