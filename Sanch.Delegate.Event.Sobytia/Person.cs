using System;


namespace Sanch.Delegate.Event.Sobytia
{
    class Person
    {
        public event Action GoToSleep; // событие
        public event EventHandler DoWork; // событие

        public string Name { get; set; }
        public void TakeTime(DateTime now) // метод
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();// проверка и показ
            }
            else
            {
                //var args = new EventArgs(); 
                //DoWork?.Invoke(this, args);

                
                DoWork?.Invoke(this, null);
            }
        }
    }
}
