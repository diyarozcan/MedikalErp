using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            // Miras alınan classta dahil butun classlar kullanılabilir. 
            // her bir class 1 kez miras alabilir 
            Player player = new Player();
            Coach coach = new Coach
            {
                Id = 1,
                Name = "Diyar",
                Surname = "Ozcan",
                CoachPosition = "Head coach"
            };
            Person person = new Person();
            person.Name = "hasan";
            Console.WriteLine(coach.Surname);
            Console.ReadLine();
        }
    }

    class Person  //Base Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Player:Person // Sub Class
    {
        public string Position { get; set; }
    }
    class Coach:Person //Sub Class
    {
        public string CoachPosition { get; set; }
    }
}
