using _15032022.Models;
using System;

namespace _15032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public,private,protected,internal,private-protected,protected-internal

            //classin ozu,instance,inheritance

            //classlarin access modifier yalniz public ve internal

            //class members methodlar,fieldler,propertyler

            #region public => class ve all class members
            //Car car1 = new Car();
            //car1.Brand = "Lorem";
            //Console.WriteLine(car1.Brand);
            #endregion

            #region protected=> all class members,
            //classin ozu,
            //instance-da el catan deyil get ve set olmur,
            //inheritance-da elcatandir

            //Car car2 = new Car();
            //car2.Speed

            #endregion

            #region private =>all class members
            //ancaq oz classinin daxilinde,
            //Car car3 = new Car();
            //car3.horsePower=10
            //typeof(Car).GetField("horsePower", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car3, 50);
            //var result = typeof(Car).GetField("horsePower", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(car3);
            //Console.WriteLine(result);
            #endregion

            #region Encapsulation

            //Car car4 = new Car();
            //car4.HorsePower = 30;
            //Console.WriteLine(car4.HorsePower);
            //Console.WriteLine(car4.GetHorsePower());
            //car4.SetHorsePower(25);

            #endregion

            #region readonly fields
            Car car5 = new Car();
            //car5.color = "loprem";
            #endregion
        }
    }
}
