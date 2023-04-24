using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private string data;

        private static object locker = new object();

        private Singleton(string data)
        {
            this.data = data;
        }

        public static Singleton GetInstance(string data)
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton(data);
                    }
                }
            }
            return instance;
        }
    }
}
