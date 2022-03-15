using System;
using System.Collections.Generic;
using System.Text;

namespace _15032022.Models
{
    class Car
    {
        public string Brand;
        public string Model;
        protected int Speed;
        private int horsePower;
        //private readonly string color="red";
        //public string color { get; }
        public string color { get; private set; }
        public int Age { get; set; }

        //public const int test;
        //public readonly int test1;

        //public Car()
        //{
        //    test1 = 1;
        //}


        //public int Motor;
        public int HorsePower
        {
            get
            {
                if (horsePower == 0)
                {
                    Console.WriteLine("power 0 ola bilmez");
                    return -1;
                }
                return horsePower;
            }
            set
            {
                if (value < 20)
                {
                    Console.WriteLine("Power 20den kicik ola bilmez");
                    return;
                }
                horsePower = value;
                Console.WriteLine("Okay set olundu");
            }
        }

        //public void ChangeNumber()
        //{
        //    test = 4;
        //    test1 = 5;
        //}

        //public int GetHorsePower()
        //{
        //    if (horsePower==0)
        //    {
        //        Console.WriteLine("power 0 ola bilmez");
        //        return -1;
        //    }
        //    return horsePower;
        //}

        //public void SetHorsePower(int power)
        //{
        //    if (power<20)
        //    {
        //        Console.WriteLine("Power 20den kicik ola bilmez");
        //        return;
        //    }
        //    horsePower = power;
        //    Console.WriteLine("Okay set olundu");
        //}



        public Car()
        {
            // Console.WriteLine("Car created");
            color = "red";
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            //Speed = 50;
            //horsePower = 10;
        }
    }
}
