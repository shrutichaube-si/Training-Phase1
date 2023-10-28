using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOPS
{
    internal class car
    {

        String carname;
        string color;
        int speed;
        public string Carname
        {
            get { return carname; }
            set { carname = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 5)
                {
                    speed = value;
                }
                else{
                    speed = 5;
                }
            }
        }
        public car() {
          string  carname;
            string color;
            int speed;
            
        }
        public car(String name, String color,int speed)
        {
            this.carname = name;
            this.color = color;
            this.speed = speed;
        }
        public car(string name,string color)
        {
            this.carname = name;
            this.color = color;
        }
        public void SpeedUp(int delta)
        {
            speed += delta;
        }
        public void Display()
        {
            WriteLine($"{carname} is {color} and at a speed of {speed}");
        }
        

    }
}
