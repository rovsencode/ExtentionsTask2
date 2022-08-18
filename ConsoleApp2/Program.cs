using ConsoleApp2.Models;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Groupu daxil edin");
           string  GroupNo = Console.ReadLine();
            if(GroupNo.CheckGroupNo()==false)
            {
                Console.WriteLine("zehmet olmasa duzgun daxile edin");
                

                
            }

            Console.WriteLine("Fullname daxil edin");
            string   FullName = Console.ReadLine();
            Console.WriteLine("yasi daxil edin");
            int Age = Convert.ToInt32(Console.ReadLine());
            Student rovsen = new Student(GroupNo,FullName,Age);
          
            Console.WriteLine(rovsen.GroupNo+" "+rovsen.FullName+" "+rovsen.Age);

         
        }
    }
}
