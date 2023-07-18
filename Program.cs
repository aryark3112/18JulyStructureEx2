using System;
namespace _18JulyCustomException
{
    public class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                int userAge;
                Console.WriteLine("Enter your age");
                userAge = int.Parse(Console.ReadLine());
                if(userAge<0)
                {
                    throw new CustomException("Age must be positive number, please enter positive number only");
                }
                else if (userAge>=18)
                {
                    Console.WriteLine("You are eligible for voting");
                }
                else { Console.WriteLine("You are not eligible for voting, You have to wait "); }
            }
            catch (CustomException ce) { Console.WriteLine("Custom Error!!!"+ce.Message); }
            catch(Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
            finally { Console.WriteLine("***Bye Bye***"); }
            Console.ReadKey();

            
        }
    }
}
