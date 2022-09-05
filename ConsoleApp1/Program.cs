using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Singleton
    {
        static void Main(string[] args)
        {
            Counter counter = Counter.Instance;
            counter.incrementCounter();
            counter.decrementCounter();
        }
    }

    public class Counter
    {
        public int count = 0;
        public static Counter instance = null;
        private Counter() {  }
        public static Counter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Counter();
                }
                return instance;
            }
        }

        public void incrementCounter()
        {
            
            count += 1;
            Console.WriteLine(count);
            //Console.WriteLine("Hi");
            Console.ReadLine();
        }

        public void decrementCounter()
        {

            count -= 1;
            Console.WriteLine(count);
            //Console.WriteLine("Hello");
            Console.ReadLine();
        }


    }
}
