using System;
using System.Collections.Generic;



namespace LembdaStudentManagement
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Lembda Expression");



            List<Persons> personlist = new List<Persons>(); ;

            AddPersonList(personlist);


        }
        private static void AddPersonList(List<Persons> personlist)
        {
            personlist.Add(new Persons(1, "Shivam","Bhopal",17,"3898398989"));
            personlist.Add(new Persons(2, "Aakanksha", "Bhilai", 18, "49898498894"));
            personlist.Add(new Persons(3, "Divya", "Up", 19, "90293909330"));
            personlist.Add(new Persons(4, "Akshay kumar", "Mumbai", 15, "0290392093029"));
            personlist.Add(new Persons(5, "Anil Kapoor", "Delhi", 19, "93984938493"));
            personlist.Add(new Persons(6, "Shraddha Kapoor", "Mumbai", 16, "938498938384"));
            personlist.Add(new Persons(7, "Ankita Chhettri", "Nepal", 15, "93983934893"));

          

        }


    }
}
 

