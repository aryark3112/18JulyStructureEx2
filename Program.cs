﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _18JulyCustomException
{
    //public class CustomException:Exception
    //{
    //    public CustomException(string message):base(message)
    //    {

    //    }
    //}
    internal class Program
    {
        //Enumeration(Enum) Example
        public enum DayofWeek
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        static void Main(string[] args)
        {
            //try {
            //    int userAge;
            //    Console.WriteLine("Enter your age");
            //    userAge = int.Parse(Console.ReadLine());
            //    if(userAge<0)
            //    {
            //        throw new CustomException("Age must be positive number, please enter positive number only");
            //    }
            //    else if (userAge>=18)
            //    {
            //        Console.WriteLine("You are eligible for voting");
            //    }
            //    else { Console.WriteLine("You are not eligible for voting, You have to wait "); }
            //}
            //catch (CustomException ce) { Console.WriteLine("Custom Error!!!"+ce.Message); }
            //catch(Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
            //finally { Console.WriteLine("***Bye Bye***"); }
            //Console.ReadKey();

            DayofWeek today = DayofWeek.Tuesday;
            Console.WriteLine("Day: "+today);
            Console.WriteLine("Day Number "+(int)today);
            Console.ReadKey();
        }
    }
}
