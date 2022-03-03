using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
    class UseMsSqlServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MsSql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MsSql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MsSql Updated");
        }
    }
    class UseOracleServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("MsSql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MsSql Updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) //parametre olarak verdik. Constructure olarak yapacagiz
        {
            customerDal.Add();
        }
    }
}
