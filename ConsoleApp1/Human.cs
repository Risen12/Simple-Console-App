using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Human
    {
        public event Action Sleep;
        public event EventHandler handler;
        public string Name { get; set; }


        public void Taketime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                Sleep?.Invoke();
            }
            else handler?.Invoke(this,null);
        }
    }
}
