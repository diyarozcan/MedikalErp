using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        // solid prensiplerinin 4.su olan interface segregation prensibidir.
        //single Responsibility : sınıflarımızın iyi tanımlanmıs tek bir sorumlugugu olmalı
        //open/closed: sınıflarımız degısıklıge kapalı ancak yeni davranislarin eklenmesine acik olmalidir. 
        //Liskov Substitution: Kodumuzda herhangi bir degisiklik yapmaya gerek kalmadan turetılmıs sınıfları türedikleri ata sınıfının yerine kullanabilmeyiz 
        //interface segregation: genel kullanım amaclı tek bir kontrat yerine daha ozellesmis birden cok kontrat olusturmayı tercih etmeliyiz
        //dependency inversion : katmanlı mimarilerde üst seviye moduller alt seviyedeki modullere dogrudan bagımlı olmamalıdır.
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
          void GetSalary();
    }
    class Manager : IWorker,IEat,IGetSalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker,IEat,IGetSalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
