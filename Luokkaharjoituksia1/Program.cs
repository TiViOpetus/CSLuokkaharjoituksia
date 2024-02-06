using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokkaharjoituksia1
{
    class Hooman
    {
        // Define properties of Hooman ie. fields
        string name = "Essi Esimerkki";
        int age = 30;
        string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be crated automatically
        public Hooman()
        {

        }

        // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments
        public Hooman(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with 3 arguments
        public Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }

        // A method to say something
        public void SayOpinion()
        {
            Console.WriteLine("Voi, lemmikit ne on elämän suola");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) a hooman object from Hooman class
            Hooman owner = new Hooman("Ossi Omistaja", 35, "isäntä");

            // Call the SayOpinion method
            owner.SayOpinion();

            // Keep the window opent until enter pressed

            Console.ReadLine();


        }
    }
}
