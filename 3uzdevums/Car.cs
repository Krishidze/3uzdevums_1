using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3uzdevums_2
{
    public class Car
    {
        public Car(string make, string plateLetters, int plateNumber, string maxSpeed)
        {
            make = Make;
            plateLetters = PlateLetters;
            plateNumber = PlateNumber;
            maxSpeed = MaxSpeed;
        }
        public Car()
        {
        
        }

        public string Make { get; set; }
        public string PlateLetters { get; set; }
        public int PlateNumber { get; set; } 
        public string MaxSpeed { get; set; }

        public bool IsInMotion
        { 
            get
              {
            return IsInMotion = true;
             }
            set
            { 
            
            }
        }
        public string GetToMaxSpeed
        {
            get
            {
                return MaxSpeed=MaxSpeed+1;
            }
            set 
            {
              
            }
        }
        public bool IsStopped
        { 
        get { return IsInMotion = false; }
        }
        public void MessageCar()
        {
            Console.WriteLine("Beep Beep");
        }
    }
}
