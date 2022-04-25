using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3uzdevums_1
{
    public class Phone // Clase = datu kopnes nosaukums
    {
        public Phone(string make, string model, double height, double width, double lenght) // klases inicializaciju, ka es gribu izveidot so klasi
        { 
            Make = make;   // Ar lielo burtu - VARIABLES (properties) ar mazo ir parametri
            Model = model; 
            Height = height;
            Width = width;
            Lenght = lenght;
        }
        public Phone()
        {

        }
        public string Make { get; set; } //properties
        public string Model { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }

        public void CanCall()
        { 
        
        }
      
        public void CanSendSms()
        { 
         
        }
    }

 }
        
 