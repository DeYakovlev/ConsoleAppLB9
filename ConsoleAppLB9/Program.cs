using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppLB9
{

    enum Season 
    {
        Winter, Spring, Summer, Autumn
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }

        // Задание 1. Непараметризованные коллекции
        // Вариант 9
        public static void Task1() 
        {
            Console.WriteLine("---Начало задания 1---");
            Hashtable ht = new Hashtable();

            DateTime dt = new DateTime(2026,09,09); //0 (DateTime)
            int i = 9; // 1 (int)
            double d = 9.99; // 2 (double)
            float fl = 5.5f; // 3 (float)
            Season season = Season.Winter;// 4 (enum)
            DateTime datetime = DateTime.Now; //5 (DateTime)
            object o = new object(); //6 (object)
            Person pers = new Person("Валакас","54"); // 7 (class object)
            (int Id, string CarName) tuple = (1, "BMW"); // 8 (кортеж)
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 9 (массив)                                          
            DateTime dt2 = new DateTime(2024, 3, 15, 14, 30, 45); // 10 (DateTime)


            ht.Add(0, dt);
            ht.Add(1, i);
            ht.Add(2, d);
            ht.Add(3, fl);
            ht.Add(4, season);
            ht.Add(5, datetime);
            ht.Add(6, o);
            ht.Add(7, pers);
            ht.Add(8, tuple);
            ht.Add(9, array);
            ht.Add(10, dt2);

            //Stack<DateTime> stack = new Stack<DateTime>();
            Stack stack = new Stack();

            List<int> KeyLsit = new List<int> { };

            Console.WriteLine("Hashtable до удаления");

            foreach (DictionaryEntry TableItem in ht) 
            {
                Console.WriteLine($"Ключ:{TableItem.Key} Значение:{TableItem.Value}");

                if (TableItem.Value is DateTime)
                {
                    stack.Push((DateTime)TableItem.Value);
                    KeyLsit.Add((int)TableItem.Key);
                    //ht.Remove(TableItem.Key);
                }         
            }

            Console.WriteLine();
            Console.WriteLine("Стек с DateTime из Hashtable");
            foreach (DateTime StackItem in stack) 
            {
                Console.WriteLine(StackItem);
            }

            foreach (int key in KeyLsit) 
            {
                ht.Remove(key);
            }

            Console.WriteLine();
            Console.WriteLine("Hashtable после удаления DateTime");
            foreach (DictionaryEntry TableItemBefore in ht)
            {
                Console.WriteLine($"Ключ:{TableItemBefore.Key} Значение:{TableItemBefore.Value}");

            }

            Console.WriteLine("---Конец задания 1---");

        }
        // Задание 2. ArrayList
        public static void Task2() 
        {
            Console.WriteLine("---Начало задания 2---");
            ArrayList aList = new ArrayList();

            DateTime dt = new DateTime(2026, 09, 09); //0 (DateTime)
            int i = 9; // 1 (int)
            double d = 9.99; // 2 (double)
            float fl = 5.5f; // 3 (float)
            Season season = Season.Winter;// 4 (enum)
            DateTime datetime = DateTime.Now; //5 (DateTime)
            object o = new object(); //6 (object)
            Person pers = new Person("Валакас", "54"); // 7 (class object)
            (int Id, string CarName) tuple = (1, "BMW"); // 8 (кортеж)
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 9 (массив)                                          
            DateTime dt2 = new DateTime(2024, 3, 15, 14, 30, 45); // 10 (DateTime)

            int i2 = 9; // (int)
            double d2 = 9.99; // (double)
            float fl2 = 5.5f; // (float)
            Season season2 = Season.Spring;// (enum)
            object o2 = new object(); //(object)
            Person pers2 = new Person("Петров", "27"); // (class object)
            (int Id, string CarName) tuple2 = (1, "BMW"); //(кортеж)
            int[] array2 = { 9, 8, 7, 5, 4, 3, 2, 1, 0 }; // (массив)

            aList.Add(dt);
            aList.Add(i);
            aList.Add(d);
            aList.Add(fl);
            aList.Add(season);
            aList.Add(datetime);
            aList.Add(o);
            aList.Add(pers);
            aList.Add(tuple);
            aList.Add(array);
            aList.Add(dt2);
            aList.Add(i2);
            aList.Add(d2);
            aList.Add(fl2);
            aList.Add(season2);
            aList.Add(o2);
            aList.Add(pers2);
            aList.Add(tuple2);
            aList.Add(array2);


            ArrayList aListInt = new ArrayList();
            ArrayList aListDouble = new ArrayList();
            ArrayList aListDateTime = new ArrayList();
            ArrayList aListFloat = new ArrayList();
            ArrayList aListSeason = new ArrayList();
            ArrayList aListObject = new ArrayList();
            ArrayList aListPerson = new ArrayList();
            ArrayList aListTuple = new ArrayList();
            ArrayList aListArray = new ArrayList();

            //List<ArrayList, string> listName = new List<ArrayList>();
            Dictionary<string,ArrayList> listName = new Dictionary<string, ArrayList>();
            listName.Add("aListInt", aListInt);
            listName.Add("aListDouble", aListDouble);
            listName.Add("aListDateTime", aListDateTime);
            listName.Add("aListFloat", aListFloat);
            listName.Add("aListSeason", aListSeason);
            listName.Add("aListObject", aListObject);
            listName.Add("aListPerson", aListPerson);
            listName.Add("aListTuple", aListTuple);
            listName.Add("aListArray", aListArray);


            //Console.WriteLine(tuple.GetType().Name);


            foreach (var item in aList) 
            {
                switch (item) 
                {
                    case int n : 
                        aListInt.Add(n);
                        break;
                    case double n : 
                        aListDouble.Add(n);
                        break;
                    case DateTime n :
                        aListDateTime.Add(n);
                        break;
                    case float n :
                        aListFloat.Add(n);
                        break;
                    case Season n:
                        aListSeason.Add(n);
                        break;
                    case Person n:
                        aListPerson.Add(n);
                        break;
                    case ValueTuple<int, string> n:
                        aListTuple.Add(n);
                        break;
                    case int[] n :
                        aListArray.Add(n);
                        break;
                    case object n:
                        aListObject.Add(n);
                        break;

                }
            }


            Console.WriteLine($"Вывод общую коллекцию");
            foreach (var item in aList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();



            foreach (KeyValuePair<string, ArrayList> pair in listName) 
            {
                Console.WriteLine($"Вывод отдельню коллекцию - {pair.Key}");
                foreach (var item in pair.Value)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.WriteLine("---Конец задания 2---");


        }

        public static void Task3() 
        {
            List<Vehicle> list = new List<Vehicle>();

            Vehicle vehicle1 = new Vehicle("Vehicle");
            Car car1 = new Car("BMW");
            CarGlued carGlued = new CarGlued("Honda");
            CarExplict carExplict = new CarExplict("Mercedes");
            CarWrepped carWrepped = new CarWrepped("Lexus");

            list.Add(vehicle1);
            list.Add(car1);
            list.Add(carGlued);
            list.Add (carExplict);
            list.Add(carWrepped);
            int key;

            while (true) 
            {
                Console.WriteLine("1 – просмотр коллекции\n" +
                    "2 – добавление элемента (данные вводим с клавиатуры)\n" +
                    "3 – добавление элемента по указанному индексу (индекс и данные вводим с клавиатуры)\n" +
                    "4 – нахождение элемента с начала коллекции (переопределить метод Equals или\r\nоператор == для вашего класса – сравнение только по полю name) " +
                    "(данные для поиска\r\nпо полю name вводим с клавиатуры, вы должны иметь минимум 2 объекта в коллекции\r\nс одинаковыми именами)\n" +
                    "5 – нахождение элемента с конца коллекции (данные для поиска по полю name\r\nвводим с клавиатуры, вы должны иметь минимум 2 объекта в коллекции с\r\nодинаковыми именами)\r\n" +
                    "6 – удаление элемента по индексу (индекс вводим с клавиатуры)\n" +
                    "7 – удаление элемента по значению (данные для поиска по полю name вводим с\r\nклавиатуры)\n" +
                    "8 – реверс коллекции\n" +
                    "9 – сортировка\n" +
                    "10 – выполнение методов всех объектов, поддерживающих Interface2\n" +
                    "0 - выход");
                Console.WriteLine();
                Console.WriteLine("Введите число из меню:");

                if (int.TryParse(Console.ReadLine(), out key) && key >= 0 && key <= 10)
                {
                    //Console.WriteLine("Тут будет пожилой кейс");

                    switch (key) 
                    {
                        case 0: 
                            {
                                Console.WriteLine("Выходим из приложения...");
                                return;
                            }
                        case 1:
                            {
                                Console.WriteLine("Просмотр коллекции:");
                                foreach (Vehicle item in list)
                                    Console.WriteLine(item);
                                Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить...\n");
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Добавление эллемента:");

                                Vehicle vehicle = CreateVehicleTask3();
                                list.Add (vehicle);
                                Console.WriteLine("Элемент добавлен");

                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Добавление эллемента по индексу");
                                Console.WriteLine($"Введите индекс(текущее диапазон интектов от 0 до {list.Count}):");
                                //int index = int.Parse(Console.ReadLine());
                                
                                if (!int.TryParse(Console.ReadLine(), out int index)||index < 0 || index > list.Count) 
                                {
                                    Console.WriteLine("Индекс должен находиться в границах этого списка.\n");
                                    Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить...\n");
                                    Console.ReadKey();
                                    break;
                                }
                                Vehicle vehicle = CreateVehicleTask3();

                                list.Insert(index, vehicle);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Нахождение эллемента по имени сначала коллекции");
                                Console.WriteLine("Введите имя для поиска:");
                                string searchName = Console.ReadLine();
                                Vehicle searchVehicle = new Vehicle(searchName);

                                int index = list.IndexOf(searchVehicle);
                                
                                //if ()


                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Заглушка5");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Заглушка6");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Заглушка7");
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("Заглушка8");
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("Заглушка9");
                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine("Заглушка10");
                                break;
                            }
                    }                 
                    //break;

                }
                else 
                {
                    Console.WriteLine("неверное значение");
                    Console.WriteLine();
                }
                    


            }

 

            

        }

        public static Vehicle CreateVehicleTask3() 
        {
            Console.WriteLine("Выберите тип: 1-Vehicle, 2-Car, 3-CarGlued, 4-CarExplict, 5-CarWrepped");
            int classChois = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();



            switch (classChois) 
            {
                case 1: return new Vehicle(name);
                case 2 : return new Car(name);
                case 3 : return new CarGlued(name);
                case 4 : return new CarExplict(name);
                case 5: return new CarWrepped(name);
                default : Console.WriteLine("Неверный выбор, создан Vehicle по умолчанию");
                    return new Vehicle(name);
            }

        }






        // Задание 1. Непараметризованные коллекции
        class Person 
        {
            string Name { get; set; }
            string Age { get; set; }

            public Person(string name, string age) 
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Имя: {Name} Возраст: {Age}";
            }
        }

        //Задание 3 
        interface IMovable
        {
            void Move();
            void Stop();
            string GetStatus();

        }

        interface IServicable
        {
            void Service();
            void Stop();
            int GetServiceInterval();

        }

       public class Vehicle : IMovable
        {
            public string Name { get; set; }
            protected bool isMoving;

            public Vehicle(string name)
            {
                Name = name;
                isMoving = false;
            }

            public void Move()
            {
                isMoving = true;
                Console.WriteLine($"{Name}Начинает дважение");
            }

            public void Stop()
            {
                isMoving = false;
                Console.WriteLine($"{Name}Прекращает движение");
            }

            public virtual string GetStatus()
            {
                return isMoving ? "В движении" : "Стоит";
            }

            public override string ToString()
            {
                return $"[Vehicle] {Name}, статус: {GetStatus()}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Vehicle other)
                {
                    return this.Name == other.Name;
                }
                return false;
            } 

        }

        class SerciceStation : IServicable
        {
            public string StationName { get; set; }
            protected bool isServicing;

            public SerciceStation(string name)
            {
                StationName = name;
                isServicing = false;
            }

            public void Service()
            {
                isServicing = true;
                Console.WriteLine($"{StationName} Начинает обслуживание");
            }


            public void Stop()
            {
                isServicing = false;
                Console.WriteLine($"{StationName} Заканчивает обслуживание");
            }

            public int GetServiceInterval()
            {
                return 9000; 
            }

            public override string ToString()
            {
                return $"[SeviceStation]{StationName}, статус: {(isServicing ? "обслуживает" : "Свободна")}";
            }

        }

        class CarGlued : Vehicle, IMovable, IServicable
        {
            private bool isUnderService;

            public CarGlued(string name) : base(name) { }

            public new void Stop()
            {
                isMoving = false;
                isUnderService = false;
                Console.WriteLine($"[CarGlued] {Name} Общая остановка движение + обслуживаение");
            }

            public void Service()
            {
                isUnderService = true;
                Console.WriteLine($"[CarGlued] {Name} Начинаю обслуживание");
            }

            public int GetServiceInterval()
            {
                return 15000;
            }

            public override string ToString()
            {
                return $"[CarGlued] {Name}, движение: {isMoving}, обслуживание: {isUnderService}";
            }

        }

        class CarExplict : Vehicle, IMovable, IServicable
        {
            private bool isUnderService;

            public CarExplict(string name) : base(name) { }

            void IMovable.Stop()
            {
                isMoving = false;
                Console.WriteLine($"[CarExplict]{Name} Остановка движения (IMovable)");
            }

            void IServicable.Stop()
            {
                isUnderService = false;
                Console.WriteLine($"[CarExplict]{Name} Остановка обслуживания (IServicable)");
            }

            public void Service()
            {
                isUnderService = true;
                Console.WriteLine($"[CarExplict]{Name} Начинаю обслуживание");
            }

            public int GetServiceInterval()
            {
                return 15000;
            }

            public override string ToString()
            {
                return $"[CarExplict] {Name}, движение: {isMoving}, обслуживание: {isUnderService}";
            }

        }


        class CarWrepped : Vehicle, IMovable, IServicable
        {
            private bool isUnderService;
            public CarWrepped(string name) : base(name) { }


            public void StopMovement()
            {
                isMoving = false;
                Console.WriteLine($"[CarWrepped]{Name} Останавливаю движение(через обертку StopMovement)");
            }

            public void StopService()
            {
                isUnderService = false;
                Console.WriteLine($"[CarWrepped]{Name} Останавливаю обслуживание(через обертку StopService)");
            }

            void IMovable.Stop()
            {
                StopMovement();
            }

            void IServicable.Stop()
            {
                StopService();
            }

            public void Service()
            {
                isUnderService = true;
                Console.WriteLine($"[CarWrepped]{Name} Начинаю обслуживание");
            }

            public int GetServiceInterval()
            {
                return 15000;
            }

            public override String ToString()
            {
                return $"[CarWrepped] {Name}, движение: {isMoving}, обслуживание: {isUnderService}";
            }
        }

        class Car : Vehicle
        {
            public int FuelLevel { get; set; }

            public Car(string name) : base(name)
            {
                FuelLevel = 0;
            }

            public void Refuel(int fuel)
            {
                FuelLevel = fuel;
                Console.WriteLine($"{Name} заполнен до {FuelLevel}");
            }

            public override string ToString()
            {
                return ($"[Car]{Name}, статус {GetStatus()}, топливо: {FuelLevel}");
            }
        }

    }
}
