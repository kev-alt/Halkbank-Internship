using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow cow1 = new Cow();
            cow1.FirstName = "Kevser";
            cow1.LastName = "Altunbey";
            cow1.DateOfBirth = 2002;
            cow1.Id = 123;

            Farmer farmer = new Farmer(new CowManager());
            farmer.GiveStraw(cow1);

    
            Console.ReadLine();
        }
    }
}