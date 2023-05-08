using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Database
    {
        private static Database Instance;
        private Database()
        {

        }

        public static Database getInstance()
        {
            if (Database.Instance == null)
            {
                Database.Instance = new Database();
            }
            return Database.Instance;
        }

        public void someQuery()
        {
            Console.WriteLine("some query");
        }
    }
}
