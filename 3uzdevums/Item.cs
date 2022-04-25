using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3uzdevums_3
{
    public class Item
    {
        public Item()
        { 
        }
    public Item (double lenght, double width, double height, double weight)
    {
        ItemLenght=lenght;
        ItemWidth=width;
        ItemHeight=height;
        ItemWeight=weight;
    }
       

        private double ItemLenght;

            public double lenght
        {
            get
            {
                return ItemLenght;
            }
            set
            {
                ItemLenght = value;
            }
        }


        private double ItemWidth;
        public double width
        {
            get
            {
                return ItemWidth;
            }
            set
            {
                ItemWidth = value;
            }
        }
        private double ItemHeight;
        public double height
        {
            get
            {
                return ItemHeight;
            }
            set
            {
                ItemHeight = value;
            }
        }
        private double ItemWeight;
        public double weight
        {
            get
            {
                return ItemWeight;
            }
            set
            {
                ItemWeight = value;
            }
        }
        public void MessageItem() => Console.WriteLine(value: $"The lenght of your item is {lenght}, width {width}, height {height}, weight {weight}");
    }
    
}


