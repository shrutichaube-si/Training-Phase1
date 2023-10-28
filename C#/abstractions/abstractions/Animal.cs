using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractions
{
     abstract internal class Animal
    {
        abstract public void walk();
        public void dance()
        {
            Console.WriteLine("shruti");
        }
    }
    class Animal2 : Animal

    {
        public override void walk()
        {
            Console.WriteLine("Hehe");
        }
        public void jump() {
            Console.WriteLine("jumping");
                }
    }
}
