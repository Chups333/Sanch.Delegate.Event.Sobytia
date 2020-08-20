using System;


namespace Sanch.Delegate.Event.Sobytia
{
    /*
    void Method (int i){ // "void" и "int i" - сигнатура для делегатов , а для метода "Method (int i)" - сигнатура

    } //делегаты это переменные для методов или делегат это указатель на метод
    */

    //public delegate /*тип_возвращаемого значения*/ /*имя делегата(тип_аргумента аргумента)*/


    class Program
    {
        //public delegate int ValueDelegate(int i);

        //public delegate void MyDelegate();

        //Шаблон делигата!!!!!!!!!!!!!!!!!!!!! ACTION
        //public Action ActionDelegate; //группа делигатов которая не возвращает значение , но принимает от 0 до 16 значений
        //(создавать можно только внутри класса)
        //public delegate void Action(int i);


        //Шаблон делигата!!!!!!!!!!!!!!!!!!!!! Predicate
        //public delegate bool Predicate(int value);// возвращает булеевый значение и принимает один аргумент

        //Шаблон делигата!!!!!!!!!!!!!!!!!!!!! Func
        //public delegate int Func(string str); // последний тип-тип возвращ значения, остальные типы аргументов

        //public event MyDelegate Event; //событие
        //public event Action EventActiom;

        static void Main(string[] args)
        {
            #region Delegate
            //MyDelegate myDelegate = Method1;//присвоить метод делигату
            //myDelegate += Method4;// присвоение еще одного метода делигату
            //// нужна проверка
            //if (myDelegate != null) //myDelegate?.Invoke()
            //{
            //    myDelegate();//вызов делигата
            //}



            //MyDelegate myDelegate2 = new MyDelegate(Method4);
            //myDelegate2 += Method4;// присвоение еще одного и того же метода делигату
            //myDelegate2 -= Method4;//удаление метода из делигата
            //myDelegate2.Invoke();//еще один вызов делигата


            //MyDelegate myDelegate3 = myDelegate + myDelegate2;//сложение делигатов
            //myDelegate3.Invoke();


            //var valueDelegate = new ValueDelegate(MethodValue);// присваивание делигату метод с переменной
            //valueDelegate += MethodValue;// у всех будет одно и тоже значение
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;

            //valueDelegate((new Random()).Next(10, 50));//передача переменной делигату для метода


            ////Action action = Method1;// шаблон( можно без верхней строки шаблона делать)
            //// action(); // шаблон вызов

            ///*Action<int, int, string> action = Method1;// шаблон( можно без верхней строки шаблона делать)
            //action(); // шаблон вызов
            //*/


            ////Predicate<int> predicate;

            ////Func<stting, int> func;//от одного до 16 типов принимает

            //Console.ReadKey();
            #endregion

            #region Event
            Person person = new Person();
            person.Name = "Вася";
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));
            #endregion
        }

        #region EventObrabotchiki
        private static void Person_DoWork(object sender, EventArgs e) //обработчик события
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} работает работу");
            }
        }

        private static void Person_GoToSleep() //обработчик события
        {
            Console.WriteLine("Человек пошел спать");
            Console.ReadKey();
        }
        #endregion


        #region MethodDlyDelegate
        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void Method1()// метод 1
        {
            Console.WriteLine("Method1");
        }
        public static int Method2()// метод 2
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3(int i)// метод 3
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()// метод 4
        {
            Console.WriteLine("Method4");
        }
        #endregion

    }
}
